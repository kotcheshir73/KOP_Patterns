using ClassLibraryD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormD : Form
    {
        public FormD()
        {
            InitializeComponent();
        }

        private void FormD_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Принцип инверсии зависимостей (Dependency Inversion Principle) служит для создания слабосвязанных сущностей, которые легко тестировать, модифицировать и обновлять. Этот принцип можно сформулировать следующим образом:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "Модули верхнего уровня не должны зависеть от модулей нижнего уровня. И те и другие должны зависеть от абстракций.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Абстракции не должны зависеть от деталей. Детали должны зависеть от абстракций.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(SomeObjectForBadClass), typeof(BadClass), typeof(InterfaceForSomeClass), typeof(SomeObjectForGoodClass), typeof(GoodClass) }, richTextBoxClass);
        }
    }
}
