namespace WindowsFormsApplicationPatterns
{
    partial class FormMediator
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
            this.tabControlMediator = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.labelCustomerMessage = new System.Windows.Forms.Label();
            this.textBoxCustomerMessage = new System.Windows.Forms.TextBox();
            this.buttonSendCustomerMessage = new System.Windows.Forms.Button();
            this.groupBoxProgrammer = new System.Windows.Forms.GroupBox();
            this.buttonSendProgrammerMessage = new System.Windows.Forms.Button();
            this.textBoxProgrammerMessage = new System.Windows.Forms.TextBox();
            this.labelProgrammerMessage = new System.Windows.Forms.Label();
            this.groupBoxTester = new System.Windows.Forms.GroupBox();
            this.buttonSendTesterMessage = new System.Windows.Forms.Button();
            this.textBoxTesterMessage = new System.Windows.Forms.TextBox();
            this.labelTesterMessage = new System.Windows.Forms.Label();
            this.groupBoxManager = new System.Windows.Forms.GroupBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.tabControlMediator.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxCustomer.SuspendLayout();
            this.groupBoxProgrammer.SuspendLayout();
            this.groupBoxTester.SuspendLayout();
            this.groupBoxManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMediator
            // 
            this.tabControlMediator.Controls.Add(this.tabPage1);
            this.tabControlMediator.Controls.Add(this.tabPage2);
            this.tabControlMediator.Controls.Add(this.tabPage3);
            this.tabControlMediator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMediator.Location = new System.Drawing.Point(0, 0);
            this.tabControlMediator.Name = "tabControlMediator";
            this.tabControlMediator.SelectedIndex = 0;
            this.tabControlMediator.Size = new System.Drawing.Size(984, 461);
            this.tabControlMediator.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.groupBoxManager);
            this.tabPage3.Controls.Add(this.groupBoxTester);
            this.tabPage3.Controls.Add(this.groupBoxProgrammer);
            this.tabPage3.Controls.Add(this.groupBoxCustomer);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.buttonSendCustomerMessage);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerMessage);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerMessage);
            this.groupBoxCustomer.Location = new System.Drawing.Point(20, 6);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(270, 134);
            this.groupBoxCustomer.TabIndex = 0;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Заказчик:";
            // 
            // labelCustomerMessage
            // 
            this.labelCustomerMessage.AutoSize = true;
            this.labelCustomerMessage.Location = new System.Drawing.Point(25, 28);
            this.labelCustomerMessage.Name = "labelCustomerMessage";
            this.labelCustomerMessage.Size = new System.Drawing.Size(138, 13);
            this.labelCustomerMessage.TabIndex = 0;
            this.labelCustomerMessage.Text = "Сообщение от заказчика:";
            // 
            // textBoxCustomerMessage
            // 
            this.textBoxCustomerMessage.Location = new System.Drawing.Point(28, 57);
            this.textBoxCustomerMessage.Name = "textBoxCustomerMessage";
            this.textBoxCustomerMessage.Size = new System.Drawing.Size(214, 20);
            this.textBoxCustomerMessage.TabIndex = 1;
            // 
            // buttonSendCustomerMessage
            // 
            this.buttonSendCustomerMessage.Location = new System.Drawing.Point(88, 95);
            this.buttonSendCustomerMessage.Name = "buttonSendCustomerMessage";
            this.buttonSendCustomerMessage.Size = new System.Drawing.Size(75, 23);
            this.buttonSendCustomerMessage.TabIndex = 2;
            this.buttonSendCustomerMessage.Text = "Послать";
            this.buttonSendCustomerMessage.UseVisualStyleBackColor = true;
            this.buttonSendCustomerMessage.Click += new System.EventHandler(this.buttonSendCustomerMessage_Click);
            // 
            // groupBoxProgrammer
            // 
            this.groupBoxProgrammer.Controls.Add(this.buttonSendProgrammerMessage);
            this.groupBoxProgrammer.Controls.Add(this.textBoxProgrammerMessage);
            this.groupBoxProgrammer.Controls.Add(this.labelProgrammerMessage);
            this.groupBoxProgrammer.Location = new System.Drawing.Point(20, 146);
            this.groupBoxProgrammer.Name = "groupBoxProgrammer";
            this.groupBoxProgrammer.Size = new System.Drawing.Size(270, 134);
            this.groupBoxProgrammer.TabIndex = 1;
            this.groupBoxProgrammer.TabStop = false;
            this.groupBoxProgrammer.Text = "Программист:";
            // 
            // buttonSendProgrammerMessage
            // 
            this.buttonSendProgrammerMessage.Location = new System.Drawing.Point(88, 95);
            this.buttonSendProgrammerMessage.Name = "buttonSendProgrammerMessage";
            this.buttonSendProgrammerMessage.Size = new System.Drawing.Size(75, 23);
            this.buttonSendProgrammerMessage.TabIndex = 2;
            this.buttonSendProgrammerMessage.Text = "Послать";
            this.buttonSendProgrammerMessage.UseVisualStyleBackColor = true;
            this.buttonSendProgrammerMessage.Click += new System.EventHandler(this.buttonSendProgrammerMessage_Click);
            // 
            // textBoxProgrammerMessage
            // 
            this.textBoxProgrammerMessage.Location = new System.Drawing.Point(28, 57);
            this.textBoxProgrammerMessage.Name = "textBoxProgrammerMessage";
            this.textBoxProgrammerMessage.Size = new System.Drawing.Size(214, 20);
            this.textBoxProgrammerMessage.TabIndex = 1;
            // 
            // labelProgrammerMessage
            // 
            this.labelProgrammerMessage.AutoSize = true;
            this.labelProgrammerMessage.Location = new System.Drawing.Point(25, 28);
            this.labelProgrammerMessage.Name = "labelProgrammerMessage";
            this.labelProgrammerMessage.Size = new System.Drawing.Size(159, 13);
            this.labelProgrammerMessage.TabIndex = 0;
            this.labelProgrammerMessage.Text = "Сообщение от программиста:";
            // 
            // groupBoxTester
            // 
            this.groupBoxTester.Controls.Add(this.buttonSendTesterMessage);
            this.groupBoxTester.Controls.Add(this.textBoxTesterMessage);
            this.groupBoxTester.Controls.Add(this.labelTesterMessage);
            this.groupBoxTester.Location = new System.Drawing.Point(20, 286);
            this.groupBoxTester.Name = "groupBoxTester";
            this.groupBoxTester.Size = new System.Drawing.Size(270, 134);
            this.groupBoxTester.TabIndex = 2;
            this.groupBoxTester.TabStop = false;
            this.groupBoxTester.Text = "Тестировщик:";
            // 
            // buttonSendTesterMessage
            // 
            this.buttonSendTesterMessage.Location = new System.Drawing.Point(88, 95);
            this.buttonSendTesterMessage.Name = "buttonSendTesterMessage";
            this.buttonSendTesterMessage.Size = new System.Drawing.Size(75, 23);
            this.buttonSendTesterMessage.TabIndex = 2;
            this.buttonSendTesterMessage.Text = "Послать";
            this.buttonSendTesterMessage.UseVisualStyleBackColor = true;
            this.buttonSendTesterMessage.Click += new System.EventHandler(this.buttonSendTesterMessage_Click);
            // 
            // textBoxTesterMessage
            // 
            this.textBoxTesterMessage.Location = new System.Drawing.Point(28, 57);
            this.textBoxTesterMessage.Name = "textBoxTesterMessage";
            this.textBoxTesterMessage.Size = new System.Drawing.Size(214, 20);
            this.textBoxTesterMessage.TabIndex = 1;
            // 
            // labelTesterMessage
            // 
            this.labelTesterMessage.AutoSize = true;
            this.labelTesterMessage.Location = new System.Drawing.Point(25, 28);
            this.labelTesterMessage.Name = "labelTesterMessage";
            this.labelTesterMessage.Size = new System.Drawing.Size(158, 13);
            this.labelTesterMessage.TabIndex = 0;
            this.labelTesterMessage.Text = "Сообщение от тестировщика:";
            // 
            // groupBoxManager
            // 
            this.groupBoxManager.Controls.Add(this.listBoxResult);
            this.groupBoxManager.Location = new System.Drawing.Point(310, 6);
            this.groupBoxManager.Name = "groupBoxManager";
            this.groupBoxManager.Size = new System.Drawing.Size(518, 421);
            this.groupBoxManager.TabIndex = 3;
            this.groupBoxManager.TabStop = false;
            this.groupBoxManager.Text = "Менеджер:";
            // 
            // listBoxResult
            // 
            this.listBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(3, 16);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(512, 402);
            this.listBoxResult.TabIndex = 0;
            // 
            // FormMediator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlMediator);
            this.Name = "FormMediator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mediator";
            this.Load += new System.EventHandler(this.FormMediator_Load);
            this.tabControlMediator.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.groupBoxProgrammer.ResumeLayout(false);
            this.groupBoxProgrammer.PerformLayout();
            this.groupBoxTester.ResumeLayout(false);
            this.groupBoxTester.PerformLayout();
            this.groupBoxManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMediator;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.Button buttonSendCustomerMessage;
        private System.Windows.Forms.TextBox textBoxCustomerMessage;
        private System.Windows.Forms.Label labelCustomerMessage;
        private System.Windows.Forms.GroupBox groupBoxProgrammer;
        private System.Windows.Forms.Button buttonSendProgrammerMessage;
        private System.Windows.Forms.TextBox textBoxProgrammerMessage;
        private System.Windows.Forms.Label labelProgrammerMessage;
        private System.Windows.Forms.GroupBox groupBoxTester;
        private System.Windows.Forms.Button buttonSendTesterMessage;
        private System.Windows.Forms.TextBox textBoxTesterMessage;
        private System.Windows.Forms.Label labelTesterMessage;
        private System.Windows.Forms.GroupBox groupBoxManager;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}