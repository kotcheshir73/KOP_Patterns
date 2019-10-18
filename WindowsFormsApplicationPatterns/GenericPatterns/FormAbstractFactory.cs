using ClassLibraryAbstractFactory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormAbstractFactory : Form
    {
        Hero hero;

        public FormAbstractFactory()
        {
            InitializeComponent();
        }

        private void FormAbstractFactory_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн \"Абстрактная фабрика\" (Abstract Factory) предоставляет интерфейс для создания семейств взаимосвязанных объектов с определенными интерфейсами без указания конкретных типов данных объектов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Абстрактная фабрика используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда система не должна зависеть от способа создания и компоновки новых объектов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда создаваемые объекты должны использоваться вместе и являются взаимосвязанными.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");

            dp.InsertText(richTextBoxDescribe, true, false, "- AbstractProductA и AbstractProductB:");
            dp.InsertText(richTextBoxDescribe, false, false, " абстрактные классы, определяющие интерфейс для классов, объекты которых будут создаваться в программе.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ProductA1 / ProductA2 и ProductB1 / ProductB2:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретные классы, представляющие конкретную реализацию абстрактных классов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- AbstractFactory:");
            dp.InsertText(richTextBoxDescribe, false, false, " абстрактный класс фабрики, определяющий методы для создания объектов. Причем методы возвращают абстрактные продукты, а не их конкретные реализации.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteFactory1 и ConcreteFactory2:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретные классы фабрик, реализующие абстрактные методы базового класса и непосредственно определяют какие конкретные продукты использовать.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Client:");
            dp.InsertText(richTextBoxDescribe, false, false, " класс клиента, использующий класс фабрики для создания объектов. При этом он использует исключительно абстрактный класс фабрики AbstractFactory и абстрактные классы продуктов AbstractProductA и AbstractProductB и никак не зависит от их конкретных реализаций.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(Weapon), typeof(Arbalet), typeof(Sword), typeof(Movement), typeof(FlyMovement), typeof(RunMovement), typeof(HeroFactory),
            typeof(AngelFactory), typeof(VoinFactory), typeof(Hero)}, richTextBoxClass);
        }

        private void Example()
        {
            var childs = (typeof(HeroFactory)).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(HeroFactory)) && !t.IsAbstract).ToList();
            foreach (var child in childs)
            {
                comboBoxTypeHero.Items.Add(child.Name.Replace("Factory", ""));
            }
        }

        private void buttonCreateHero_Click(object sender, EventArgs e)
        {
            if(comboBoxTypeHero.SelectedIndex > -1)
            {
                var childs = (typeof(HeroFactory)).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(HeroFactory)) && !t.IsAbstract);
                var factory = (HeroFactory)((childs.SingleOrDefault(r => r.Name == comboBoxTypeHero.Text + "Factory")?.GetConstructor(new Type[] {  }).Invoke(new object[] {  })) ?? null);

                hero = new Hero(factory);

                listBoxEvents.Items.Add("Создали персонажа " + hero.getName());
            }
        }

        private void buttonHeroMove_Click(object sender, EventArgs e)
        {
            if(hero != null)
            {
                listBoxEvents.Items.Add("Персонаж " + hero.getName() + " " + hero.Move());
            }
        }

        private void buttonHeroHit_Click(object sender, EventArgs e)
        {
            if (hero != null)
            {
                listBoxEvents.Items.Add("Персонаж " + hero.getName() + " " + hero.Hit());
            }
        }
    }
}
