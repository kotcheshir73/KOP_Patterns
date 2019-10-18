namespace WindowsFormsApplicationPatterns
{
    partial class FormMemento
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
            this.tabControlMemento = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonHeroStep = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.listBoxSteps = new System.Windows.Forms.ListBox();
            this.tabControlMemento.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMemento
            // 
            this.tabControlMemento.Controls.Add(this.tabPage1);
            this.tabControlMemento.Controls.Add(this.tabPage2);
            this.tabControlMemento.Controls.Add(this.tabPage3);
            this.tabControlMemento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMemento.Location = new System.Drawing.Point(0, 0);
            this.tabControlMemento.Name = "tabControlMemento";
            this.tabControlMemento.SelectedIndex = 0;
            this.tabControlMemento.Size = new System.Drawing.Size(984, 461);
            this.tabControlMemento.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.listBoxSteps);
            this.tabPage3.Controls.Add(this.buttonLoad);
            this.tabPage3.Controls.Add(this.buttonSave);
            this.tabPage3.Controls.Add(this.buttonHeroStep);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonHeroStep
            // 
            this.buttonHeroStep.Location = new System.Drawing.Point(40, 39);
            this.buttonHeroStep.Name = "buttonHeroStep";
            this.buttonHeroStep.Size = new System.Drawing.Size(138, 39);
            this.buttonHeroStep.TabIndex = 0;
            this.buttonHeroStep.Text = "Ход героя";
            this.buttonHeroStep.UseVisualStyleBackColor = true;
            this.buttonHeroStep.Click += new System.EventHandler(this.buttonHeroStep_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(40, 127);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(138, 39);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохраниться";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(40, 211);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(138, 39);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Загрузиться";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // listBoxSteps
            // 
            this.listBoxSteps.FormattingEnabled = true;
            this.listBoxSteps.Location = new System.Drawing.Point(280, 6);
            this.listBoxSteps.Name = "listBoxSteps";
            this.listBoxSteps.Size = new System.Drawing.Size(354, 420);
            this.listBoxSteps.TabIndex = 3;
            // 
            // FormMemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlMemento);
            this.Name = "FormMemento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memento";
            this.Load += new System.EventHandler(this.FormMemento_Load);
            this.tabControlMemento.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMemento;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonHeroStep;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxSteps;
    }
}