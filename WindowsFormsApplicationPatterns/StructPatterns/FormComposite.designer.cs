namespace WindowsFormsApplicationPatterns
{
    partial class FormComposite
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
            this.richTextBoxFileSystem = new System.Windows.Forms.RichTextBox();
            this.groupBoxMoves = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxRemoveName = new System.Windows.Forms.TextBox();
            this.labelRemoveName = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.radioButtonDirectory = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxParentName = new System.Windows.Forms.TextBox();
            this.labelParentName = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelNewName = new System.Windows.Forms.Label();
            this.tabControlDecorator.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxMoves.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
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
            this.tabPage3.Controls.Add(this.richTextBoxFileSystem);
            this.tabPage3.Controls.Add(this.groupBoxMoves);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пример";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxFileSystem
            // 
            this.richTextBoxFileSystem.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxFileSystem.Name = "richTextBoxFileSystem";
            this.richTextBoxFileSystem.ReadOnly = true;
            this.richTextBoxFileSystem.Size = new System.Drawing.Size(422, 421);
            this.richTextBoxFileSystem.TabIndex = 0;
            this.richTextBoxFileSystem.Text = "";
            // 
            // groupBoxMoves
            // 
            this.groupBoxMoves.Controls.Add(this.groupBox1);
            this.groupBoxMoves.Controls.Add(this.groupBoxAdd);
            this.groupBoxMoves.Location = new System.Drawing.Point(434, 6);
            this.groupBoxMoves.Name = "groupBoxMoves";
            this.groupBoxMoves.Size = new System.Drawing.Size(480, 421);
            this.groupBoxMoves.TabIndex = 1;
            this.groupBoxMoves.TabStop = false;
            this.groupBoxMoves.Text = "Действия";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDel);
            this.groupBox1.Controls.Add(this.textBoxRemoveName);
            this.groupBox1.Controls.Add(this.labelRemoveName);
            this.groupBox1.Location = new System.Drawing.Point(235, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Удаление";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(70, 94);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxRemoveName
            // 
            this.textBoxRemoveName.Location = new System.Drawing.Point(22, 55);
            this.textBoxRemoveName.Name = "textBoxRemoveName";
            this.textBoxRemoveName.Size = new System.Drawing.Size(183, 20);
            this.textBoxRemoveName.TabIndex = 2;
            // 
            // labelRemoveName
            // 
            this.labelRemoveName.AutoSize = true;
            this.labelRemoveName.Location = new System.Drawing.Point(18, 28);
            this.labelRemoveName.Name = "labelRemoveName";
            this.labelRemoveName.Size = new System.Drawing.Size(172, 13);
            this.labelRemoveName.TabIndex = 1;
            this.labelRemoveName.Text = "Название удаляемого каталога:";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.radioButtonFile);
            this.groupBoxAdd.Controls.Add(this.radioButtonDirectory);
            this.groupBoxAdd.Controls.Add(this.buttonAdd);
            this.groupBoxAdd.Controls.Add(this.textBoxParentName);
            this.groupBoxAdd.Controls.Add(this.labelParentName);
            this.groupBoxAdd.Controls.Add(this.textBoxNewName);
            this.groupBoxAdd.Controls.Add(this.labelNewName);
            this.groupBoxAdd.Location = new System.Drawing.Point(6, 19);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(223, 246);
            this.groupBoxAdd.TabIndex = 0;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление";
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Location = new System.Drawing.Point(140, 177);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFile.TabIndex = 5;
            this.radioButtonFile.Text = "Файл";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            // 
            // radioButtonDirectory
            // 
            this.radioButtonDirectory.AutoSize = true;
            this.radioButtonDirectory.Checked = true;
            this.radioButtonDirectory.Location = new System.Drawing.Point(22, 177);
            this.radioButtonDirectory.Name = "radioButtonDirectory";
            this.radioButtonDirectory.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDirectory.TabIndex = 4;
            this.radioButtonDirectory.TabStop = true;
            this.radioButtonDirectory.Text = "Папка";
            this.radioButtonDirectory.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(67, 210);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxParentName
            // 
            this.textBoxParentName.Location = new System.Drawing.Point(22, 135);
            this.textBoxParentName.Name = "textBoxParentName";
            this.textBoxParentName.Size = new System.Drawing.Size(183, 20);
            this.textBoxParentName.TabIndex = 3;
            // 
            // labelParentName
            // 
            this.labelParentName.AutoSize = true;
            this.labelParentName.Location = new System.Drawing.Point(19, 104);
            this.labelParentName.Name = "labelParentName";
            this.labelParentName.Size = new System.Drawing.Size(188, 13);
            this.labelParentName.TabIndex = 2;
            this.labelParentName.Text = "Название родительского каталога:";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(21, 59);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(183, 20);
            this.textBoxNewName.TabIndex = 1;
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Location = new System.Drawing.Point(19, 28);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(147, 13);
            this.labelNewName.TabIndex = 0;
            this.labelNewName.Text = "Название нового каталога:";
            // 
            // FormComposite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tabControlDecorator);
            this.Name = "FormComposite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Composite";
            this.Load += new System.EventHandler(this.FormComposite_Load);
            this.tabControlDecorator.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBoxMoves.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDecorator;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxDescribe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxClass;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxMoves;
        private System.Windows.Forms.RichTextBox richTextBoxFileSystem;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxParentName;
        private System.Windows.Forms.Label labelParentName;
        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.RadioButton radioButtonDirectory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRemoveName;
        private System.Windows.Forms.Label labelRemoveName;
        private System.Windows.Forms.Button buttonDel;
    }
}

