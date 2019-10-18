using ClassLibraryO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormO : Form
    {
        public FormO()
        {
            InitializeComponent();
        }

        private void FormO_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Принцип открытости/закрытости (Open/Closed Principle) можно сформулировать так:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "Сущности программы должны быть открыты для расширения, но закрыты для изменения");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Суть этого принципа состоит в том, что система должна быть построена таким образом, что все ее последующие изменения должны быть реализованы с помощью добавления нового кода, а не изменения уже существующего.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(SomeObjectForBadClass), typeof(BadClass), typeof(InterfaceWorkWithBD), typeof(WorkWithBDFromLINQToSQL), typeof(GoodClass) }, richTextBoxClass);
        }
    }
}
