namespace WindowsFormsApplicationPatterns
{
    partial class FormState
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
            this.tabControlState = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonHeat = new System.Windows.Forms.Button();
            this.buttonFrost = new System.Windows.Forms.Button();
            this.labelWaterState = new System.Windows.Forms.Label();
            this.listBoxWaterState = new System.Windows.Forms.ListBox();
            this.tabControlState.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlState
            // 
            this.tabControlState.Controls.Add(this.tabPage1);
            this.tabControlState.Controls.Add(this.tabPage2);
            this.tabControlState.Controls.Add(this.tabPage3);
            this.tabControlState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlState.Location = new System.Drawing.Point(0, 0);
            this.tabControlState.Name = "tabControlState";
            this.tabControlState.SelectedIndex = 0;
            this.tabControlState.Size = new System.Drawing.Size(984, 461);
            this.tabControlState.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.listBoxWaterState);
            this.tabPage3.Controls.Add(this.labelWaterState);
            this.tabPage3.Controls.Add(this.buttonFrost);
            this.tabPage3.Controls.Add(this.buttonHeat);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonHeat
            // 
            this.buttonHeat.Location = new System.Drawing.Point(41, 41);
            this.buttonHeat.Name = "buttonHeat";
            this.buttonHeat.Size = new System.Drawing.Size(165, 44);
            this.buttonHeat.TabIndex = 0;
            this.buttonHeat.Text = "Нагреть воду";
            this.buttonHeat.UseVisualStyleBackColor = true;
            this.buttonHeat.Click += new System.EventHandler(this.buttonHeat_Click);
            // 
            // buttonFrost
            // 
            this.buttonFrost.Location = new System.Drawing.Point(41, 149);
            this.buttonFrost.Name = "buttonFrost";
            this.buttonFrost.Size = new System.Drawing.Size(165, 44);
            this.buttonFrost.TabIndex = 1;
            this.buttonFrost.Text = "Остудить воду";
            this.buttonFrost.UseVisualStyleBackColor = true;
            this.buttonFrost.Click += new System.EventHandler(this.buttonFrost_Click);
            // 
            // labelWaterState
            // 
            this.labelWaterState.AutoSize = true;
            this.labelWaterState.Location = new System.Drawing.Point(322, 17);
            this.labelWaterState.Name = "labelWaterState";
            this.labelWaterState.Size = new System.Drawing.Size(93, 13);
            this.labelWaterState.TabIndex = 2;
            this.labelWaterState.Text = "Состояние воды:";
            // 
            // listBoxWaterState
            // 
            this.listBoxWaterState.FormattingEnabled = true;
            this.listBoxWaterState.Location = new System.Drawing.Point(325, 41);
            this.listBoxWaterState.Name = "listBoxWaterState";
            this.listBoxWaterState.Size = new System.Drawing.Size(252, 355);
            this.listBoxWaterState.TabIndex = 3;
            // 
            // FormState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlState);
            this.Name = "FormState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State";
            this.Load += new System.EventHandler(this.FormState_Load);
            this.tabControlState.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlState;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonHeat;
        private System.Windows.Forms.Button buttonFrost;
        private System.Windows.Forms.Label labelWaterState;
        private System.Windows.Forms.ListBox listBoxWaterState;
    }
}