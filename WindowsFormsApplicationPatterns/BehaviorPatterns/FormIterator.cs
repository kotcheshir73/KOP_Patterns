using ClassLibraryIterator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormIterator : Form
    {
        Reader reader;

        public FormIterator()
        {
            InitializeComponent();
        }

        private void FormIterator_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн Итератор (Iterator) предоставляет абстрактный интерфейс для последовательного доступа ко всем элементам составного объекта без раскрытия его внутренней структуры.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, false, false, "Пара интерфейсов IEnumerable / IEnumerator обеспечивают прохождение всех известных коллекций через цикл foreach. Интерфейс IEnumerator определяет функционал для перебора внутренних объектов в контейнере. А интерфейс IEnumerable использует IEnumerator для получения итератора для конкретного типа объекта.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, true, false, "Итератор используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда необходимо осуществить обход объекта без раскрытия его внутренней структуры.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда имеется набор составных объектов, и надо обеспечить единый интерфейс для их перебора.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда необходимо предоставить несколько альтернативных вариантов перебора одного и того же объекта.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Iterator:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет интерфейс для обхода составных объектов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Aggregate:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет интерфейс для создания объекта-итератора.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteIterator:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретная реализация итератора для обхода объекта Aggregate. Для фиксации индекса текущего перебираемого элемента использует целочисленную переменную _current.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteAggregate:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретная реализация Aggregate. Хранит элементы, которые надо будет перебирать.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Client:");
            dp.InsertText(richTextBoxDescribe, false, false, " использует объект Aggregate и итератор для его обхода.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(Book), typeof(IBookIterator), typeof(IBookNumerable), typeof(LibraryNumerator), typeof(Library), typeof(Reader) }, richTextBoxClass);
        }

        private void Example()
        {
            reader = new Reader(new Library());
        }

        private void buttonSeeNext_Click(object sender, EventArgs e)
        {
            textBoxBook.Text = reader.SeeNextBook();
        }
    }
}
