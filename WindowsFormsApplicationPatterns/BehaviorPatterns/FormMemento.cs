using ClassLibraryMemento;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormMemento : Form
    {
        Hero hero;

        GameHistory game;

        public FormMemento()
        {
            InitializeComponent();
        }

        private void FormMemento_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн Хранитель (Memento) позволяет выносить внутреннее состояние объекта за его пределы для последующего возможного восстановления объекта без нарушения принципа инкапсуляции.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, true, false, "Хранитель используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда нужно охранить его состояние объекта для возможного последующего восстановления.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда сохранение состояния должно проходить без нарушения принципа инкапсуляции.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "То есть ключевыми понятиями для данного паттерна являются сохранение внутреннего состояния и инкапсуляция, и важно соблюсти баланс между ними. Ведь, как правило, если мы не нарушаем инкапсуляцию, то состояние объекта хранится в объекте в приватных переменных. И не всегда для доступа к этим переменным есть методы или свойства с сеттерами и геттерами.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Memento:");
            dp.InsertText(richTextBoxDescribe, false, false, " хранитель, который сохраняет состояние объекта Originator и предоставляет полный доступ только этому объекту Originator.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Originator:");
            dp.InsertText(richTextBoxDescribe, false, false, " создает объект хранителя для сохранения своего состояния.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Caretaker:");
            dp.InsertText(richTextBoxDescribe, false, false, " выполняет только функцию хранения объекта Memento, в то же время у него нет полного доступа к хранителю и никаких других операций над хранителем, кроме собственно сохранения, он не производит.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Использование паттерна Memento дает нам следующие преимущества:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Уменьшение связанности системы.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Сохранение инкапсуляции информации.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Определение простого интерфейса для сохранения и восстановления состояния.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "В то же время мы можем столкнуться с недостатками, в частности, если требуется сохранение большого объема информации, то возрастут издержки на хранение всего объема состояния.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(Hero), typeof(HeroMemento), typeof(GameHistory) }, richTextBoxClass);
        }

        private void Example()
        {
            hero = new Hero();
            game = new GameHistory();
            game.SaveState(hero.SaveState());
        }

        private void buttonHeroStep_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            switch (rnd.Next(0, 10))
            {
                case 1:
                case 4:
                    listBoxSteps.Items.Add(hero.AddAmmo(rnd.Next(5, 15)));
                    break;
                case 3:
                case 5:
                    listBoxSteps.Items.Add(hero.HeroDie());
                    break;
                default:
                    listBoxSteps.Items.Add(hero.Shoot());
                    break;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            game.SaveState(hero.SaveState());
            listBoxSteps.Items.Add("Сохранение");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            listBoxSteps.Items.Add(hero.RestoreState(game.GetLastState()));
        }
    }
}
