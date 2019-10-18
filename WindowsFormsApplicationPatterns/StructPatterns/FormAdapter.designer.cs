namespace WindowsFormsApplicationPatterns
{
    partial class FormAdapter
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
            this.groupBoxTravelerMove = new System.Windows.Forms.GroupBox();
            this.radioButtonCountry = new System.Windows.Forms.RadioButton();
            this.radioButtonJungle = new System.Windows.Forms.RadioButton();
            this.radioButtonVillage = new System.Windows.Forms.RadioButton();
            this.radioButtonSity = new System.Windows.Forms.RadioButton();
            this.labelTraveler = new System.Windows.Forms.Label();
            this.tabControlAdapter.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxTravelerMove.SuspendLayout();
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
            this.tabPage3.Controls.Add(this.groupBoxTravelerMove);
            this.tabPage3.Controls.Add(this.labelTraveler);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxTravelerMove
            // 
            this.groupBoxTravelerMove.Controls.Add(this.radioButtonCountry);
            this.groupBoxTravelerMove.Controls.Add(this.radioButtonJungle);
            this.groupBoxTravelerMove.Controls.Add(this.radioButtonVillage);
            this.groupBoxTravelerMove.Controls.Add(this.radioButtonSity);
            this.groupBoxTravelerMove.Location = new System.Drawing.Point(8, 6);
            this.groupBoxTravelerMove.Name = "groupBoxTravelerMove";
            this.groupBoxTravelerMove.Size = new System.Drawing.Size(367, 208);
            this.groupBoxTravelerMove.TabIndex = 4;
            this.groupBoxTravelerMove.TabStop = false;
            this.groupBoxTravelerMove.Text = "Как может передвигаться путешественник";
            // 
            // radioButtonCountry
            // 
            this.radioButtonCountry.AutoSize = true;
            this.radioButtonCountry.Location = new System.Drawing.Point(21, 112);
            this.radioButtonCountry.Name = "radioButtonCountry";
            this.radioButtonCountry.Size = new System.Drawing.Size(75, 17);
            this.radioButtonCountry.TabIndex = 3;
            this.radioButtonCountry.TabStop = true;
            this.radioButtonCountry.Text = "по стране";
            this.radioButtonCountry.UseVisualStyleBackColor = true;
            this.radioButtonCountry.CheckedChanged += new System.EventHandler(this.radioButtonCountry_CheckedChanged);
            // 
            // radioButtonJungle
            // 
            this.radioButtonJungle.AutoSize = true;
            this.radioButtonJungle.Location = new System.Drawing.Point(240, 31);
            this.radioButtonJungle.Name = "radioButtonJungle";
            this.radioButtonJungle.Size = new System.Drawing.Size(96, 17);
            this.radioButtonJungle.TabIndex = 2;
            this.radioButtonJungle.TabStop = true;
            this.radioButtonJungle.Text = "по джунглиям";
            this.radioButtonJungle.UseVisualStyleBackColor = true;
            this.radioButtonJungle.CheckedChanged += new System.EventHandler(this.radioButtonJungle_CheckedChanged);
            // 
            // radioButtonVillage
            // 
            this.radioButtonVillage.AutoSize = true;
            this.radioButtonVillage.Location = new System.Drawing.Point(21, 71);
            this.radioButtonVillage.Name = "radioButtonVillage";
            this.radioButtonVillage.Size = new System.Drawing.Size(63, 17);
            this.radioButtonVillage.TabIndex = 2;
            this.radioButtonVillage.TabStop = true;
            this.radioButtonVillage.Text = "по селу";
            this.radioButtonVillage.UseVisualStyleBackColor = true;
            this.radioButtonVillage.CheckedChanged += new System.EventHandler(this.radioButtonVillage_CheckedChanged);
            // 
            // radioButtonSity
            // 
            this.radioButtonSity.AutoSize = true;
            this.radioButtonSity.Location = new System.Drawing.Point(21, 31);
            this.radioButtonSity.Name = "radioButtonSity";
            this.radioButtonSity.Size = new System.Drawing.Size(74, 17);
            this.radioButtonSity.TabIndex = 1;
            this.radioButtonSity.TabStop = true;
            this.radioButtonSity.Text = "по городу";
            this.radioButtonSity.UseVisualStyleBackColor = true;
            this.radioButtonSity.CheckedChanged += new System.EventHandler(this.radioButtonSity_CheckedChanged);
            // 
            // labelTraveler
            // 
            this.labelTraveler.AutoSize = true;
            this.labelTraveler.Location = new System.Drawing.Point(448, 39);
            this.labelTraveler.Name = "labelTraveler";
            this.labelTraveler.Size = new System.Drawing.Size(13, 13);
            this.labelTraveler.TabIndex = 0;
            this.labelTraveler.Text = "?";
            // 
            // FormAdapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlAdapter);
            this.Name = "FormAdapter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adapter";
            this.Load += new System.EventHandler(this.FormAdapter_Load);
            this.tabControlAdapter.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxTravelerMove.ResumeLayout(false);
            this.groupBoxTravelerMove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelTraveler;
        private System.Windows.Forms.RadioButton radioButtonJungle;
        private System.Windows.Forms.RadioButton radioButtonSity;
        private System.Windows.Forms.GroupBox groupBoxTravelerMove;
        private System.Windows.Forms.RadioButton radioButtonCountry;
        private System.Windows.Forms.RadioButton radioButtonVillage;
    }
}

