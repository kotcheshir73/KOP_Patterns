using ClassLibraryChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormChainOfResponsibility : Form
    {
        PaymentHandler bank;

        PaymentHandler payPal;

        PaymentHandler moneyTrans;

        public FormChainOfResponsibility()
        {
            InitializeComponent();
        }

        private void FormChainOfResponsibility_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Цепочка Обязанностей (Chain of responsibility) - поведенческий шаблон проектирования, который позволяет избежать жесткой привязки отправителя запроса к получателю, позволяя нескольким объектам обработать запрос. Все возможные обработчики запроса образуют цепочку, а сам запрос перемещается по этой цепочке, пока один из ее объектов не обработает запрос. Каждый объект при получении запроса выбирает, либо обработать запрос, либо передать выполнение запроса следующему по цепочке.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, true, false, "Цепочка Обязанностей используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда имеется более одного объекта, который может обработать определенный запрос.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда надо передать запрос на выполнение одному из нескольких объект, точно не определяя, какому именно объекту.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда набор объектов задается динамически.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Handler:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет интерфейс для обработки запроса. Также может определять ссылку на следующий обработчик запроса.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteHandler1 и ConcreteHandler2:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретные обработчики, которые реализуют функционал для обработки запроса. При невозможности обработки и наличия ссылки на следующий обработчик, передают запрос этому обработчику.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, " В данном случае для простоты примера в качестве параметра передается некоторое число, и в зависимости от значения данного числа обработчики и принимают решения об обработке запроса.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Client:");
            dp.InsertText(richTextBoxDescribe, false, false, " отправляет запрос объекту Handler.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Использование цепочки обязанностей дает нам следующие преимущества:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, " - Ослабление связанности между объектами. Отправителю и получателю запроса ничего не известно друг о друге. Клиенту неизветна цепочка объектов, какие именно объекты составляют ее, как запрос в ней передается.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, " - В цепочку с легкостью можно добавлять новые типы объектов, которые реализуют общий интерфейс.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "В то же время у паттерна есть недостаток: никто не гарантирует, что запрос в конечном счете будет обработан. Если необходимого обработчика в цепочки не оказалось, то запрос просто выходит из цепочки и остается необработанным.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(PaymentHandler), typeof(BankPaymentHandler), typeof(PayPalPaymentHandler), typeof(MoneyPaymentHandler), typeof(Receiver) }, richTextBoxClass);
        }

        private void Example()
        {
            bank = new BankPaymentHandler();
            payPal = new PayPalPaymentHandler();
            moneyTrans = new MoneyPaymentHandler();
            bank.Successor = payPal;
            payPal.Successor = moneyTrans;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Receiver receiver = new Receiver(checkBoxBank.Checked, checkBoxPayPal.Checked, checkBoxMoney.Checked);
            listBoxResult.Items.Add(bank.Handle(receiver));
        }
    }
}
