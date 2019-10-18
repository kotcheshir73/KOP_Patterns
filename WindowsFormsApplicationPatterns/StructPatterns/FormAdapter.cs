using ClassLibraryAdapter;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormAdapter : Form
    {
        Traveler trav;

        InterfaceCar car;

        public FormAdapter()
        {
            InitializeComponent();
        }

        private void FormAdapter_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн Адаптер (Adapter) предназначен для преобразования интерфейса одного класса в интерфейс другого. Благодаря реализации данного паттерна мы можем использовать вместе классы с несовместимыми интерфейсами.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Адаптер используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда необходимо использовать имеющийся класс, но его интерфейс не соответствует потребностям.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда надо использовать уже существующий класс совместно с другими классами, интерфейсы которых не совместимы.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Target:");
            dp.InsertText(richTextBoxDescribe, false, false, " представляет объекты, которые используются клиентом (лучше, если есть интерфейс, от которого он наследуется).");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Client:");
            dp.InsertText(richTextBoxDescribe, false, false, " использует объекты Target (либо интерфейс, к которому принадлежит Target) для реализации своих задач.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Adaptee:");
            dp.InsertText(richTextBoxDescribe, false, false, " представляет адаптируемый класс, который мы хотели бы использовать у клиента вместо объектов Target.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Adapter:");
            dp.InsertText(richTextBoxDescribe, false, false, " собственно адаптер (наследуется от того же интерфеса, что и Target), который позволяет работать с объектами Adaptee как с объектами Target.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "То есть клиент ничего не знает об Adaptee, он знает и использует только объекты Target. И благодаря адаптеру мы можем на клиенте использовать объекты Adaptee как Target.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(InterfaceCar), typeof(Taxi), typeof(InterfaceAnimal), typeof(Elifant), typeof(Adapter), typeof(Traveler) }, richTextBoxClass);
        }

        private void Example()
        {
            trav = new Traveler();
            if (car != null)
            {
                labelTraveler.Text = trav.Drive(car);
            }
            else
            {
                labelTraveler.Text = "Неизвестно";
            }
        }

        private void radioButtonSity_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSity.Checked)
            {
                car = new Taxi();
                Example();
            }
        }

        private void radioButtonVillage_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVillage.Checked)
            {
                car = null;
                Example();
            }
        }

        private void radioButtonCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCountry.Checked)
            {
                car = null;
                Example();
            }
        }

        private void radioButtonJungle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonJungle.Checked)
            {
                car = new Adapter(new Elifant());
                Example();
            }
        }
    }
}
