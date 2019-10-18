using ClassLibraryS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormS : Form
    {
        public FormS()
        {
            InitializeComponent();
        }

        private void FormS_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Принцип единственной обязанности (Single Responsibility Principle) можно сформулировать так:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "У класса должна быть только одна причина для изменения");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            
            dp.InsertText(richTextBoxDescribe, false, false, "Под обязанностью здесь понимается набор функций, которые выполняют единую задачу. Суть этого принципа заключается в том, что класс должен выполнять одну единственную задачу. Весь функционал класса должен быть целостным, обладать высокой связностью (high cohesion).");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Конкретное применение принципа зависит от контекста. В данном случае важно понимать, как изменяется класс. Если класс выполняет несколько различных функций, и они изменяются по отдельности, то это как раз тот случай, когда можно применить принцип единственной обязанности. То есть иными словами, у класса несколько причин для изменения.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Но если же все функции класса, как правило, изменяются вместе и составляют одно функциональное целое, решают одну задачу, то нет смысла применять данный принцип.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(BadClass), typeof(GoodClass1), typeof(GoodClass2) }, richTextBoxClass);
        }
    }
}
