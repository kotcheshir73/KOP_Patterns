namespace WindowsFormsApplicationPatterns
{
    partial class FormTemplateMethod
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
            this.tabControlTemplateMethod = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelLearnTypes = new System.Windows.Forms.Label();
            this.comboBoxLearnTypes = new System.Windows.Forms.ComboBox();
            this.buttonSeeLearn = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.tabControlTemplateMethod.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTemplateMethod
            // 
            this.tabControlTemplateMethod.Controls.Add(this.tabPage1);
            this.tabControlTemplateMethod.Controls.Add(this.tabPage2);
            this.tabControlTemplateMethod.Controls.Add(this.tabPage3);
            this.tabControlTemplateMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTemplateMethod.Location = new System.Drawing.Point(0, 0);
            this.tabControlTemplateMethod.Name = "tabControlTemplateMethod";
            this.tabControlTemplateMethod.SelectedIndex = 0;
            this.tabControlTemplateMethod.Size = new System.Drawing.Size(984, 461);
            this.tabControlTemplateMethod.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.buttonSeeLearn);
            this.tabPage3.Controls.Add(this.comboBoxLearnTypes);
            this.tabPage3.Controls.Add(this.labelLearnTypes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelLearnTypes
            // 
            this.labelLearnTypes.AutoSize = true;
            this.labelLearnTypes.Location = new System.Drawing.Point(67, 38);
            this.labelLearnTypes.Name = "labelLearnTypes";
            this.labelLearnTypes.Size = new System.Drawing.Size(109, 13);
            this.labelLearnTypes.TabIndex = 0;
            this.labelLearnTypes.Text = "Варинаты обучения:";
            // 
            // comboBoxLearnTypes
            // 
            this.comboBoxLearnTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLearnTypes.FormattingEnabled = true;
            this.comboBoxLearnTypes.Location = new System.Drawing.Point(28, 75);
            this.comboBoxLearnTypes.Name = "comboBoxLearnTypes";
            this.comboBoxLearnTypes.Size = new System.Drawing.Size(186, 21);
            this.comboBoxLearnTypes.TabIndex = 1;
            // 
            // buttonSeeLearn
            // 
            this.buttonSeeLearn.Location = new System.Drawing.Point(51, 127);
            this.buttonSeeLearn.Name = "buttonSeeLearn";
            this.buttonSeeLearn.Size = new System.Drawing.Size(147, 51);
            this.buttonSeeLearn.TabIndex = 2;
            this.buttonSeeLearn.Text = "Посмотреть процесс обучения";
            this.buttonSeeLearn.UseVisualStyleBackColor = true;
            this.buttonSeeLearn.Click += new System.EventHandler(this.buttonSeeLearn_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(320, 35);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(356, 170);
            this.richTextBoxResult.TabIndex = 3;
            this.richTextBoxResult.Text = "";
            // 
            // FormTemplateMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlTemplateMethod);
            this.Name = "FormTemplateMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Template Method";
            this.Load += new System.EventHandler(this.FormTemplateMethod_Load);
            this.tabControlTemplateMethod.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTemplateMethod;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelLearnTypes;
        private System.Windows.Forms.ComboBox comboBoxLearnTypes;
        private System.Windows.Forms.Button buttonSeeLearn;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
    }
}