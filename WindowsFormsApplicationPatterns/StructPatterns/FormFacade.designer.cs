namespace WindowsFormsApplicationPatterns
{
    partial class FormFacade
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
            this.tabControlFacade = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxDescribe = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxClass = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxMoves = new System.Windows.Forms.GroupBox();
            this.buttonStopProg = new System.Windows.Forms.Button();
            this.buttonRunProg = new System.Windows.Forms.Button();
            this.buttonChangeCode = new System.Windows.Forms.Button();
            this.buttonCreateProg = new System.Windows.Forms.Button();
            this.textBoxProgName = new System.Windows.Forms.TextBox();
            this.labelProgName = new System.Windows.Forms.Label();
            this.tabControlFacade.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxMoves.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFacade
            // 
            this.tabControlFacade.Controls.Add(this.tabPage1);
            this.tabControlFacade.Controls.Add(this.tabPage2);
            this.tabControlFacade.Controls.Add(this.tabPage3);
            this.tabControlFacade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFacade.Location = new System.Drawing.Point(0, 0);
            this.tabControlFacade.Name = "tabControlFacade";
            this.tabControlFacade.SelectedIndex = 0;
            this.tabControlFacade.Size = new System.Drawing.Size(984, 461);
            this.tabControlFacade.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.richTextBoxResult);
            this.tabPage3.Controls.Add(this.labelResult);
            this.tabPage3.Controls.Add(this.groupBoxMoves);
            this.tabPage3.Controls.Add(this.buttonCreateProg);
            this.tabPage3.Controls.Add(this.textBoxProgName);
            this.tabPage3.Controls.Add(this.labelProgName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(517, 47);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(347, 361);
            this.richTextBoxResult.TabIndex = 5;
            this.richTextBoxResult.Text = "";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(503, 22);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Результат:";
            // 
            // groupBoxMoves
            // 
            this.groupBoxMoves.Controls.Add(this.buttonStopProg);
            this.groupBoxMoves.Controls.Add(this.buttonRunProg);
            this.groupBoxMoves.Controls.Add(this.buttonChangeCode);
            this.groupBoxMoves.Location = new System.Drawing.Point(258, 6);
            this.groupBoxMoves.Name = "groupBoxMoves";
            this.groupBoxMoves.Size = new System.Drawing.Size(200, 265);
            this.groupBoxMoves.TabIndex = 3;
            this.groupBoxMoves.TabStop = false;
            this.groupBoxMoves.Text = "Действия";
            // 
            // buttonStopProg
            // 
            this.buttonStopProg.Location = new System.Drawing.Point(33, 175);
            this.buttonStopProg.Name = "buttonStopProg";
            this.buttonStopProg.Size = new System.Drawing.Size(133, 50);
            this.buttonStopProg.TabIndex = 2;
            this.buttonStopProg.Text = "Остановить программу";
            this.buttonStopProg.UseVisualStyleBackColor = true;
            this.buttonStopProg.Click += new System.EventHandler(this.buttonStopProg_Click);
            // 
            // buttonRunProg
            // 
            this.buttonRunProg.Location = new System.Drawing.Point(33, 101);
            this.buttonRunProg.Name = "buttonRunProg";
            this.buttonRunProg.Size = new System.Drawing.Size(133, 50);
            this.buttonRunProg.TabIndex = 1;
            this.buttonRunProg.Text = "Запустить программу";
            this.buttonRunProg.UseVisualStyleBackColor = true;
            this.buttonRunProg.Click += new System.EventHandler(this.buttonRunProg_Click);
            // 
            // buttonChangeCode
            // 
            this.buttonChangeCode.Location = new System.Drawing.Point(33, 25);
            this.buttonChangeCode.Name = "buttonChangeCode";
            this.buttonChangeCode.Size = new System.Drawing.Size(133, 50);
            this.buttonChangeCode.TabIndex = 0;
            this.buttonChangeCode.Text = "Изменить код программы";
            this.buttonChangeCode.UseVisualStyleBackColor = true;
            this.buttonChangeCode.Click += new System.EventHandler(this.buttonChangeCode_Click);
            // 
            // buttonCreateProg
            // 
            this.buttonCreateProg.Location = new System.Drawing.Point(28, 97);
            this.buttonCreateProg.Name = "buttonCreateProg";
            this.buttonCreateProg.Size = new System.Drawing.Size(142, 23);
            this.buttonCreateProg.TabIndex = 2;
            this.buttonCreateProg.Text = "Создать программу";
            this.buttonCreateProg.UseVisualStyleBackColor = true;
            this.buttonCreateProg.Click += new System.EventHandler(this.buttonCreateProg_Click);
            // 
            // textBoxProgName
            // 
            this.textBoxProgName.Location = new System.Drawing.Point(47, 47);
            this.textBoxProgName.Name = "textBoxProgName";
            this.textBoxProgName.Size = new System.Drawing.Size(157, 20);
            this.textBoxProgName.TabIndex = 1;
            // 
            // labelProgName
            // 
            this.labelProgName.AutoSize = true;
            this.labelProgName.Location = new System.Drawing.Point(25, 22);
            this.labelProgName.Name = "labelProgName";
            this.labelProgName.Size = new System.Drawing.Size(122, 13);
            this.labelProgName.TabIndex = 0;
            this.labelProgName.Text = "Название программы:";
            // 
            // FormFacade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlFacade);
            this.Name = "FormFacade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facade";
            this.Load += new System.EventHandler(this.FormFacade_Load);
            this.tabControlFacade.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxMoves.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFacade;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelProgName;
        private System.Windows.Forms.TextBox textBoxProgName;
        private System.Windows.Forms.Button buttonCreateProg;
        private System.Windows.Forms.GroupBox groupBoxMoves;
        private System.Windows.Forms.Button buttonRunProg;
        private System.Windows.Forms.Button buttonChangeCode;
        private System.Windows.Forms.Button buttonStopProg;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
    }
}

