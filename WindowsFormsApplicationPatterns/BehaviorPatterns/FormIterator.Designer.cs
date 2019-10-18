namespace WindowsFormsApplicationPatterns
{
    partial class FormIterator
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
            this.tabControlIterator = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelBooks = new System.Windows.Forms.Label();
            this.textBoxBook = new System.Windows.Forms.TextBox();
            this.buttonSeeNext = new System.Windows.Forms.Button();
            this.tabControlIterator.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlIterator
            // 
            this.tabControlIterator.Controls.Add(this.tabPage1);
            this.tabControlIterator.Controls.Add(this.tabPage2);
            this.tabControlIterator.Controls.Add(this.tabPage3);
            this.tabControlIterator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlIterator.Location = new System.Drawing.Point(0, 0);
            this.tabControlIterator.Name = "tabControlIterator";
            this.tabControlIterator.SelectedIndex = 0;
            this.tabControlIterator.Size = new System.Drawing.Size(984, 461);
            this.tabControlIterator.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.buttonSeeNext);
            this.tabPage3.Controls.Add(this.textBoxBook);
            this.tabPage3.Controls.Add(this.labelBooks);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.Location = new System.Drawing.Point(40, 33);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(102, 13);
            this.labelBooks.TabIndex = 0;
            this.labelBooks.Text = "Книги библиотеки:";
            // 
            // textBoxBook
            // 
            this.textBoxBook.Location = new System.Drawing.Point(43, 72);
            this.textBoxBook.Name = "textBoxBook";
            this.textBoxBook.Size = new System.Drawing.Size(313, 20);
            this.textBoxBook.TabIndex = 1;
            // 
            // buttonSeeNext
            // 
            this.buttonSeeNext.Location = new System.Drawing.Point(110, 116);
            this.buttonSeeNext.Name = "buttonSeeNext";
            this.buttonSeeNext.Size = new System.Drawing.Size(197, 23);
            this.buttonSeeNext.TabIndex = 2;
            this.buttonSeeNext.Text = "Показать следующую";
            this.buttonSeeNext.UseVisualStyleBackColor = true;
            this.buttonSeeNext.Click += new System.EventHandler(this.buttonSeeNext_Click);
            // 
            // FormIterator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlIterator);
            this.Name = "FormIterator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iterator";
            this.Load += new System.EventHandler(this.FormIterator_Load);
            this.tabControlIterator.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlIterator;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.Button buttonSeeNext;
        private System.Windows.Forms.TextBox textBoxBook;
    }
}