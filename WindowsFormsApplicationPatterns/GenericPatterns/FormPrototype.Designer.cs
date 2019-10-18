namespace WindowsFormsApplicationPatterns
{
    partial class FormPrototype
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
            this.tabControlPrototype = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonCreateClone = new System.Windows.Forms.Button();
            this.buttonCreateCircle = new System.Windows.Forms.Button();
            this.buttonCreateRectangle = new System.Windows.Forms.Button();
            this.tabControlPrototype.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPrototype
            // 
            this.tabControlPrototype.Controls.Add(this.tabPage1);
            this.tabControlPrototype.Controls.Add(this.tabPage2);
            this.tabControlPrototype.Controls.Add(this.tabPage3);
            this.tabControlPrototype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrototype.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrototype.Name = "tabControlPrototype";
            this.tabControlPrototype.SelectedIndex = 0;
            this.tabControlPrototype.Size = new System.Drawing.Size(984, 461);
            this.tabControlPrototype.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.buttonCreateClone);
            this.tabPage3.Controls.Add(this.buttonCreateCircle);
            this.tabPage3.Controls.Add(this.buttonCreateRectangle);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(248, 19);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(387, 394);
            this.listBoxResult.TabIndex = 3;
            // 
            // buttonCreateClone
            // 
            this.buttonCreateClone.Location = new System.Drawing.Point(668, 65);
            this.buttonCreateClone.Name = "buttonCreateClone";
            this.buttonCreateClone.Size = new System.Drawing.Size(171, 49);
            this.buttonCreateClone.TabIndex = 2;
            this.buttonCreateClone.Text = "Создать клон";
            this.buttonCreateClone.UseVisualStyleBackColor = true;
            this.buttonCreateClone.Click += new System.EventHandler(this.buttonCreateClone_Click);
            // 
            // buttonCreateCircle
            // 
            this.buttonCreateCircle.Location = new System.Drawing.Point(37, 118);
            this.buttonCreateCircle.Name = "buttonCreateCircle";
            this.buttonCreateCircle.Size = new System.Drawing.Size(171, 49);
            this.buttonCreateCircle.TabIndex = 1;
            this.buttonCreateCircle.Text = "Создать круг";
            this.buttonCreateCircle.UseVisualStyleBackColor = true;
            this.buttonCreateCircle.Click += new System.EventHandler(this.buttonCreateCircle_Click);
            // 
            // buttonCreateRectangle
            // 
            this.buttonCreateRectangle.Location = new System.Drawing.Point(37, 31);
            this.buttonCreateRectangle.Name = "buttonCreateRectangle";
            this.buttonCreateRectangle.Size = new System.Drawing.Size(171, 49);
            this.buttonCreateRectangle.TabIndex = 0;
            this.buttonCreateRectangle.Text = "Создать прямоугольник";
            this.buttonCreateRectangle.UseVisualStyleBackColor = true;
            this.buttonCreateRectangle.Click += new System.EventHandler(this.buttonCreateRectangle_Click);
            // 
            // FormPrototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlPrototype);
            this.Name = "FormPrototype";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prototype";
            this.Load += new System.EventHandler(this.FormPrototype_Load);
            this.tabControlPrototype.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrototype;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonCreateRectangle;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonCreateClone;
        private System.Windows.Forms.Button buttonCreateCircle;
    }
}