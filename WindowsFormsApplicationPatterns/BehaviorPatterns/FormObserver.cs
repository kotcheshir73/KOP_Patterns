using ClassLibraryObserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormObserver : Form
    {
        Stock stock;

        List<Broker> brokers;

        List<Bank> banks;

        public FormObserver()
        {
            InitializeComponent();
        }

        private void FormObserver_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн Наблюдатель (Observer) представляет поведенческий шаблон проектирования, который использует отношение \"один ко многим\". В этом отношении есть один наблюдаемый объект и множество наблюдателей. И при изменении наблюдаемого объекта автоматически происходит оповещение всех наблюдателей.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Данный паттерн еще называют Publisher-Subscriber (издатель-подписчик), поскольку отношения издателя и подписчиков характеризуют действие данного паттерна: подписчики подписываются email-рассылку определенного сайта. Сайт-издатель с помощью email-рассылки уведомляет всех подписчиков о изменениях. А подписчики получают изменения и производят определенные действия: могут зайти на сайт, могут проигнорировать уведомления и т.д.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Наблюдатель используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда система состоит из множества классов, объекты которых должны находиться в согласованных состояниях.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда общая схема взаимодействия объектов предполагает две стороны: одна рассылает сообщения и является главным, другая получает сообщения и реагирует на них. Отделение логики обеих сторон позволяет их рассматривать независимо и использовать отдельно друга от друга.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда существует один объект, рассылающий сообщения, и множество подписчиков, которые получают сообщения. При этом точное число подписчиков заранее неизвестно и процессе работы программы может изменяться.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            
            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- IObservable:");
            dp.InsertText(richTextBoxDescribe, false, false, " представляет наблюдаемый объект. Определяет три метода: AddObserver() (для добавления наблюдателя), RemoveObserver() (удаление набюдателя) и NotifyObservers() (уведомление наблюдателей).");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteObservable:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретная реализация интерфейса IObservable. Определяет коллекцию объектов наблюдателей.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- IObserver:");
            dp.InsertText(richTextBoxDescribe, false, false, " представляет наблюдателя, который подписывается на все уведомления наблюдаемого объекта. Определяет метод Update(), который вызывается наблюдаемым объектом для уведомления наблюдателя.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteObserver:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретная реализация интерфейса IObserver.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "При этом наблюдаемому объекту не надо ничего знать о наблюдателе кроме того, что тот реализует метод Update(). С помощью отношения агрегации реализуется слабосвязанность обоих компонентов. Изменения в наблюдаемом объекте не виляют на наблюдателя и наоборот.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "В определенный момент наблюдатель может прекратить наблюдение. И после этого оба объекта - наблюдатель и наблюдаемый могут продолжать существовать в системе независимо друг от друга.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(IObserver), typeof(IObservable), typeof(StockInfo), typeof(Stock), typeof(Bank), typeof(Broker) }, richTextBoxClass);
        }

        private void Example()
        {
            stock = new Stock();
            brokers = new List<Broker>();
            banks = new List<Bank>();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNewBroker.Text != "")
            {
                brokers.Add(new Broker(textBoxNewBroker.Text, stock));
                listBoxBrokers.Items.Add(brokers.Last().Name);
            }
        }

        private void buttonAddBank_Click(object sender, EventArgs e)
        {
            if (textBoxNewBank.Text != "")
            {
                banks.Add(new Bank(textBoxNewBank.Text, stock));
                listBoxBanks.Items.Add(banks.Last().Name);
            }
        }

        private void buttonStopTrade_Click(object sender, EventArgs e)
        {
            if (listBoxBrokers.SelectedIndex > -1)
            {
                brokers[listBoxBrokers.SelectedIndex].StopTrade();
            }
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            richTextBoxResult.AppendText(stock.Market());
            richTextBoxResult.AppendText("-------------------------------------------------\n");
        }
    }
}
