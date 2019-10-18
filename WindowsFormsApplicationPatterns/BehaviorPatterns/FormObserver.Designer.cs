namespace WindowsFormsApplicationPatterns
{
    partial class FormObserver
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
            this.tabControlObserver = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxBrokers = new System.Windows.Forms.GroupBox();
            this.textBoxNewBroker = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxBrokers = new System.Windows.Forms.ListBox();
            this.buttonStopTrade = new System.Windows.Forms.Button();
            this.groupBoxBanks = new System.Windows.Forms.GroupBox();
            this.listBoxBanks = new System.Windows.Forms.ListBox();
            this.buttonAddBank = new System.Windows.Forms.Button();
            this.textBoxNewBank = new System.Windows.Forms.TextBox();
            this.groupBoxStocks = new System.Windows.Forms.GroupBox();
            this.buttonStock = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.tabControlObserver.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxBrokers.SuspendLayout();
            this.groupBoxBanks.SuspendLayout();
            this.groupBoxStocks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlObserver
            // 
            this.tabControlObserver.Controls.Add(this.tabPage1);
            this.tabControlObserver.Controls.Add(this.tabPage2);
            this.tabControlObserver.Controls.Add(this.tabPage3);
            this.tabControlObserver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlObserver.Location = new System.Drawing.Point(0, 0);
            this.tabControlObserver.Name = "tabControlObserver";
            this.tabControlObserver.SelectedIndex = 0;
            this.tabControlObserver.Size = new System.Drawing.Size(984, 461);
            this.tabControlObserver.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.groupBoxStocks);
            this.tabPage3.Controls.Add(this.groupBoxBanks);
            this.tabPage3.Controls.Add(this.groupBoxBrokers);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxBrokers
            // 
            this.groupBoxBrokers.Controls.Add(this.buttonStopTrade);
            this.groupBoxBrokers.Controls.Add(this.listBoxBrokers);
            this.groupBoxBrokers.Controls.Add(this.buttonAdd);
            this.groupBoxBrokers.Controls.Add(this.textBoxNewBroker);
            this.groupBoxBrokers.Location = new System.Drawing.Point(8, 6);
            this.groupBoxBrokers.Name = "groupBoxBrokers";
            this.groupBoxBrokers.Size = new System.Drawing.Size(280, 421);
            this.groupBoxBrokers.TabIndex = 0;
            this.groupBoxBrokers.TabStop = false;
            this.groupBoxBrokers.Text = "Брокеры";
            // 
            // textBoxNewBroker
            // 
            this.textBoxNewBroker.Location = new System.Drawing.Point(6, 19);
            this.textBoxNewBroker.Name = "textBoxNewBroker";
            this.textBoxNewBroker.Size = new System.Drawing.Size(264, 20);
            this.textBoxNewBroker.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(70, 45);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(128, 24);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxBrokers
            // 
            this.listBoxBrokers.FormattingEnabled = true;
            this.listBoxBrokers.Location = new System.Drawing.Point(6, 96);
            this.listBoxBrokers.Name = "listBoxBrokers";
            this.listBoxBrokers.Size = new System.Drawing.Size(264, 212);
            this.listBoxBrokers.TabIndex = 2;
            // 
            // buttonStopTrade
            // 
            this.buttonStopTrade.Location = new System.Drawing.Point(35, 326);
            this.buttonStopTrade.Name = "buttonStopTrade";
            this.buttonStopTrade.Size = new System.Drawing.Size(163, 27);
            this.buttonStopTrade.TabIndex = 3;
            this.buttonStopTrade.Text = "Отписать от торгов";
            this.buttonStopTrade.UseVisualStyleBackColor = true;
            this.buttonStopTrade.Click += new System.EventHandler(this.buttonStopTrade_Click);
            // 
            // groupBoxBanks
            // 
            this.groupBoxBanks.Controls.Add(this.listBoxBanks);
            this.groupBoxBanks.Controls.Add(this.buttonAddBank);
            this.groupBoxBanks.Controls.Add(this.textBoxNewBank);
            this.groupBoxBanks.Location = new System.Drawing.Point(294, 6);
            this.groupBoxBanks.Name = "groupBoxBanks";
            this.groupBoxBanks.Size = new System.Drawing.Size(279, 421);
            this.groupBoxBanks.TabIndex = 1;
            this.groupBoxBanks.TabStop = false;
            this.groupBoxBanks.Text = "Банки";
            // 
            // listBoxBanks
            // 
            this.listBoxBanks.FormattingEnabled = true;
            this.listBoxBanks.Location = new System.Drawing.Point(6, 96);
            this.listBoxBanks.Name = "listBoxBanks";
            this.listBoxBanks.Size = new System.Drawing.Size(264, 212);
            this.listBoxBanks.TabIndex = 2;
            // 
            // buttonAddBank
            // 
            this.buttonAddBank.Location = new System.Drawing.Point(70, 45);
            this.buttonAddBank.Name = "buttonAddBank";
            this.buttonAddBank.Size = new System.Drawing.Size(128, 24);
            this.buttonAddBank.TabIndex = 1;
            this.buttonAddBank.Text = "Добавить";
            this.buttonAddBank.UseVisualStyleBackColor = true;
            this.buttonAddBank.Click += new System.EventHandler(this.buttonAddBank_Click);
            // 
            // textBoxNewBank
            // 
            this.textBoxNewBank.Location = new System.Drawing.Point(6, 19);
            this.textBoxNewBank.Name = "textBoxNewBank";
            this.textBoxNewBank.Size = new System.Drawing.Size(264, 20);
            this.textBoxNewBank.TabIndex = 0;
            // 
            // groupBoxStocks
            // 
            this.groupBoxStocks.Controls.Add(this.richTextBoxResult);
            this.groupBoxStocks.Controls.Add(this.buttonStock);
            this.groupBoxStocks.Location = new System.Drawing.Point(579, 6);
            this.groupBoxStocks.Name = "groupBoxStocks";
            this.groupBoxStocks.Size = new System.Drawing.Size(391, 421);
            this.groupBoxStocks.TabIndex = 2;
            this.groupBoxStocks.TabStop = false;
            this.groupBoxStocks.Text = "Торги";
            // 
            // buttonStock
            // 
            this.buttonStock.Location = new System.Drawing.Point(17, 16);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(243, 23);
            this.buttonStock.TabIndex = 0;
            this.buttonStock.Text = "Провести торги";
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(6, 45);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(379, 370);
            this.richTextBoxResult.TabIndex = 1;
            this.richTextBoxResult.Text = "";
            // 
            // FormObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlObserver);
            this.Name = "FormObserver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observer";
            this.Load += new System.EventHandler(this.FormObserver_Load);
            this.tabControlObserver.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBoxBrokers.ResumeLayout(false);
            this.groupBoxBrokers.PerformLayout();
            this.groupBoxBanks.ResumeLayout(false);
            this.groupBoxBanks.PerformLayout();
            this.groupBoxStocks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlObserver;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxBrokers;
        private System.Windows.Forms.ListBox listBoxBrokers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNewBroker;
        private System.Windows.Forms.Button buttonStopTrade;
        private System.Windows.Forms.GroupBox groupBoxBanks;
        private System.Windows.Forms.ListBox listBoxBanks;
        private System.Windows.Forms.Button buttonAddBank;
        private System.Windows.Forms.TextBox textBoxNewBank;
        private System.Windows.Forms.GroupBox groupBoxStocks;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
    }
}