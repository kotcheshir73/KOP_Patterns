namespace WindowsFormsApplicationPatterns
{
    partial class FormInterpreter
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlInterpreter = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.groupBoxSetExpression = new System.Windows.Forms.GroupBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxRightNumber = new System.Windows.Forms.TextBox();
            this.labelRightNumber = new System.Windows.Forms.Label();
            this.comboBoxExpression = new System.Windows.Forms.ComboBox();
            this.labelExpression = new System.Windows.Forms.Label();
            this.textBoxLeftNumber = new System.Windows.Forms.TextBox();
            this.labelLeftNumber = new System.Windows.Forms.Label();
            this.groupBoxSetNumber = new System.Windows.Forms.GroupBox();
            this.buttonSaveNumber = new System.Windows.Forms.Button();
            this.labelNumberName = new System.Windows.Forms.Label();
            this.textBoxNumberValue = new System.Windows.Forms.TextBox();
            this.textBoxNumberName = new System.Windows.Forms.TextBox();
            this.labelNumberValue = new System.Windows.Forms.Label();
            this.tabControlInterpreter.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxSetExpression.SuspendLayout();
            this.groupBoxSetNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlInterpreter
            // 
            this.tabControlInterpreter.Controls.Add(this.tabPage1);
            this.tabControlInterpreter.Controls.Add(this.tabPage2);
            this.tabControlInterpreter.Controls.Add(this.tabPage3);
            this.tabControlInterpreter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInterpreter.Location = new System.Drawing.Point(0, 0);
            this.tabControlInterpreter.Name = "tabControlInterpreter";
            this.tabControlInterpreter.SelectedIndex = 0;
            this.tabControlInterpreter.Size = new System.Drawing.Size(984, 461);
            this.tabControlInterpreter.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBoxDescribe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Описание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDescribe
            // 
            this.richTextBoxDescribe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDescribe.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxDescribe.Name = "richTextBoxDescribe";
            this.richTextBoxDescribe.ReadOnly = true;
            this.richTextBoxDescribe.Size = new System.Drawing.Size(970, 429);
            this.richTextBoxDescribe.TabIndex = 0;
            this.richTextBoxDescribe.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBoxClass);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Классы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxClass
            // 
            this.richTextBoxClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxClass.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxClass.Name = "richTextBoxClass";
            this.richTextBoxClass.ReadOnly = true;
            this.richTextBoxClass.Size = new System.Drawing.Size(970, 429);
            this.richTextBoxClass.TabIndex = 0;
            this.richTextBoxClass.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxResult);
            this.tabPage3.Controls.Add(this.groupBoxSetExpression);
            this.tabPage3.Controls.Add(this.groupBoxSetNumber);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(259, 205);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(447, 212);
            this.listBoxResult.TabIndex = 2;
            // 
            // groupBoxSetExpression
            // 
            this.groupBoxSetExpression.Controls.Add(this.buttonCalc);
            this.groupBoxSetExpression.Controls.Add(this.textBoxRightNumber);
            this.groupBoxSetExpression.Controls.Add(this.labelRightNumber);
            this.groupBoxSetExpression.Controls.Add(this.comboBoxExpression);
            this.groupBoxSetExpression.Controls.Add(this.labelExpression);
            this.groupBoxSetExpression.Controls.Add(this.textBoxLeftNumber);
            this.groupBoxSetExpression.Controls.Add(this.labelLeftNumber);
            this.groupBoxSetExpression.Location = new System.Drawing.Point(259, 32);
            this.groupBoxSetExpression.Name = "groupBoxSetExpression";
            this.groupBoxSetExpression.Size = new System.Drawing.Size(447, 137);
            this.groupBoxSetExpression.TabIndex = 1;
            this.groupBoxSetExpression.TabStop = false;
            this.groupBoxSetExpression.Text = "Задать выражение:";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(322, 90);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(96, 27);
            this.buttonCalc.TabIndex = 6;
            this.buttonCalc.Text = "Посчитать";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBoxRightNumber
            // 
            this.textBoxRightNumber.Location = new System.Drawing.Point(322, 53);
            this.textBoxRightNumber.Name = "textBoxRightNumber";
            this.textBoxRightNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxRightNumber.TabIndex = 5;
            // 
            // labelRightNumber
            // 
            this.labelRightNumber.AutoSize = true;
            this.labelRightNumber.Location = new System.Drawing.Point(330, 27);
            this.labelRightNumber.Name = "labelRightNumber";
            this.labelRightNumber.Size = new System.Drawing.Size(92, 13);
            this.labelRightNumber.TabIndex = 4;
            this.labelRightNumber.Text = "Правый операнд";
            // 
            // comboBoxExpression
            // 
            this.comboBoxExpression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExpression.FormattingEnabled = true;
            this.comboBoxExpression.Location = new System.Drawing.Point(122, 53);
            this.comboBoxExpression.Name = "comboBoxExpression";
            this.comboBoxExpression.Size = new System.Drawing.Size(183, 21);
            this.comboBoxExpression.TabIndex = 3;
            // 
            // labelExpression
            // 
            this.labelExpression.AutoSize = true;
            this.labelExpression.Location = new System.Drawing.Point(173, 28);
            this.labelExpression.Name = "labelExpression";
            this.labelExpression.Size = new System.Drawing.Size(69, 13);
            this.labelExpression.TabIndex = 2;
            this.labelExpression.Text = "Выражение:";
            // 
            // textBoxLeftNumber
            // 
            this.textBoxLeftNumber.Location = new System.Drawing.Point(6, 54);
            this.textBoxLeftNumber.Name = "textBoxLeftNumber";
            this.textBoxLeftNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxLeftNumber.TabIndex = 1;
            // 
            // labelLeftNumber
            // 
            this.labelLeftNumber.AutoSize = true;
            this.labelLeftNumber.Location = new System.Drawing.Point(15, 28);
            this.labelLeftNumber.Name = "labelLeftNumber";
            this.labelLeftNumber.Size = new System.Drawing.Size(86, 13);
            this.labelLeftNumber.TabIndex = 0;
            this.labelLeftNumber.Text = "Левый операнд";
            // 
            // groupBoxSetNumber
            // 
            this.groupBoxSetNumber.Controls.Add(this.buttonSaveNumber);
            this.groupBoxSetNumber.Controls.Add(this.labelNumberName);
            this.groupBoxSetNumber.Controls.Add(this.textBoxNumberValue);
            this.groupBoxSetNumber.Controls.Add(this.textBoxNumberName);
            this.groupBoxSetNumber.Controls.Add(this.labelNumberValue);
            this.groupBoxSetNumber.Location = new System.Drawing.Point(27, 32);
            this.groupBoxSetNumber.Name = "groupBoxSetNumber";
            this.groupBoxSetNumber.Size = new System.Drawing.Size(200, 157);
            this.groupBoxSetNumber.TabIndex = 0;
            this.groupBoxSetNumber.TabStop = false;
            this.groupBoxSetNumber.Text = "Задать переменную:";
            // 
            // buttonSaveNumber
            // 
            this.buttonSaveNumber.Location = new System.Drawing.Point(60, 114);
            this.buttonSaveNumber.Name = "buttonSaveNumber";
            this.buttonSaveNumber.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveNumber.TabIndex = 4;
            this.buttonSaveNumber.Text = "Сохранить";
            this.buttonSaveNumber.UseVisualStyleBackColor = true;
            this.buttonSaveNumber.Click += new System.EventHandler(this.buttonSaveNumber_Click);
            // 
            // labelNumberName
            // 
            this.labelNumberName.AutoSize = true;
            this.labelNumberName.Location = new System.Drawing.Point(19, 28);
            this.labelNumberName.Name = "labelNumberName";
            this.labelNumberName.Size = new System.Drawing.Size(32, 13);
            this.labelNumberName.TabIndex = 0;
            this.labelNumberName.Text = "Имя:";
            // 
            // textBoxNumberValue
            // 
            this.textBoxNumberValue.Location = new System.Drawing.Point(83, 67);
            this.textBoxNumberValue.Name = "textBoxNumberValue";
            this.textBoxNumberValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberValue.TabIndex = 3;
            // 
            // textBoxNumberName
            // 
            this.textBoxNumberName.Location = new System.Drawing.Point(83, 25);
            this.textBoxNumberName.Name = "textBoxNumberName";
            this.textBoxNumberName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberName.TabIndex = 1;
            // 
            // labelNumberValue
            // 
            this.labelNumberValue.AutoSize = true;
            this.labelNumberValue.Location = new System.Drawing.Point(19, 70);
            this.labelNumberValue.Name = "labelNumberValue";
            this.labelNumberValue.Size = new System.Drawing.Size(58, 13);
            this.labelNumberValue.TabIndex = 2;
            this.labelNumberValue.Text = "Значение:";
            // 
            // FormInterpreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlInterpreter);
            this.Name = "FormInterpreter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interpreter";
            this.Load += new System.EventHandler(this.FormInterpreter_Load);
            this.tabControlInterpreter.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBoxSetExpression.ResumeLayout(false);
            this.groupBoxSetExpression.PerformLayout();
            this.groupBoxSetNumber.ResumeLayout(false);
            this.groupBoxSetNumber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInterpreter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxNumberName;
        private System.Windows.Forms.Label labelNumberName;
        private System.Windows.Forms.Label labelNumberValue;
        private System.Windows.Forms.TextBox textBoxNumberValue;
        private System.Windows.Forms.GroupBox groupBoxSetNumber;
        private System.Windows.Forms.Button buttonSaveNumber;
        private System.Windows.Forms.GroupBox groupBoxSetExpression;
        private System.Windows.Forms.Label labelLeftNumber;
        private System.Windows.Forms.ComboBox comboBoxExpression;
        private System.Windows.Forms.Label labelExpression;
        private System.Windows.Forms.TextBox textBoxLeftNumber;
        private System.Windows.Forms.TextBox textBoxRightNumber;
        private System.Windows.Forms.Label labelRightNumber;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}