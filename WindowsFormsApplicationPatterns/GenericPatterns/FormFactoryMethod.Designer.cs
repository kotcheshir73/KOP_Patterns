namespace WindowsFormsApplicationPatterns
{
    partial class FormFactoryMethod
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
            this.tabControlFactoryMethod = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelTypeDeveloper = new System.Windows.Forms.Label();
            this.comboBoxTypeDeveloper = new System.Windows.Forms.ComboBox();
            this.buttonCreateDeveloper = new System.Windows.Forms.Button();
            this.listBoxDevelopers = new System.Windows.Forms.ListBox();
            this.buttonBuildHouse = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.tabControlFactoryMethod.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFactoryMethod
            // 
            this.tabControlFactoryMethod.Controls.Add(this.tabPage1);
            this.tabControlFactoryMethod.Controls.Add(this.tabPage2);
            this.tabControlFactoryMethod.Controls.Add(this.tabPage3);
            this.tabControlFactoryMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFactoryMethod.Location = new System.Drawing.Point(0, 0);
            this.tabControlFactoryMethod.Name = "tabControlFactoryMethod";
            this.tabControlFactoryMethod.SelectedIndex = 0;
            this.tabControlFactoryMethod.Size = new System.Drawing.Size(984, 461);
            this.tabControlFactoryMethod.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.buttonBuildHouse);
            this.tabPage3.Controls.Add(this.listBoxDevelopers);
            this.tabPage3.Controls.Add(this.buttonCreateDeveloper);
            this.tabPage3.Controls.Add(this.comboBoxTypeDeveloper);
            this.tabPage3.Controls.Add(this.labelTypeDeveloper);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelTypeDeveloper
            // 
            this.labelTypeDeveloper.AutoSize = true;
            this.labelTypeDeveloper.Location = new System.Drawing.Point(85, 46);
            this.labelTypeDeveloper.Name = "labelTypeDeveloper";
            this.labelTypeDeveloper.Size = new System.Drawing.Size(97, 13);
            this.labelTypeDeveloper.TabIndex = 0;
            this.labelTypeDeveloper.Text = "Тип застройщика";
            // 
            // comboBoxTypeDeveloper
            // 
            this.comboBoxTypeDeveloper.FormattingEnabled = true;
            this.comboBoxTypeDeveloper.Location = new System.Drawing.Point(72, 73);
            this.comboBoxTypeDeveloper.Name = "comboBoxTypeDeveloper";
            this.comboBoxTypeDeveloper.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeDeveloper.TabIndex = 1;
            // 
            // buttonCreateDeveloper
            // 
            this.buttonCreateDeveloper.Location = new System.Drawing.Point(92, 111);
            this.buttonCreateDeveloper.Name = "buttonCreateDeveloper";
            this.buttonCreateDeveloper.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateDeveloper.TabIndex = 2;
            this.buttonCreateDeveloper.Text = "Создать";
            this.buttonCreateDeveloper.UseVisualStyleBackColor = true;
            this.buttonCreateDeveloper.Click += new System.EventHandler(this.buttonCreateDeveloper_Click);
            // 
            // listBoxDevelopers
            // 
            this.listBoxDevelopers.FormattingEnabled = true;
            this.listBoxDevelopers.Location = new System.Drawing.Point(257, 28);
            this.listBoxDevelopers.Name = "listBoxDevelopers";
            this.listBoxDevelopers.Size = new System.Drawing.Size(185, 199);
            this.listBoxDevelopers.TabIndex = 3;
            // 
            // buttonBuildHouse
            // 
            this.buttonBuildHouse.Location = new System.Drawing.Point(457, 77);
            this.buttonBuildHouse.Name = "buttonBuildHouse";
            this.buttonBuildHouse.Size = new System.Drawing.Size(135, 57);
            this.buttonBuildHouse.TabIndex = 4;
            this.buttonBuildHouse.Text = "Построить дом";
            this.buttonBuildHouse.UseVisualStyleBackColor = true;
            this.buttonBuildHouse.Click += new System.EventHandler(this.buttonBuildHouse_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(607, 28);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(275, 394);
            this.listBoxResult.TabIndex = 5;
            // 
            // FormFactoryMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlFactoryMethod);
            this.Name = "FormFactoryMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factory Method";
            this.Load += new System.EventHandler(this.FormFactoryMethod_Load);
            this.tabControlFactoryMethod.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFactoryMethod;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelTypeDeveloper;
        private System.Windows.Forms.Button buttonBuildHouse;
        private System.Windows.Forms.ListBox listBoxDevelopers;
        private System.Windows.Forms.Button buttonCreateDeveloper;
        private System.Windows.Forms.ComboBox comboBoxTypeDeveloper;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}