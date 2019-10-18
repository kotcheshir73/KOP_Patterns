namespace WindowsFormsApplicationPatterns
{
    partial class FormBridge
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.tabControlAdapter = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelLang = new System.Windows.Forms.Label();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.labelProger = new System.Windows.Forms.Label();
            this.comboBoxProger = new System.Windows.Forms.ComboBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.listBoxProgers = new System.Windows.Forms.ListBox();
            this.buttonDoWork = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.tabControlAdapter.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdapter
            // 
            this.tabControlAdapter.Controls.Add(this.tabPage1);
            this.tabControlAdapter.Controls.Add(this.tabPage2);
            this.tabControlAdapter.Controls.Add(this.tabPage3);
            this.tabControlAdapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdapter.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdapter.Name = "tabControlAdapter";
            this.tabControlAdapter.SelectedIndex = 0;
            this.tabControlAdapter.Size = new System.Drawing.Size(984, 461);
            this.tabControlAdapter.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.richTextBoxResult);
            this.tabPage3.Controls.Add(this.buttonDoWork);
            this.tabPage3.Controls.Add(this.listBoxProgers);
            this.tabPage3.Controls.Add(this.buttonCreate);
            this.tabPage3.Controls.Add(this.comboBoxProger);
            this.tabPage3.Controls.Add(this.labelProger);
            this.tabPage3.Controls.Add(this.comboBoxLang);
            this.tabPage3.Controls.Add(this.labelLang);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.Location = new System.Drawing.Point(82, 31);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(38, 13);
            this.labelLang.TabIndex = 0;
            this.labelLang.Text = "Язык:";
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Location = new System.Drawing.Point(24, 53);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.Size = new System.Drawing.Size(158, 21);
            this.comboBoxLang.TabIndex = 1;
            // 
            // labelProger
            // 
            this.labelProger.AutoSize = true;
            this.labelProger.Location = new System.Drawing.Point(67, 124);
            this.labelProger.Name = "labelProger";
            this.labelProger.Size = new System.Drawing.Size(80, 13);
            this.labelProger.TabIndex = 2;
            this.labelProger.Text = "Программист:";
            // 
            // comboBoxProger
            // 
            this.comboBoxProger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProger.FormattingEnabled = true;
            this.comboBoxProger.Location = new System.Drawing.Point(24, 159);
            this.comboBoxProger.Name = "comboBoxProger";
            this.comboBoxProger.Size = new System.Drawing.Size(158, 21);
            this.comboBoxProger.TabIndex = 3;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(24, 231);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(158, 34);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // listBoxProgers
            // 
            this.listBoxProgers.FormattingEnabled = true;
            this.listBoxProgers.Location = new System.Drawing.Point(259, 20);
            this.listBoxProgers.Name = "listBoxProgers";
            this.listBoxProgers.Size = new System.Drawing.Size(274, 407);
            this.listBoxProgers.TabIndex = 5;
            // 
            // buttonDoWork
            // 
            this.buttonDoWork.Location = new System.Drawing.Point(569, 131);
            this.buttonDoWork.Name = "buttonDoWork";
            this.buttonDoWork.Size = new System.Drawing.Size(95, 74);
            this.buttonDoWork.TabIndex = 6;
            this.buttonDoWork.Text = "Делать работу";
            this.buttonDoWork.UseVisualStyleBackColor = true;
            this.buttonDoWork.Click += new System.EventHandler(this.buttonDoWork_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(695, 20);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(273, 407);
            this.richTextBoxResult.TabIndex = 7;
            this.richTextBoxResult.Text = "";
            // 
            // FormBridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlAdapter);
            this.Name = "FormBridge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bridge";
            this.Load += new System.EventHandler(this.FormBridge_Load);
            this.tabControlAdapter.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.Label labelProger;
        private System.Windows.Forms.ComboBox comboBoxProger;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ListBox listBoxProgers;
        private System.Windows.Forms.Button buttonDoWork;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
    }
}

