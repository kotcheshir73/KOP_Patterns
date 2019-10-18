using ClassLibraryMediator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormMediator : Form
    {
        ManagerMediator mediator;

        Colleague customer;

        Colleague programmer;

        Colleague tester;

        public FormMediator()
        {
            InitializeComponent();
        }

        private void FormMediator_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн Посредник (Mediator) представляет такой шаблон проектирования, который обеспечивает взаимодействие множества объектов без необходимости ссылаться друг на друга. Тем самым достигается слабосвязанность взаимодействующих объектов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, true, false, "Посредник используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда имеется множество взаимосвязаных объектов, связи между которыми сложны и запутаны.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда необходимо повторно использовать объект, однако повторное использование затруднено в силу сильных связей с другими объектами.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Mediator:");
            dp.InsertText(richTextBoxDescribe, false, false, " представляет интерфейс для взаимодействия с объектами Colleague.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Colleague:");
            dp.InsertText(richTextBoxDescribe, false, false, " представляет интерфейс для взаимодействия с объектом Mediator.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteColleague1 и ConcreteColleague2:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретные классы коллег, которые обмениваются друг с другом через объект Mediator.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteMediator:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретный посредник, реализующий интерфейс типа Mediator.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(Mediator), typeof(Colleague), typeof(CustomerColleague), typeof(ProgrammerColleague), typeof(TesterColleague),
                typeof(ManagerMediator) }, richTextBoxClass);
        }

        private void Example()
        {
            mediator = new ManagerMediator();
            customer = new CustomerColleague(mediator);
            programmer = new ProgrammerColleague(mediator);
            tester = new TesterColleague(mediator);

            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Tester = tester;
        }

        private void buttonSendCustomerMessage_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerMessage.Text != "")
            {
                listBoxResult.Items.Add(customer.Send(textBoxCustomerMessage.Text));
            }
        }

        private void buttonSendProgrammerMessage_Click(object sender, EventArgs e)
        {
            if (textBoxProgrammerMessage.Text != "")
            {
                listBoxResult.Items.Add(programmer.Send(textBoxProgrammerMessage.Text));
            }
        }

        private void buttonSendTesterMessage_Click(object sender, EventArgs e)
        {
            if (textBoxTesterMessage.Text != "")
            {
                listBoxResult.Items.Add(tester.Send(textBoxTesterMessage.Text));
            }
        }
    }
}
