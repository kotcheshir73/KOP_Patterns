using ClassLibrarySingleton;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormSingleton : Form
    {
        public FormSingleton()
        {
            InitializeComponent();
        }

        private void FormSingleton_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует, что для определенного класса будет создан только один объект, а также предоставит к этому объекту точку доступа.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, true, false, "Одиночка используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда необходимо, чтобы для класса существовал только один экземпляр.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, false, false, "Синглтон позволяет создать объект только при его необходимости. Если объект не нужен, то он не будет создан. В этом отличие синглтона от глобальных переменных.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(SingletonOS), typeof(Computer), typeof(SingletonMultiOS) }, richTextBoxClass);
        }

        private void Example()
        {

        }

        private void buttonCreateComp_Click(object sender, EventArgs e)
        {
            Computer comp = new Computer();
            comp.Launch(textBoxOSName.Text);
            listBoxResult.Items.Add("Comp with OS: " + comp.OS.Name);
        }
    }
}
