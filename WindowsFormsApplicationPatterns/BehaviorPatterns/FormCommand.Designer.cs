namespace WindowsFormsApplicationPatterns
{
    partial class FormCommand
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
            this.tabControlCommand = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelSelect = new System.Windows.Forms.Label();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxPult = new System.Windows.Forms.GroupBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.tabControlCommand.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCommand
            // 
            this.tabControlCommand.Controls.Add(this.tabPage1);
            this.tabControlCommand.Controls.Add(this.tabPage2);
            this.tabControlCommand.Controls.Add(this.tabPage3);
            this.tabControlCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCommand.Location = new System.Drawing.Point(0, 0);
            this.tabControlCommand.Name = "tabControlCommand";
            this.tabControlCommand.SelectedIndex = 0;
            this.tabControlCommand.Size = new System.Drawing.Size(984, 461);
            this.tabControlCommand.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.groupBoxPult);
            this.tabPage3.Controls.Add(this.buttonAdd);
            this.tabPage3.Controls.Add(this.comboBoxTypes);
            this.tabPage3.Controls.Add(this.labelSelect);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(70, 29);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(93, 13);
            this.labelSelect.TabIndex = 0;
            this.labelSelect.Text = "Список функций:";
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Items.AddRange(new object[] {
            "TV",
            "Volume",
            "MusicCenter"});
            this.comboBoxTypes.Location = new System.Drawing.Point(29, 54);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(184, 21);
            this.comboBoxTypes.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(53, 108);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(144, 41);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить на пульт";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxPult
            // 
            this.groupBoxPult.Location = new System.Drawing.Point(284, 6);
            this.groupBoxPult.Name = "groupBoxPult";
            this.groupBoxPult.Size = new System.Drawing.Size(184, 421);
            this.groupBoxPult.TabIndex = 3;
            this.groupBoxPult.TabStop = false;
            this.groupBoxPult.Text = "Пульт";
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(533, 6);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(314, 420);
            this.listBoxResult.TabIndex = 4;
            // 
            // FormCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlCommand);
            this.Name = "FormCommand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command";
            this.Load += new System.EventHandler(this.FormCommand_Load);
            this.tabControlCommand.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCommand;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxPult;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}