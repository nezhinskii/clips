namespace ClipsFormsExample
{
    partial class ClipsFormsExample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipsFormsExample));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.languagePropertyConfidenceTB = new System.Windows.Forms.TextBox();
            this.languagePropertyPick = new System.Windows.Forms.Button();
            this.languagePropertyDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.requirementConfidenceTB = new System.Windows.Forms.TextBox();
            this.typeConfidenceTB = new System.Windows.Forms.TextBox();
            this.requirementPick = new System.Windows.Forms.Button();
            this.requirementDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typePick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.typeDropdown = new System.Windows.Forms.ComboBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.clipsOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.clipsSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 632);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.codeBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.outputBox);
            this.splitContainer1.Size = new System.Drawing.Size(1329, 632);
            this.splitContainer1.SplitterDistance = 779;
            this.splitContainer1.TabIndex = 2;
            // 
            // codeBox
            // 
            this.codeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeBox.Location = new System.Drawing.Point(0, 0);
            this.codeBox.Multiline = true;
            this.codeBox.Name = "codeBox";
            this.codeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.codeBox.Size = new System.Drawing.Size(779, 632);
            this.codeBox.TabIndex = 2;
            // 
            // outputBox
            // 
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.Location = new System.Drawing.Point(0, 0);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(546, 632);
            this.outputBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.languagePropertyConfidenceTB);
            this.panel2.Controls.Add(this.languagePropertyPick);
            this.panel2.Controls.Add(this.languagePropertyDropdown);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.requirementConfidenceTB);
            this.panel2.Controls.Add(this.typeConfidenceTB);
            this.panel2.Controls.Add(this.requirementPick);
            this.panel2.Controls.Add(this.requirementDropdown);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.typePick);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.typeDropdown);
            this.panel2.Controls.Add(this.nextButton);
            this.panel2.Controls.Add(this.resetButton);
            this.panel2.Controls.Add(this.openButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 586);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1331, 100);
            this.panel2.TabIndex = 6;
            // 
            // languagePropertyConfidenceTB
            // 
            this.languagePropertyConfidenceTB.Location = new System.Drawing.Point(709, 68);
            this.languagePropertyConfidenceTB.Name = "languagePropertyConfidenceTB";
            this.languagePropertyConfidenceTB.Size = new System.Drawing.Size(42, 20);
            this.languagePropertyConfidenceTB.TabIndex = 21;
            this.languagePropertyConfidenceTB.Text = "1.0";
            this.languagePropertyConfidenceTB.Visible = false;
            // 
            // languagePropertyPick
            // 
            this.languagePropertyPick.Location = new System.Drawing.Point(759, 67);
            this.languagePropertyPick.Name = "languagePropertyPick";
            this.languagePropertyPick.Size = new System.Drawing.Size(75, 23);
            this.languagePropertyPick.TabIndex = 20;
            this.languagePropertyPick.Text = "Добавить";
            this.languagePropertyPick.UseVisualStyleBackColor = true;
            this.languagePropertyPick.Visible = false;
            this.languagePropertyPick.Click += new System.EventHandler(this.languagePropertyPick_Click);
            // 
            // languagePropertyDropdown
            // 
            this.languagePropertyDropdown.FormattingEnabled = true;
            this.languagePropertyDropdown.Items.AddRange(new object[] {
            "Компилируемый",
            "Интерпретируемый",
            "Статическая типизация",
            "Динамическая типизация",
            "ООП",
            "ФП"});
            this.languagePropertyDropdown.Location = new System.Drawing.Point(563, 67);
            this.languagePropertyDropdown.Name = "languagePropertyDropdown";
            this.languagePropertyDropdown.Size = new System.Drawing.Size(140, 21);
            this.languagePropertyDropdown.TabIndex = 19;
            this.languagePropertyDropdown.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Свойства";
            this.label3.Visible = false;
            // 
            // requirementConfidenceTB
            // 
            this.requirementConfidenceTB.Location = new System.Drawing.Point(709, 41);
            this.requirementConfidenceTB.Name = "requirementConfidenceTB";
            this.requirementConfidenceTB.Size = new System.Drawing.Size(42, 20);
            this.requirementConfidenceTB.TabIndex = 17;
            this.requirementConfidenceTB.Text = "1.0";
            // 
            // typeConfidenceTB
            // 
            this.typeConfidenceTB.Location = new System.Drawing.Point(346, 40);
            this.typeConfidenceTB.Name = "typeConfidenceTB";
            this.typeConfidenceTB.Size = new System.Drawing.Size(42, 20);
            this.typeConfidenceTB.TabIndex = 16;
            this.typeConfidenceTB.Text = "1.0";
            // 
            // requirementPick
            // 
            this.requirementPick.Location = new System.Drawing.Point(759, 40);
            this.requirementPick.Name = "requirementPick";
            this.requirementPick.Size = new System.Drawing.Size(75, 23);
            this.requirementPick.TabIndex = 15;
            this.requirementPick.Text = "Добавить";
            this.requirementPick.UseVisualStyleBackColor = true;
            this.requirementPick.Click += new System.EventHandler(this.requirementPick_Click);
            // 
            // requirementDropdown
            // 
            this.requirementDropdown.FormattingEnabled = true;
            this.requirementDropdown.Items.AddRange(new object[] {
            "Быстродействие",
            "Быстрое прототипирование",
            "Популярность технологии",
            "Широкая кастомизация",
            "Решение из коробки",
            "Предсказуемость"});
            this.requirementDropdown.Location = new System.Drawing.Point(563, 40);
            this.requirementDropdown.Name = "requirementDropdown";
            this.requirementDropdown.Size = new System.Drawing.Size(140, 21);
            this.requirementDropdown.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Требования";
            // 
            // typePick
            // 
            this.typePick.Location = new System.Drawing.Point(394, 39);
            this.typePick.Name = "typePick";
            this.typePick.Size = new System.Drawing.Size(75, 23);
            this.typePick.TabIndex = 12;
            this.typePick.Text = "Добавить";
            this.typePick.UseVisualStyleBackColor = true;
            this.typePick.Click += new System.EventHandler(this.typePick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Тип проекта";
            // 
            // typeDropdown
            // 
            this.typeDropdown.FormattingEnabled = true;
            this.typeDropdown.Items.AddRange(new object[] {
            "Сайт",
            "Сервер",
            "Data science",
            "Игра",
            "Мобильное приложение",
            "Desktop"});
            this.typeDropdown.Location = new System.Drawing.Point(225, 39);
            this.typeDropdown.Name = "typeDropdown";
            this.typeDropdown.Size = new System.Drawing.Size(115, 21);
            this.typeDropdown.TabIndex = 10;
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Location = new System.Drawing.Point(1199, 34);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(120, 30);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "Дальше";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(1046, 35);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(120, 30);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Рестарт";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 35);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(120, 30);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openFile_Click);
            // 
            // clipsOpenFileDialog
            // 
            this.clipsOpenFileDialog.Filter = "TXT files|*.txt|All files|*.*";
            this.clipsOpenFileDialog.Title = "Открыть файл кода CLIPS";
            // 
            // clipsSaveFileDialog
            // 
            this.clipsSaveFileDialog.Filter = "CLIPS files|*.clp|All files|*.*";
            this.clipsSaveFileDialog.Title = "Созранить файл как...";
            // 
            // ClipsFormsExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(660, 300);
            this.Name = "ClipsFormsExample";
            this.Text = "Экспертная система \"Стек проекта\"";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TextBox codeBox;
    private System.Windows.Forms.TextBox outputBox;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button nextButton;
    private System.Windows.Forms.Button resetButton;
    private System.Windows.Forms.Button openButton;
    private System.Windows.Forms.OpenFileDialog clipsOpenFileDialog;
    private System.Windows.Forms.FontDialog fontDialog1;
    private System.Windows.Forms.SaveFileDialog clipsSaveFileDialog;
        private System.Windows.Forms.ComboBox typeDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button typePick;
        private System.Windows.Forms.Button requirementPick;
        private System.Windows.Forms.ComboBox requirementDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeConfidenceTB;
        private System.Windows.Forms.TextBox requirementConfidenceTB;
        private System.Windows.Forms.TextBox languagePropertyConfidenceTB;
        private System.Windows.Forms.Button languagePropertyPick;
        private System.Windows.Forms.ComboBox languagePropertyDropdown;
        private System.Windows.Forms.Label label3;
    }
}

