using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CLIPSNET;


namespace ClipsFormsExample
{
    public partial class ClipsFormsExample : Form
    {
        private CLIPSNET.Environment clips = new CLIPSNET.Environment();
        /// <summary>
        /// Распознаватель речи
        /// </summary>
        //private Microsoft.Speech.Synthesis.SpeechSynthesizer synth;
        
        /// <summary>
        /// Распознавалка
        /// </summary>
        //private Microsoft.Speech.Recognition.SpeechRecognitionEngine recogn;
        private List<string> ruleConfidenceFacts = new List<string>();
        public ClipsFormsExample()
        {
            InitializeComponent();
            typeDropdown.SelectedIndex = 0;
            requirementDropdown.SelectedIndex = 0;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void HandleResponse()
        {
            //  Вытаскиаваем факт из ЭС
            String evalStr = "(find-fact ((?f ioproxy)) TRUE)";
            FactAddressValue fv = (FactAddressValue)((MultifieldValue)clips.Eval(evalStr))[0];

            MultifieldValue damf = (MultifieldValue)fv["messages"];
            MultifieldValue vamf = (MultifieldValue)fv["answers"];

            outputBox.Text += "Новая итерация : " + System.Environment.NewLine;
            for (int i = 0; i < damf.Count; i++)
            {
                LexemeValue da = (LexemeValue)damf[i];
                byte[] bytes = Encoding.Default.GetBytes(da.Value);
                string message = Encoding.UTF8.GetString(bytes);
                //synth.SpeakAsync(message);
                outputBox.Text += message + System.Environment.NewLine;
            }
           
            
            if(vamf.Count == 0)
                clips.Eval("(assert (clearmessage))");
        }

        private void print_facts()
        {
            foreach (var fact in clips.GetFactList())
            {
                StringBuilder factData = new StringBuilder($"({fact.RelationName} ");
                fact.GetSlotValues().ForEach(v => { factData.Append($"({v.SlotName} {v.Contents})"); });
                factData.Append(')');
                Console.WriteLine(factData.ToString());
            }
            Console.WriteLine("------------------------------------------------------------------");
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            clips.Run();
            HandleResponse();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            outputBox.Text = "Выполнены команды Clear и Reset." + System.Environment.NewLine;
            //  Здесь сохранение в файл, и потом инициализация через него
            clips.Clear();

            //  Так тоже можно - без промежуточного вывода в файл
            clips.LoadFromString(codeBox.Text);

            clips.Reset();

            foreach(var fact in ruleConfidenceFacts)
            {
                clips.Eval(fact);
            }
        }

        String map_fact_number_to_group(String fact)
        {
            int number = int.Parse(fact.Substring(1));
            if (number < 200)
            {
                return "type";
            } else if (number < 300)
            {
                return "requirement";
            } else if (number < 400)
            {
                return "platform";
            } else if (number < 500)
            {
                return "language";
            } else if (number < 600)
            {
                return "framework";
            } else
            {
                return "language_property";
            }
        }
        private void openFile_Click(object sender, EventArgs e)
        {
            if (clipsOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Dictionary<String, String> facts = new Dictionary<String, String>();
                int ruleNum = 0;
                StringBuilder database = new StringBuilder();
                database.Append(System.IO.File.ReadAllText("../../common_rules_2.0.txt"));
                foreach (String line in System.IO.File.ReadAllLines(clipsOpenFileDialog.FileName))
                {
                    if (line.Contains(':'))
                    {
                        String[] parts = line.Split(':');
                        facts[parts[0].Trim()] = parts[1].Trim();
                    }
                    else if (line.Contains('='))
                    {
                        String[] ruleConf = line.Split(';');
                        String[] premiseResult = ruleConf[0].Split('=');
                        String resultGroup = map_fact_number_to_group(premiseResult[1].Trim());
                        double ruleConfidence = 0.9;
                        if (ruleConf.Length > 1 && ruleConf[1].Trim().Length > 0)
                        {
                            ruleConfidence = double.Parse(ruleConf[1].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture);
                        }
                        StringBuilder defrule = new StringBuilder($"(defrule rule{ruleNum}\r\n");
                        int salience = int.Parse(premiseResult[1].Trim()[1].ToString());
                        if (salience == 6 || salience < 3)
                        {
                            salience = 0;
                        }
                        defrule.Append($"\t(declare (salience {salience}))\r\n");
                        defrule.Append($"\t(rule_confidence (ruleNumber {ruleNum}) (confidence {ruleConfidence.ToString(CultureInfo.InvariantCulture)}))\r\n");
                        int i = 1;
                        foreach (String premise in premiseResult[0].Split(','))
                        {
                            String premiseGroup = map_fact_number_to_group(premise.Trim());
                            defrule.Append($"\t(fact_with_confidence (fact \"{facts[premise.Trim()]}\") (confidence ?f{i}_confidence))\r\n");
                            i++;
                        }
                        defrule.Append($"=>\r\n");
                        defrule.Append($"\t(bind ?min_fact_confidence (min 1.0");
                        i--;
                        while (i >= 1)
                        {
                            defrule.Append($" ?f{i}_confidence");
                            i--;
                        }
                        defrule.Append("))\r\n");
                        defrule.Append($"\t(bind ?res_confidence (* ?min_fact_confidence {ruleConfidence.ToString(CultureInfo.InvariantCulture)}))\r\n");
                        defrule.Append($"\t(assert (fact_with_confidence (fact \"{facts[premiseResult[1].Trim()]}\") (confidence ?res_confidence)))\r\n");
                        defrule.Append($"\t(assert (sendmessagehalt \"Выведено: {facts[premiseResult[1].Trim()]} с уверенностью \" (str-cat ?res_confidence)))\r\n)\r\n");
                        database.Append(defrule);
                        ruleConfidenceFacts.Add($"(assert (rule_confidence (ruleNumber {ruleNum}) (confidence {ruleConfidence.ToString(CultureInfo.InvariantCulture)})))");
                        ruleNum += 1;
                    }
                }
                codeBox.Text = database.ToString();
                //codeBox.Text = System.IO.File.ReadAllText(clipsOpenFileDialog.FileName);
                Text = "Экспертная система \"Стек проекта\" – " + clipsOpenFileDialog.FileName;
            }
        }
        private void typePick_Click(object sender, EventArgs e)
        {
            string type = typeDropdown.GetItemText(typeDropdown.Items[typeDropdown.SelectedIndex]);
            clips.Eval($"(assert (add-fact (fact \"{type}\") (confidence {typeConfidenceTB.Text})))");
            clips.Run();
            print_facts();
            clips.Run();
            print_facts();
            HandleResponse();
        }

        private void requirementPick_Click(object sender, EventArgs e)
        {
            string requirement = requirementDropdown.GetItemText(requirementDropdown.Items[requirementDropdown.SelectedIndex]);
            clips.Eval($"(assert (add-fact (fact \"{requirement}\") (confidence {requirementConfidenceTB.Text})))");
            clips.Run();
            print_facts();
            clips.Run();
            print_facts();
            HandleResponse();
        }

        private void languagePropertyPick_Click(object sender, EventArgs e)
        {
            string property = languagePropertyDropdown.GetItemText(languagePropertyDropdown.Items[languagePropertyDropdown.SelectedIndex]);
            clips.Eval($"(assert (add-fact (fact \"{property}\") (confidence {languagePropertyConfidenceTB.Text})))");
            clips.Run();
            print_facts();
            clips.Run();
            print_facts();
            HandleResponse();
        }
    }
}
