namespace WindowsFormsApplicationPatterns
{
    partial class FormSingleton
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
            this.tabControlSingleton = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelOSName = new System.Windows.Forms.Label();
            this.textBoxOSName = new System.Windows.Forms.TextBox();
            this.buttonCreateComp = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.tabControlSingleton.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSingleton
            // 
            this.tabControlSingleton.Controls.Add(this.tabPage1);
            this.tabControlSingleton.Controls.Add(this.tabPage2);
            this.tabControlSingleton.Controls.Add(this.tabPage3);
            this.tabControlSingleton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSingleton.Location = new System.Drawing.Point(0, 0);
            this.tabControlSingleton.Name = "tabControlSingleton";
            this.tabControlSingleton.SelectedIndex = 0;
            this.tabControlSingleton.Size = new System.Drawing.Size(984, 461);
            this.tabControlSingleton.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.buttonCreateComp);
            this.tabPage3.Controls.Add(this.textBoxOSName);
            this.tabPage3.Controls.Add(this.labelOSName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelOSName
            // 
            this.labelOSName.AutoSize = true;
            this.labelOSName.Location = new System.Drawing.Point(341, 40);
            this.labelOSName.Name = "labelOSName";
            this.labelOSName.Size = new System.Drawing.Size(167, 13);
            this.labelOSName.TabIndex = 0;
            this.labelOSName.Text = "Задать операционную систему:";
            // 
            // textBoxOSName
            // 
            this.textBoxOSName.Location = new System.Drawing.Point(327, 68);
            this.textBoxOSName.Name = "textBoxOSName";
            this.textBoxOSName.Size = new System.Drawing.Size(207, 20);
            this.textBoxOSName.TabIndex = 1;
            // 
            // buttonCreateComp
            // 
            this.buttonCreateComp.Location = new System.Drawing.Point(331, 123);
            this.buttonCreateComp.Name = "buttonCreateComp";
            this.buttonCreateComp.Size = new System.Drawing.Size(201, 77);
            this.buttonCreateComp.TabIndex = 3;
            this.buttonCreateComp.Text = "Создать компьютер с ОС";
            this.buttonCreateComp.UseVisualStyleBackColor = true;
            this.buttonCreateComp.Click += new System.EventHandler(this.buttonCreateComp_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(553, 18);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(336, 394);
            this.listBoxResult.TabIndex = 4;
            // 
            // FormSingleton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlSingleton);
            this.Name = "FormSingleton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Singleton";
            this.Load += new System.EventHandler(this.FormSingleton_Load);
            this.tabControlSingleton.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSingleton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelOSName;
        private System.Windows.Forms.TextBox textBoxOSName;
        private System.Windows.Forms.Button buttonCreateComp;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}