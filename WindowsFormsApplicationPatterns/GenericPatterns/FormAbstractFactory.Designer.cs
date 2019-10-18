namespace WindowsFormsApplicationPatterns
{
    partial class FormAbstractFactory
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
            this.tabControlAbstractFactory = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonHeroHit = new System.Windows.Forms.Button();
            this.buttonHeroMove = new System.Windows.Forms.Button();
            this.comboBoxTypeHero = new System.Windows.Forms.ComboBox();
            this.labelTypeHero = new System.Windows.Forms.Label();
            this.buttonCreateHero = new System.Windows.Forms.Button();
            this.tabControlAbstractFactory.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAbstractFactory
            // 
            this.tabControlAbstractFactory.Controls.Add(this.tabPage1);
            this.tabControlAbstractFactory.Controls.Add(this.tabPage2);
            this.tabControlAbstractFactory.Controls.Add(this.tabPage3);
            this.tabControlAbstractFactory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAbstractFactory.Location = new System.Drawing.Point(0, 0);
            this.tabControlAbstractFactory.Name = "tabControlAbstractFactory";
            this.tabControlAbstractFactory.SelectedIndex = 0;
            this.tabControlAbstractFactory.Size = new System.Drawing.Size(984, 461);
            this.tabControlAbstractFactory.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.listBoxEvents);
            this.tabPage3.Controls.Add(this.buttonHeroHit);
            this.tabPage3.Controls.Add(this.buttonHeroMove);
            this.tabPage3.Controls.Add(this.comboBoxTypeHero);
            this.tabPage3.Controls.Add(this.labelTypeHero);
            this.tabPage3.Controls.Add(this.buttonCreateHero);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(584, 6);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(217, 407);
            this.listBoxEvents.TabIndex = 5;
            // 
            // buttonHeroHit
            // 
            this.buttonHeroHit.Location = new System.Drawing.Point(336, 98);
            this.buttonHeroHit.Name = "buttonHeroHit";
            this.buttonHeroHit.Size = new System.Drawing.Size(149, 35);
            this.buttonHeroHit.TabIndex = 4;
            this.buttonHeroHit.Text = "Герой атакует";
            this.buttonHeroHit.UseVisualStyleBackColor = true;
            this.buttonHeroHit.Click += new System.EventHandler(this.buttonHeroHit_Click);
            // 
            // buttonHeroMove
            // 
            this.buttonHeroMove.Location = new System.Drawing.Point(336, 26);
            this.buttonHeroMove.Name = "buttonHeroMove";
            this.buttonHeroMove.Size = new System.Drawing.Size(149, 35);
            this.buttonHeroMove.TabIndex = 3;
            this.buttonHeroMove.Text = "Герой перемещается";
            this.buttonHeroMove.UseVisualStyleBackColor = true;
            this.buttonHeroMove.Click += new System.EventHandler(this.buttonHeroMove_Click);
            // 
            // comboBoxTypeHero
            // 
            this.comboBoxTypeHero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeHero.FormattingEnabled = true;
            this.comboBoxTypeHero.Location = new System.Drawing.Point(45, 52);
            this.comboBoxTypeHero.Name = "comboBoxTypeHero";
            this.comboBoxTypeHero.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeHero.TabIndex = 2;
            // 
            // labelTypeHero
            // 
            this.labelTypeHero.AutoSize = true;
            this.labelTypeHero.Location = new System.Drawing.Point(73, 26);
            this.labelTypeHero.Name = "labelTypeHero";
            this.labelTypeHero.Size = new System.Drawing.Size(61, 13);
            this.labelTypeHero.TabIndex = 1;
            this.labelTypeHero.Text = "Тип героя:";
            // 
            // buttonCreateHero
            // 
            this.buttonCreateHero.Location = new System.Drawing.Point(33, 98);
            this.buttonCreateHero.Name = "buttonCreateHero";
            this.buttonCreateHero.Size = new System.Drawing.Size(146, 30);
            this.buttonCreateHero.TabIndex = 0;
            this.buttonCreateHero.Text = "Создать героя";
            this.buttonCreateHero.UseVisualStyleBackColor = true;
            this.buttonCreateHero.Click += new System.EventHandler(this.buttonCreateHero_Click);
            // 
            // FormAbstractFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlAbstractFactory);
            this.Name = "FormAbstractFactory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abstract Factory";
            this.Load += new System.EventHandler(this.FormAbstractFactory_Load);
            this.tabControlAbstractFactory.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAbstractFactory;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonCreateHero;
        private System.Windows.Forms.ComboBox comboBoxTypeHero;
        private System.Windows.Forms.Label labelTypeHero;
        private System.Windows.Forms.Button buttonHeroHit;
        private System.Windows.Forms.Button buttonHeroMove;
        private System.Windows.Forms.ListBox listBoxEvents;
    }
}