namespace WindowsFormsApplicationPatterns
{
    partial class FormDecorator
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
            this.tabControlDecorator = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxPizzaType = new System.Windows.Forms.GroupBox();
            this.radioButtonItalian = new System.Windows.Forms.RadioButton();
            this.radioButtonAmerican = new System.Windows.Forms.RadioButton();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelPizza = new System.Windows.Forms.Label();
            this.buttonGetPizza = new System.Windows.Forms.Button();
            this.groupBoxDecorator = new System.Windows.Forms.GroupBox();
            this.tabControlDecorator.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxPizzaType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDecorator
            // 
            this.tabControlDecorator.Controls.Add(this.tabPage1);
            this.tabControlDecorator.Controls.Add(this.tabPage2);
            this.tabControlDecorator.Controls.Add(this.tabPage3);
            this.tabControlDecorator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDecorator.Location = new System.Drawing.Point(0, 0);
            this.tabControlDecorator.Name = "tabControlDecorator";
            this.tabControlDecorator.SelectedIndex = 0;
            this.tabControlDecorator.Size = new System.Drawing.Size(984, 461);
            this.tabControlDecorator.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.groupBoxPizzaType);
            this.tabPage3.Controls.Add(this.labelCost);
            this.tabPage3.Controls.Add(this.labelPizza);
            this.tabPage3.Controls.Add(this.buttonGetPizza);
            this.tabPage3.Controls.Add(this.groupBoxDecorator);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxPizzaType
            // 
            this.groupBoxPizzaType.Controls.Add(this.radioButtonItalian);
            this.groupBoxPizzaType.Controls.Add(this.radioButtonAmerican);
            this.groupBoxPizzaType.Location = new System.Drawing.Point(8, 6);
            this.groupBoxPizzaType.Name = "groupBoxPizzaType";
            this.groupBoxPizzaType.Size = new System.Drawing.Size(200, 215);
            this.groupBoxPizzaType.TabIndex = 0;
            this.groupBoxPizzaType.TabStop = false;
            this.groupBoxPizzaType.Text = "Основы для пиицы";
            // 
            // radioButtonItalian
            // 
            this.radioButtonItalian.AutoSize = true;
            this.radioButtonItalian.Checked = true;
            this.radioButtonItalian.Location = new System.Drawing.Point(28, 37);
            this.radioButtonItalian.Name = "radioButtonItalian";
            this.radioButtonItalian.Size = new System.Drawing.Size(125, 17);
            this.radioButtonItalian.TabIndex = 0;
            this.radioButtonItalian.TabStop = true;
            this.radioButtonItalian.Text = "Итальянская пицца";
            this.radioButtonItalian.UseVisualStyleBackColor = true;
            // 
            // radioButtonAmerican
            // 
            this.radioButtonAmerican.AutoSize = true;
            this.radioButtonAmerican.Location = new System.Drawing.Point(28, 76);
            this.radioButtonAmerican.Name = "radioButtonAmerican";
            this.radioButtonAmerican.Size = new System.Drawing.Size(100, 17);
            this.radioButtonAmerican.TabIndex = 1;
            this.radioButtonAmerican.Text = "Американская";
            this.radioButtonAmerican.UseVisualStyleBackColor = true;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(371, 352);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(65, 13);
            this.labelCost.TabIndex = 4;
            this.labelCost.Text = "Стоимость:";
            // 
            // labelPizza
            // 
            this.labelPizza.AutoSize = true;
            this.labelPizza.Location = new System.Drawing.Point(371, 263);
            this.labelPizza.Name = "labelPizza";
            this.labelPizza.Size = new System.Drawing.Size(42, 13);
            this.labelPizza.TabIndex = 3;
            this.labelPizza.Text = "Пицца:";
            // 
            // buttonGetPizza
            // 
            this.buttonGetPizza.Location = new System.Drawing.Point(129, 296);
            this.buttonGetPizza.Name = "buttonGetPizza";
            this.buttonGetPizza.Size = new System.Drawing.Size(161, 44);
            this.buttonGetPizza.TabIndex = 2;
            this.buttonGetPizza.Text = "Получить пиццу";
            this.buttonGetPizza.UseVisualStyleBackColor = true;
            this.buttonGetPizza.Click += new System.EventHandler(this.buttonGetPizza_Click);
            // 
            // groupBoxDecorator
            // 
            this.groupBoxDecorator.Location = new System.Drawing.Point(214, 6);
            this.groupBoxDecorator.Name = "groupBoxDecorator";
            this.groupBoxDecorator.Size = new System.Drawing.Size(218, 215);
            this.groupBoxDecorator.TabIndex = 1;
            this.groupBoxDecorator.TabStop = false;
            this.groupBoxDecorator.Text = "Модиифкации";
            // 
            // FormDecorator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlDecorator);
            this.Name = "FormDecorator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decorator";
            this.Load += new System.EventHandler(this.FormDecorator_Load);
            this.tabControlDecorator.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxPizzaType.ResumeLayout(false);
            this.groupBoxPizzaType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDecorator;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton radioButtonItalian;
        private System.Windows.Forms.RadioButton radioButtonAmerican;
        private System.Windows.Forms.GroupBox groupBoxDecorator;
        private System.Windows.Forms.Button buttonGetPizza;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelPizza;
        private System.Windows.Forms.GroupBox groupBoxPizzaType;
    }
}

