using ClassLibraryPrototype;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormPrototype : Form
    {
        List<IFigure> figures;

        public FormPrototype()
        {
            InitializeComponent();
        }

        private void FormPrototype_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн Прототип (Prototype) позволяет создавать объекты на основе уже ранее созданных объектов-прототипов. То есть по сути данный паттерн предлагает технику клонирования объектов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, true, false, "Прототип используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда конкретный тип создаваемого объекта должен определяться динамически во время выполнения.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда нежелательно создание отдельной иерархии классов фабрик для создания объектов-продуктов из параллельной иерархии классов (как это делается, например, при использовании паттерна Абстрактная фабрика).");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда клонирование объекта является более предпочтительным вариантом нежели его создание и инициализация с помощью конструктора. Особенно когда известно, что объект может принимать небольшое ограниченное число возможных состояний.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Prototype:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет интерфейс для клонирования самого себя, который, как правило, представляет метод Clone().");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcretePrototype1 и ConcretePrototype2:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретные реализации прототипа. Реализуют метод Clone().");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Client:");
            dp.InsertText(richTextBoxDescribe, false, false, " создает объекты прототипов с помощью метода Clone().");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, false, false, "Есть стандартный интерфейс IClonable, в котором есть метод Clone(). Есть два способа дублированния: частичное и полное копирование. При частичном объекты, входящие в копируемый не дублируются и в новом обекте ссылочные поля будут ссылаться на теже объекты, что и исходный. При полном - создаются дубликаты и ссылочных типов, входящих в дублируемый объект.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(IFigure), typeof(ClassLibraryPrototype.Rectangle), typeof(Circle) }, richTextBoxClass);
        }

        private void Example()
        {
            figures = new List<IFigure>();
        }

        private void buttonCreateRectangle_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            figures.Add(new Rectangle(rnd.Next(10, 30), rnd.Next(10, 30)));
            listBoxResult.Items.Add(figures[figures.Count - 1].GetInfo());
        }

        private void buttonCreateCircle_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            figures.Add(new Circle(rnd.Next(10, 30)));
            listBoxResult.Items.Add(figures[figures.Count - 1].GetInfo());
        }

        private void buttonCreateClone_Click(object sender, EventArgs e)
        {
            if (listBoxResult.SelectedIndex > -1)
            {
                figures.Add(figures[listBoxResult.SelectedIndex].Clone());
                listBoxResult.Items.Add(figures[figures.Count - 1].GetInfo());
            }
        }
    }
}
