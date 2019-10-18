namespace WindowsFormsApplicationPatterns
{
    partial class FormFlyweight
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
            this.tabControlFlyweight = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelTypeHouse = new System.Windows.Forms.Label();
            this.comboBoxTypeHouse = new System.Windows.Forms.ComboBox();
            this.buttonSetHouse = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.tabControlFlyweight.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFlyweight
            // 
            this.tabControlFlyweight.Controls.Add(this.tabPage1);
            this.tabControlFlyweight.Controls.Add(this.tabPage2);
            this.tabControlFlyweight.Controls.Add(this.tabPage3);
            this.tabControlFlyweight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFlyweight.Location = new System.Drawing.Point(0, 0);
            this.tabControlFlyweight.Name = "tabControlFlyweight";
            this.tabControlFlyweight.SelectedIndex = 0;
            this.tabControlFlyweight.Size = new System.Drawing.Size(984, 461);
            this.tabControlFlyweight.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.buttonSetHouse);
            this.tabPage3.Controls.Add(this.comboBoxTypeHouse);
            this.tabPage3.Controls.Add(this.labelTypeHouse);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelTypeHouse
            // 
            this.labelTypeHouse.AutoSize = true;
            this.labelTypeHouse.Location = new System.Drawing.Point(70, 35);
            this.labelTypeHouse.Name = "labelTypeHouse";
            this.labelTypeHouse.Size = new System.Drawing.Size(58, 13);
            this.labelTypeHouse.TabIndex = 0;
            this.labelTypeHouse.Text = "Тип дома:";
            // 
            // comboBoxTypeHouse
            // 
            this.comboBoxTypeHouse.FormattingEnabled = true;
            this.comboBoxTypeHouse.Location = new System.Drawing.Point(41, 60);
            this.comboBoxTypeHouse.Name = "comboBoxTypeHouse";
            this.comboBoxTypeHouse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeHouse.TabIndex = 1;
            // 
            // buttonSetHouse
            // 
            this.buttonSetHouse.Location = new System.Drawing.Point(41, 114);
            this.buttonSetHouse.Name = "buttonSetHouse";
            this.buttonSetHouse.Size = new System.Drawing.Size(121, 42);
            this.buttonSetHouse.TabIndex = 2;
            this.buttonSetHouse.Text = "Разместить дом";
            this.buttonSetHouse.UseVisualStyleBackColor = true;
            this.buttonSetHouse.Click += new System.EventHandler(this.buttonSetHouse_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(205, 6);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(565, 420);
            this.listBoxResult.TabIndex = 3;
            // 
            // FormFlyweight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlFlyweight);
            this.Name = "FormFlyweight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flyweight";
            this.Load += new System.EventHandler(this.FormFlyweight_Load);
            this.tabControlFlyweight.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFlyweight;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelTypeHouse;
        private System.Windows.Forms.ComboBox comboBoxTypeHouse;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonSetHouse;
    }
}