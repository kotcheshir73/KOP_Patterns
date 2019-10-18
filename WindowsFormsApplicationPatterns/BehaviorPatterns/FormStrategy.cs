using ClassLibraryStrategy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormStrategy : Form
    {
        IMovable car;

        public FormStrategy()
        {
            InitializeComponent();
        }

        private void FormStrategy_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн Стратегия (Strategy) представляет шаблон проектирования, который определяет набор алгоритмов, инкапсулирует каждый из них и обеспечивает их взаимозаменяемость. В зависимости от ситуации мы можем легко заменить один используемый алгоритм другим. При этом замена алгоритма происходит независимо от объекта, который использует данный алгоритм.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Стратегия используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда есть несколько родственных классов, которые отличаются поведением. Можно задать один основной класс, а разные варианты поведения вынести в отдельные классы и при необходимости их применять.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда необходимо обеспечить выбор из нескольких вариантов алгоритмов, которые можно легко менять в зависимости от условий.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда необходимо менять поведение объектов на стадии выполнения программы.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда класс, применяющий определенную функциональность, ничего не должен знать о ее реализации.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            
            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- IStrategy:");
            dp.InsertText(richTextBoxDescribe, false, false, " интерфейс, который определяет метод Algorithm(). Это общий интерфейс для всех реализующих его алгоритмов. Вместо интерфейса здесь также можно было бы использовать абстрактный класс.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteStrategy1 и ConcreteStrategy:");
            dp.InsertText(richTextBoxDescribe, false, false, " классы, которые реализуют интерфейс IStrategy, предоставляя свою версию метода Algorithm(). Подобных классов-реализаций может быть множество.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Context:");
            dp.InsertText(richTextBoxDescribe, false, false, " класс, который хранит ссылку на объект IStrategy и связан с интерфейсом IStrategy отношением агрегации.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "В данном случае объект IStrategy заключена в свойстве ContextStrategy, хотя также для нее можно было бы определить приватную переменную, а для динамической установки использовать специальный метод.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(IMovable), typeof(PetrolMove), typeof(ElectricMove), typeof(Car) }, richTextBoxClass);
        }

        private void Example()
        {
            var childs = (typeof(IMovable)).Assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IMovable)) && !t.IsAbstract).ToList();
            foreach (var child in childs)
            {
                comboBoxCars.Items.Add(child.Name);
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxCars.SelectedIndex > -1)
            {
                var childs = (typeof(IMovable)).Assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IMovable)) && !t.IsAbstract).ToList();
                car = (IMovable)((childs.SingleOrDefault(r => r.Name == comboBoxCars.Text)?.GetConstructor(new Type[] { }).Invoke(new object[] { })) ?? null);
            }
        }

        private void buttonFull_Click(object sender, EventArgs e)
        {
            if(car != null)
            {
                listBoxResult.Items.Add(car.FullBack());
            }
            else
            {
                listBoxResult.Items.Add("Машины то нет, что заправлять?");
            }
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (car != null)
            {
                listBoxResult.Items.Add(car.DriveTo());
            }
            else
            {
                listBoxResult.Items.Add("Машины то нет, на чем ехать?");
            }
        }
    }
}
