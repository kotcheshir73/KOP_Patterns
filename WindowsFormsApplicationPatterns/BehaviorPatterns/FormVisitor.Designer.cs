namespace WindowsFormsApplicationPatterns
{
    partial class FormVisitor
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
            this.tabControlVisitor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxAddClient = new System.Windows.Forms.GroupBox();
            this.labelTypeClient = new System.Windows.Forms.Label();
            this.comboBoxClientType = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelRegNumber = new System.Windows.Forms.Label();
            this.textBoxRegNumber = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.labelTypeLoad = new System.Windows.Forms.Label();
            this.comboBoxTypeLoad = new System.Windows.Forms.ComboBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.tabControlVisitor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxAddClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlVisitor
            // 
            this.tabControlVisitor.Controls.Add(this.tabPage1);
            this.tabControlVisitor.Controls.Add(this.tabPage2);
            this.tabControlVisitor.Controls.Add(this.tabPage3);
            this.tabControlVisitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlVisitor.Location = new System.Drawing.Point(0, 0);
            this.tabControlVisitor.Name = "tabControlVisitor";
            this.tabControlVisitor.SelectedIndex = 0;
            this.tabControlVisitor.Size = new System.Drawing.Size(984, 461);
            this.tabControlVisitor.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.buttonUpload);
            this.tabPage3.Controls.Add(this.richTextBoxResult);
            this.tabPage3.Controls.Add(this.comboBoxTypeLoad);
            this.tabPage3.Controls.Add(this.labelTypeLoad);
            this.tabPage3.Controls.Add(this.groupBoxAddClient);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddClient
            // 
            this.groupBoxAddClient.Controls.Add(this.buttonAddClient);
            this.groupBoxAddClient.Controls.Add(this.textBoxNumber);
            this.groupBoxAddClient.Controls.Add(this.labelNumber);
            this.groupBoxAddClient.Controls.Add(this.textBoxRegNumber);
            this.groupBoxAddClient.Controls.Add(this.labelRegNumber);
            this.groupBoxAddClient.Controls.Add(this.textBoxName);
            this.groupBoxAddClient.Controls.Add(this.labelName);
            this.groupBoxAddClient.Controls.Add(this.comboBoxClientType);
            this.groupBoxAddClient.Controls.Add(this.labelTypeClient);
            this.groupBoxAddClient.Location = new System.Drawing.Point(8, 6);
            this.groupBoxAddClient.Name = "groupBoxAddClient";
            this.groupBoxAddClient.Size = new System.Drawing.Size(316, 249);
            this.groupBoxAddClient.TabIndex = 0;
            this.groupBoxAddClient.TabStop = false;
            this.groupBoxAddClient.Text = "Добавление клиента";
            // 
            // labelTypeClient
            // 
            this.labelTypeClient.AutoSize = true;
            this.labelTypeClient.Location = new System.Drawing.Point(15, 32);
            this.labelTypeClient.Name = "labelTypeClient";
            this.labelTypeClient.Size = new System.Drawing.Size(29, 13);
            this.labelTypeClient.TabIndex = 0;
            this.labelTypeClient.Text = "Тип:";
            // 
            // comboBoxClientType
            // 
            this.comboBoxClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientType.FormattingEnabled = true;
            this.comboBoxClientType.Location = new System.Drawing.Point(84, 29);
            this.comboBoxClientType.Name = "comboBoxClientType";
            this.comboBoxClientType.Size = new System.Drawing.Size(210, 21);
            this.comboBoxClientType.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 78);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(207, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelRegNumber
            // 
            this.labelRegNumber.AutoSize = true;
            this.labelRegNumber.Location = new System.Drawing.Point(15, 126);
            this.labelRegNumber.Name = "labelRegNumber";
            this.labelRegNumber.Size = new System.Drawing.Size(66, 13);
            this.labelRegNumber.TabIndex = 4;
            this.labelRegNumber.Text = "Рег. номер:";
            // 
            // textBoxRegNumber
            // 
            this.textBoxRegNumber.Location = new System.Drawing.Point(87, 123);
            this.textBoxRegNumber.Name = "textBoxRegNumber";
            this.textBoxRegNumber.Size = new System.Drawing.Size(207, 20);
            this.textBoxRegNumber.TabIndex = 5;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(87, 162);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(207, 20);
            this.textBoxNumber.TabIndex = 7;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(15, 165);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 6;
            this.labelNumber.Text = "Номер:";
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(111, 202);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(111, 32);
            this.buttonAddClient.TabIndex = 8;
            this.buttonAddClient.Text = "Добавить";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // labelTypeLoad
            // 
            this.labelTypeLoad.AutoSize = true;
            this.labelTypeLoad.Location = new System.Drawing.Point(355, 35);
            this.labelTypeLoad.Name = "labelTypeLoad";
            this.labelTypeLoad.Size = new System.Drawing.Size(107, 13);
            this.labelTypeLoad.TabIndex = 1;
            this.labelTypeLoad.Text = "Получить выгрузку:";
            // 
            // comboBoxTypeLoad
            // 
            this.comboBoxTypeLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeLoad.FormattingEnabled = true;
            this.comboBoxTypeLoad.Location = new System.Drawing.Point(477, 32);
            this.comboBoxTypeLoad.Name = "comboBoxTypeLoad";
            this.comboBoxTypeLoad.Size = new System.Drawing.Size(275, 21);
            this.comboBoxTypeLoad.TabIndex = 2;
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(349, 65);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(619, 364);
            this.richTextBoxResult.TabIndex = 3;
            this.richTextBoxResult.Text = "";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(799, 30);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(143, 23);
            this.buttonUpload.TabIndex = 4;
            this.buttonUpload.Text = "Выгрузить";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // FormVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlVisitor);
            this.Name = "FormVisitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitor";
            this.Load += new System.EventHandler(this.FormVisitor_Load);
            this.tabControlVisitor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxAddClient.ResumeLayout(false);
            this.groupBoxAddClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlVisitor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxAddClient;
        private System.Windows.Forms.ComboBox comboBoxClientType;
        private System.Windows.Forms.Label labelTypeClient;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelRegNumber;
        private System.Windows.Forms.TextBox textBoxRegNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.ComboBox comboBoxTypeLoad;
        private System.Windows.Forms.Label labelTypeLoad;
        private System.Windows.Forms.Button buttonUpload;
    }
}