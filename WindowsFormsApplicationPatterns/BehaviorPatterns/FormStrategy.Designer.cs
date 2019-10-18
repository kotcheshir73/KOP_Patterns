namespace WindowsFormsApplicationPatterns
{
    partial class FormStrategy
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
            this.tabControlStrategy = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCars = new System.Windows.Forms.ComboBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonFull = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.tabControlStrategy.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStrategy
            // 
            this.tabControlStrategy.Controls.Add(this.tabPage1);
            this.tabControlStrategy.Controls.Add(this.tabPage2);
            this.tabControlStrategy.Controls.Add(this.tabPage3);
            this.tabControlStrategy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStrategy.Location = new System.Drawing.Point(0, 0);
            this.tabControlStrategy.Name = "tabControlStrategy";
            this.tabControlStrategy.SelectedIndex = 0;
            this.tabControlStrategy.Size = new System.Drawing.Size(984, 461);
            this.tabControlStrategy.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.buttonMove);
            this.tabPage3.Controls.Add(this.buttonFull);
            this.tabPage3.Controls.Add(this.buttonSelect);
            this.tabPage3.Controls.Add(this.comboBoxCars);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбираем машину";
            // 
            // comboBoxCars
            // 
            this.comboBoxCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCars.FormattingEnabled = true;
            this.comboBoxCars.Location = new System.Drawing.Point(17, 60);
            this.comboBoxCars.Name = "comboBoxCars";
            this.comboBoxCars.Size = new System.Drawing.Size(170, 21);
            this.comboBoxCars.TabIndex = 1;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(50, 103);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(99, 47);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonFull
            // 
            this.buttonFull.Location = new System.Drawing.Point(73, 223);
            this.buttonFull.Name = "buttonFull";
            this.buttonFull.Size = new System.Drawing.Size(99, 47);
            this.buttonFull.TabIndex = 3;
            this.buttonFull.Text = "Заправить";
            this.buttonFull.UseVisualStyleBackColor = true;
            this.buttonFull.Click += new System.EventHandler(this.buttonFull_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(73, 323);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(99, 47);
            this.buttonMove.TabIndex = 4;
            this.buttonMove.Text = "Ехать";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(276, 28);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(404, 381);
            this.listBoxResult.TabIndex = 5;
            // 
            // FormStrategy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlStrategy);
            this.Name = "FormStrategy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strategy";
            this.Load += new System.EventHandler(this.FormStrategy_Load);
            this.tabControlStrategy.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStrategy;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCars;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonFull;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonMove;
    }
}