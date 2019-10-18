namespace WindowsFormsApplicationPatterns
{
    partial class FormBuilder
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
            this.tabControlBuilder = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelTypeBeard = new System.Windows.Forms.Label();
            this.comboBoxTypeBeard = new System.Windows.Forms.ComboBox();
            this.buttonMake = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.tabControlBuilder.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlBuilder
            // 
            this.tabControlBuilder.Controls.Add(this.tabPage1);
            this.tabControlBuilder.Controls.Add(this.tabPage2);
            this.tabControlBuilder.Controls.Add(this.tabPage3);
            this.tabControlBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBuilder.Location = new System.Drawing.Point(0, 0);
            this.tabControlBuilder.Name = "tabControlBuilder";
            this.tabControlBuilder.SelectedIndex = 0;
            this.tabControlBuilder.Size = new System.Drawing.Size(984, 461);
            this.tabControlBuilder.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.buttonMake);
            this.tabPage3.Controls.Add(this.comboBoxTypeBeard);
            this.tabPage3.Controls.Add(this.labelTypeBeard);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelTypeBeard
            // 
            this.labelTypeBeard.AutoSize = true;
            this.labelTypeBeard.Location = new System.Drawing.Point(152, 44);
            this.labelTypeBeard.Name = "labelTypeBeard";
            this.labelTypeBeard.Size = new System.Drawing.Size(61, 13);
            this.labelTypeBeard.TabIndex = 0;
            this.labelTypeBeard.Text = "Тип хлеба:";
            // 
            // comboBoxTypeBeard
            // 
            this.comboBoxTypeBeard.FormattingEnabled = true;
            this.comboBoxTypeBeard.Location = new System.Drawing.Point(108, 65);
            this.comboBoxTypeBeard.Name = "comboBoxTypeBeard";
            this.comboBoxTypeBeard.Size = new System.Drawing.Size(149, 21);
            this.comboBoxTypeBeard.TabIndex = 1;
            // 
            // buttonMake
            // 
            this.buttonMake.Location = new System.Drawing.Point(143, 109);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(75, 23);
            this.buttonMake.TabIndex = 2;
            this.buttonMake.Text = "Испечь";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(298, 18);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(366, 371);
            this.richTextBoxResult.TabIndex = 3;
            this.richTextBoxResult.Text = "";
            // 
            // FormBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlBuilder);
            this.Name = "FormBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Builder";
            this.Load += new System.EventHandler(this.FormBuilder_Load);
            this.tabControlBuilder.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBuilder;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelTypeBeard;
        private System.Windows.Forms.ComboBox comboBoxTypeBeard;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button buttonMake;
    }
}