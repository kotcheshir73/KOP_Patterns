namespace WindowsFormsApplicationPatterns
{
    partial class FormChainOfResponsibility
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
            this.tabControlChainOfResponsibility = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBoxMoney = new System.Windows.Forms.GroupBox();
            this.checkBoxMoney = new System.Windows.Forms.CheckBox();
            this.checkBoxPayPal = new System.Windows.Forms.CheckBox();
            this.checkBoxBank = new System.Windows.Forms.CheckBox();
            this.tabControlChainOfResponsibility.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxMoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlChainOfResponsibility
            // 
            this.tabControlChainOfResponsibility.Controls.Add(this.tabPage1);
            this.tabControlChainOfResponsibility.Controls.Add(this.tabPage2);
            this.tabControlChainOfResponsibility.Controls.Add(this.tabPage3);
            this.tabControlChainOfResponsibility.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlChainOfResponsibility.Location = new System.Drawing.Point(0, 0);
            this.tabControlChainOfResponsibility.Name = "tabControlChainOfResponsibility";
            this.tabControlChainOfResponsibility.SelectedIndex = 0;
            this.tabControlChainOfResponsibility.Size = new System.Drawing.Size(984, 461);
            this.tabControlChainOfResponsibility.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.buttonSend);
            this.tabPage3.Controls.Add(this.groupBoxMoney);
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
            this.listBoxResult.Location = new System.Drawing.Point(411, 18);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(445, 394);
            this.listBoxResult.TabIndex = 2;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(100, 222);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(111, 45);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupBoxMoney
            // 
            this.groupBoxMoney.Controls.Add(this.checkBoxMoney);
            this.groupBoxMoney.Controls.Add(this.checkBoxPayPal);
            this.groupBoxMoney.Controls.Add(this.checkBoxBank);
            this.groupBoxMoney.Location = new System.Drawing.Point(50, 28);
            this.groupBoxMoney.Name = "groupBoxMoney";
            this.groupBoxMoney.Size = new System.Drawing.Size(234, 173);
            this.groupBoxMoney.TabIndex = 0;
            this.groupBoxMoney.TabStop = false;
            this.groupBoxMoney.Text = "Варинаты отправок денег";
            // 
            // checkBoxMoney
            // 
            this.checkBoxMoney.AutoSize = true;
            this.checkBoxMoney.Location = new System.Drawing.Point(36, 128);
            this.checkBoxMoney.Name = "checkBoxMoney";
            this.checkBoxMoney.Size = new System.Drawing.Size(166, 17);
            this.checkBoxMoney.TabIndex = 2;
            this.checkBoxMoney.Text = "Через денежные переводы";
            this.checkBoxMoney.UseVisualStyleBackColor = true;
            // 
            // checkBoxPayPal
            // 
            this.checkBoxPayPal.AutoSize = true;
            this.checkBoxPayPal.Location = new System.Drawing.Point(36, 80);
            this.checkBoxPayPal.Name = "checkBoxPayPal";
            this.checkBoxPayPal.Size = new System.Drawing.Size(94, 17);
            this.checkBoxPayPal.TabIndex = 1;
            this.checkBoxPayPal.Text = "Через PayPal";
            this.checkBoxPayPal.UseVisualStyleBackColor = true;
            // 
            // checkBoxBank
            // 
            this.checkBoxBank.AutoSize = true;
            this.checkBoxBank.Location = new System.Drawing.Point(36, 38);
            this.checkBoxBank.Name = "checkBoxBank";
            this.checkBoxBank.Size = new System.Drawing.Size(85, 17);
            this.checkBoxBank.TabIndex = 0;
            this.checkBoxBank.Text = "Через банк";
            this.checkBoxBank.UseVisualStyleBackColor = true;
            // 
            // FormChainOfResponsibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlChainOfResponsibility);
            this.Name = "FormChainOfResponsibility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chain Of Responsibility";
            this.Load += new System.EventHandler(this.FormChainOfResponsibility_Load);
            this.tabControlChainOfResponsibility.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBoxMoney.ResumeLayout(false);
            this.groupBoxMoney.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlChainOfResponsibility;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxMoney;
        private System.Windows.Forms.CheckBox checkBoxBank;
        private System.Windows.Forms.CheckBox checkBoxPayPal;
        private System.Windows.Forms.CheckBox checkBoxMoney;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}