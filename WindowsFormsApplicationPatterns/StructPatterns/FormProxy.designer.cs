namespace WindowsFormsApplicationPatterns
{
    partial class FormProxy
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.tabControlAdapter = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxTime = new System.Windows.Forms.ListBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.richTextBoxPage = new System.Windows.Forms.RichTextBox();
            this.labelPage = new System.Windows.Forms.Label();
            this.buttonLoadPage = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.tabControlAdapter.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdapter
            // 
            this.tabControlAdapter.Controls.Add(this.tabPage1);
            this.tabControlAdapter.Controls.Add(this.tabPage2);
            this.tabControlAdapter.Controls.Add(this.tabPage3);
            this.tabControlAdapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdapter.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdapter.Name = "tabControlAdapter";
            this.tabControlAdapter.SelectedIndex = 0;
            this.tabControlAdapter.Size = new System.Drawing.Size(984, 461);
            this.tabControlAdapter.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.listBoxTime);
            this.tabPage3.Controls.Add(this.labelTime);
            this.tabPage3.Controls.Add(this.richTextBoxPage);
            this.tabPage3.Controls.Add(this.labelPage);
            this.tabPage3.Controls.Add(this.buttonLoadPage);
            this.tabPage3.Controls.Add(this.textBoxNumber);
            this.tabPage3.Controls.Add(this.labelNumber);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxTime
            // 
            this.listBoxTime.FormattingEnabled = true;
            this.listBoxTime.Location = new System.Drawing.Point(640, 63);
            this.listBoxTime.Name = "listBoxTime";
            this.listBoxTime.Size = new System.Drawing.Size(278, 199);
            this.listBoxTime.TabIndex = 6;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(637, 21);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(92, 13);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Время загрузки:";
            // 
            // richTextBoxPage
            // 
            this.richTextBoxPage.Location = new System.Drawing.Point(364, 21);
            this.richTextBoxPage.Name = "richTextBoxPage";
            this.richTextBoxPage.Size = new System.Drawing.Size(222, 111);
            this.richTextBoxPage.TabIndex = 4;
            this.richTextBoxPage.Text = "";
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Location = new System.Drawing.Point(300, 24);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(58, 13);
            this.labelPage.TabIndex = 3;
            this.labelPage.Text = "Страница:";
            // 
            // buttonLoadPage
            // 
            this.buttonLoadPage.Location = new System.Drawing.Point(48, 63);
            this.buttonLoadPage.Name = "buttonLoadPage";
            this.buttonLoadPage.Size = new System.Drawing.Size(157, 33);
            this.buttonLoadPage.TabIndex = 2;
            this.buttonLoadPage.Text = "Отобразить страницу";
            this.buttonLoadPage.UseVisualStyleBackColor = true;
            this.buttonLoadPage.Click += new System.EventHandler(this.buttonLoadPage_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(181, 21);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(55, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(22, 24);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(153, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Номер требуемой страницы:";
            // 
            // FormProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlAdapter);
            this.Name = "FormProxy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proxy";
            this.Load += new System.EventHandler(this.FormProxy_Load);
            this.tabControlAdapter.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonLoadPage;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.RichTextBox richTextBoxPage;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ListBox listBoxTime;
    }
}

