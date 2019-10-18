using ClassLibraryI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormI : Form
    {
        public FormI()
        {
            InitializeComponent();
        }

        private void FormI_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Принцип разделения интерфейсов (Interface Segregation Principle) относится к тем случаям, когда классы имеют \"жирный интерфейс\", то есть слишком раздутый интерфейс, не все методы и свойства которого используются и могут быть востребованы. Таким образом, интерфейс получатся слишком избыточен или \"жирным\".");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Принцип разделения интерфейсов можно сформулировать так:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "Клиенты не должны вынужденно зависеть от методов, которыми не пользуются");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "При нарушении этого принципа клиент, использующий некоторый интерфейс со всеми его методами, зависит от методов, которыми не пользуется, и поэтому оказывается восприимчив к изменениям в этих методах. В итоге мы приходим к жесткой зависимости между различными частями интерфейса, которые могут быть не связаны при его реализации.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "В этом случае интерфейс класса разделяется на отдельные части, которые составляют раздельные интерфейсы. Затем эти интерфейсы независимо друг от друга могут применяться и изменяться. В итоге применение принципа разделения интерфейсов делает систему слабосвязанной, и тем самым ее легче модифицировать и обновлять.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(BadInterface), typeof(BadClass), typeof(GoodInterface1), typeof(GoodInterface2), typeof(GoodClass1), typeof(GoodClass2) }, richTextBoxClass);
        }
    }
}
