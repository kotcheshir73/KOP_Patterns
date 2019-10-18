using ClassLibraryDecorator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormDecorator : Form
    {
        public FormDecorator()
        {
            InitializeComponent();
        }

        private void FormDecorator_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Декоратор (Decorator) представляет структурный шаблон проектирования, который позволяет динамически подключать к объекту дополнительную функциональность. Для определения нового функционала в классах нередко используется наследование. Декораторы же предоставляет наследованию более гибкую альтернативу, поскольку позволяют динамически в процессе выполнения определять новые возможности у объектов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Декоратор используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда надо динамически добавлять к объекту новые функциональные возможности. При этом данные возможности могут быть сняты с объекта.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда применение наследования неприемлемо. Например, если нам надо определить множество различных функциональностей и для каждой функциональности наследовать отдельный класс, то структура классов может очень сильно разрастись. Еще больше она может разрастись, если нам необходимо создать классы, реализующие все возможные сочетания добавляемых функциональностей.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            
            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Component:");
            dp.InsertText(richTextBoxDescribe, false, false, " абстрактный класс, который определяет интерфейс для наследуемых объектов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteComponent:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретная реализация компонента, в которую с помощью декоратора добавляется новая функциональность.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Decorator:");
            dp.InsertText(richTextBoxDescribe, false, false, " собственно декоратор, реализуется в виде абстрактного класса и имеет тот же базовый класс, что и декорируемые объекты. Поэтому базовый класс Component должен быть по возможности легким и определять только базовый интерфейс.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "Класс декоратора также хранит ссылку на декорируемый объект в виде объекта базового класса Component и реализует связь с базовым классом как через наследование, так и через отношение агрегации.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteDecoratorA и ConcreteDecoratorB:");
            dp.InsertText(richTextBoxDescribe, false, false, " классы, которые представляют дополнительные функциональности, которыми должен быть расширен объект ConcreteComponent. ConcreteDecoratorA добавляет новое свойство NewState, а ConcreteDecoratorB добавляет новый метод NewMethod(). Подобных классов может быть множество. И они не обязательно должны что-то добавлять: свойства, методы. Они просто могут переопределять уже имеющийся функционал.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(Pizza), typeof(ItalianPizza), typeof(AmericanPizza), typeof(PizzaDecorator), typeof(PeperonniPizza), typeof(CheesePizza) }, richTextBoxClass);
        }

        private void Example()
        {
            var childs = (typeof(PizzaDecorator)).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(PizzaDecorator)) && !t.IsAbstract).ToList();
            int count = 0;
            foreach (var child in childs)
            {
                CheckBox check = new CheckBox();
                check.AutoSize = true;
                check.Location = new System.Drawing.Point(10, 20 + count * 30);
                check.Name = "checkBoxDecoratorElement" + count;
                check.Size = new System.Drawing.Size(80, 17);
                check.TabIndex = 0;
                check.Text = child.Name;
                check.UseVisualStyleBackColor = true;
                groupBoxDecorator.Controls.Add(check);
                count++;
            }
        }

        private void buttonGetPizza_Click(object sender, EventArgs e)
        {
            Pizza pizza = null;
            if (radioButtonItalian.Checked)
            {
                pizza = new ItalianPizza();
            }
            else if (radioButtonAmerican.Checked)
            {
                pizza = new AmericanPizza();
            }
            var childs = (typeof(PizzaDecorator)).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(PizzaDecorator)) && !t.IsAbstract);
            foreach (var contrl in groupBoxDecorator.Controls)
            {
                if (contrl is CheckBox)
                {
                    if ((contrl as CheckBox).Checked)
                    {
                        //x?.y — доступ к членам, определяемый условием NULL.  Возвращает значение NULL, если левый операнд имеет значение NULL.
                        //x?? y — возвращает x, если значение отличается от null; в противном случае возвращает y.
                        pizza = (Pizza)((childs.SingleOrDefault(r => r.Name == (contrl as CheckBox).Text)?.GetConstructor(new Type[] { typeof(Pizza) }).Invoke(new object[] { pizza })) ?? pizza);
                    }
                }
            }
            labelPizza.Text = "Пицца: " + pizza.Name;
            labelCost.Text = "Стоимость: " + pizza.GetCost();
        }
    }
}
