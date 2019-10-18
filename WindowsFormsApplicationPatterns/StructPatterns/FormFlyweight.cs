using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryFlyweight;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormFlyweight : Form
    {
        HouseFactory houseFactory;
        public FormFlyweight()
        {
            InitializeComponent();
        }

        private void FormFlyweight_Load(object sender, EventArgs e)
        {

            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн Приспособленец (Flyweight) - структурный шаблон проектирования, который позволяет использовать разделяемые объекты сразу в нескольких контекстах. Данный паттерн используется преимущественно для оптимизации работы с памятью.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Приспособленец используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда приложение использует большое количество однообразных объектов, из-за чего происходит выделение большого количества памяти.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда часть состояния объекта, которое является изменяемым, можно вынести во вне. Вынесение внешнего состояния позволяет заменить множество объектов небольшой группой общих разделяемых объектов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Ключевым моментом здесь является разделение состояния на внутренне и внешнее. Внутреннее состояние не зависит от контекста. Так как внутреннее состояние не зависит от контекста, то оно может быть разделяемым и поэтому выносится в разделяемые объекты.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Внешнее состояние зависит от контекста, является изменчивым. В применении к символам внешнее состояние может представлять положение символа на странице. То есть код символа может быть использован многими символами, тогда как положение на странице будет для каждого символа индивидуально.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "При создании приспособленца внешнее состояние выносится. В приспособленце остается только внутреннее состояние. о есть в примере с символами приспособленец будет хранить код символа. То есть в примере с символами приспособленец будет хранить код символа.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Flyweight:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет интерфейс, через который приспособленцы-разделяемые объекты могут получать внешнее состояние или воздействовать на него.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteFlyweight:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретный класс разделяемого приспособленца. Реализует интерфейс, объявленный в типе Flyweight, и при необходимости добавляет внутреннее состояние. Причем любое сохраняемое им состояние должно быть внутренним, не зависящим от контекста.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- UnsharedConcreteFlyweight:");
            dp.InsertText(richTextBoxDescribe, false, false, " еще одна конкретная реализация интерфейса, определенного в типе Flyweight, только теперь объекты этого класса являются неразделяемыми.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- FlyweightFactory:");
            dp.InsertText(richTextBoxDescribe, false, false, " фабрика приспособленцев - создает объекты разделяемых приспособленцев. Так как приспособленцы разделяются, то клиент не должен создавать их напрямую. Все созданные объекты хранятся в пуле. В примере выше для определения пула используется объект Hashtable, но это не обязательно. Можно применять и другие классы коллекций. Однако в зависимости от сложности структуры, хранящей разделяемые объекты, особенно если у нас большое количество приспособленцев, то может увеличиваться время на поиск нужного приспособленца - наверное это один из немногих недостатков данного паттерна. Если запрошенного приспособленца не оказалось в пуле, то фабрика создает его.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Client:");
            dp.InsertText(richTextBoxDescribe, false, false, " использует объекты приспособленцев. Может хранить внешнее состояние и передавать его в качестве аргументов в методы приспособленцев.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(House), typeof(PanelHouse), typeof(BrickHouse), typeof(HouseFactory) }, richTextBoxClass);
        }

        private void Example()
        {
            houseFactory = new HouseFactory();
            var childs = (typeof(House)).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(House)) && !t.IsAbstract).ToList();
            foreach (var child in childs)
            {
                comboBoxTypeHouse.Items.Add(child.Name.Replace("House", ""));
            }
        }

        private void buttonSetHouse_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeHouse.SelectedIndex > -1)
            {
                Random rnd = new Random();
                House panelHouse = houseFactory.GetHouse(comboBoxTypeHouse.Text);
                if (panelHouse != null)
                {
                    listBoxResult.Items.Add(panelHouse.Build(rnd.Next(10, 100), rnd.Next(10, 100)));
                }
            }
        }
    }
}
