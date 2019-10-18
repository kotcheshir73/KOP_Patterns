using ClassLibraryFacade;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormFacade : Form
    {
        Programmer proger;

        public FormFacade()
        {
            InitializeComponent();
        }

        private void FormFacade_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Фасад (Facade) представляет шаблон проектирования, который позволяет скрыть сложность системы с помощью предоставления упрощенного интерфейса для взаимодействия с ней.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Фасад используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда имеется сложная система, и необходимо упростить с ней работу. Фасад позволит определить одну точку взаимодействия между клиентом и системой.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда надо уменьшить количество зависимостей между клиентом и сложной системой. Фасадные объекты позволяют отделить, изолировать компоненты системы от клиента и развивать и работать с ними независимо.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда нужно определить подсистемы компонентов в сложной системе. Создание фасадов для компонентов каждой отдельной подсистемы позволит упростить взаимодействие между ними и повысить их независимость друг от друга.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            
            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- SubsystemA, SubsystemB, SubsystemC и т.д.:");
            dp.InsertText(richTextBoxDescribe, false, false, " классы, которые являются компонентами сложной подсистемы, с которыми должен взаимодействовать клиент.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Client:");
            dp.InsertText(richTextBoxDescribe, false, false, " взаимодействует с компонентами подсистемы.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Facade:");
            dp.InsertText(richTextBoxDescribe, false, false, " непосредственно фасад, который предоставляет интерфейс клиенту для работы с компонентами.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(Proga), typeof(TextEditor), typeof(Compiller), typeof(CLR), typeof(Facade), typeof(Programmer) }, richTextBoxClass);
        }

        private void Example()
        {
            proger = new Programmer(new Facade(new TextEditor(), new Compiller(), new CLR()));
        }

        private void buttonCreateProg_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Clear();
            if(textBoxProgName.Text != "")
            {
                richTextBoxResult.AppendText(proger.CreateProg(textBoxProgName.Text) + "\n");
            }
            else
            {
                richTextBoxResult.AppendText("Введите название программы");
            }
        }

        private void buttonChangeCode_Click(object sender, EventArgs e)
        {
            richTextBoxResult.AppendText(proger.MakeCode() + "\n");
        }

        private void buttonRunProg_Click(object sender, EventArgs e)
        {
            richTextBoxResult.AppendText(proger.Run() + "\n");
        }

        private void buttonStopProg_Click(object sender, EventArgs e)
        {
            richTextBoxResult.AppendText(proger.Stop() + "\n");
        }
    }
}
