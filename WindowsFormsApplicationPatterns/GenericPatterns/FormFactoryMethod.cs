using ClassLibraryFactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormFactoryMethod : Form
    {
        List<Developer> developers;

        int count;

        public FormFactoryMethod()
        {
            InitializeComponent();
        }

        private void FormFactoryMethod_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Фабричный метод (Factory Method) - это паттерн, который определяет интерфейс для создания объектов некоторого класса, но непосредственное решение о том, объект какого класса создавать происходит в подклассах. То есть паттерн предполагает, что базовый класс делегирует создание объектов классам-наследникам.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, true, false, "Фабричный метод используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда заранее неизвестно, объекты каких типов необходимо создавать.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда система должна быть независимой от процесса создания новых объектов и расширяемой: в нее можно легко вводить новые классы, объекты которых система должна создавать.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда создание новых объектов необходимо делегировать из базового класса классам наследникам.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Product:");
            dp.InsertText(richTextBoxDescribe, false, false, " абстрактный класс, определяющий интерфейс класса, объекты которого надо создавать.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteProductA и ConcreteProductB:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретные классы, представляющие реализацию класса Product. Таких классов может быть множество.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Creator:");
            dp.InsertText(richTextBoxDescribe, false, false, " абстрактный класс, определяющий абстрактный фабричный метод FactoryMethod(), который возвращает объект Product.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteCreatorA и ConcreteCreatorB:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретные классы-наследники класса Creator, определяющие свою реализацию метода FactoryMethod(). Причем метод FactoryMethod() каждого отдельного класса-создателя возвращает определенный конкретный тип продукта. Для каждого конкретного класса продукта определяется свой конкретный класс создателя.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Таким образом, класс Creator делегирует создание объекта Product своим наследникам. А классы ConcreteCreatorA и ConcreteCreatorB могут самостоятельно выбирать какой конкретный тип продукта им создавать.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(House), typeof(PanelHouse), typeof(WoodHouse), typeof(Developer), typeof(PanelDeveloper), typeof(WoodDeveloper) },
                richTextBoxClass);
        }

        private void Example()
        {
            developers = new List<Developer>();
            count = 0;
            var childs = (typeof(Developer)).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Developer)) && !t.IsAbstract).ToList();
            foreach (var child in childs)
            {
                comboBoxTypeDeveloper.Items.Add(child.Name);
            }
        }

        private void buttonCreateDeveloper_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeDeveloper.SelectedIndex > -1)
            {
                var childs = (typeof(Developer)).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Developer)) && !t.IsAbstract);
                var developer = (Developer)((childs.SingleOrDefault(r => r.Name == comboBoxTypeDeveloper.Text)?.GetConstructor(new Type[] { typeof(string) }).Invoke(new object[] { "Developer " + count })) ?? null);

                developers.Add(developer);
                listBoxDevelopers.Items.Add(developer.Name);
                count++;
            }
        }

        private void buttonBuildHouse_Click(object sender, EventArgs e)
        {
            if (listBoxDevelopers.SelectedIndex > -1)
            {
                var house = developers[listBoxDevelopers.SelectedIndex].Create();

                listBoxResult.Items.Add(developers[listBoxDevelopers.SelectedIndex].Name + " " + house.getTypeHouse());
            }
        }
    }
}
