using ClassLibraryState;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormState : Form
    {
        Water water;

        public FormState()
        {
            InitializeComponent();
        }

        private void FormState_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Состояние (State) - шаблон проектирования, который позволяет объекту изменять свое поведение в зависимости от внутреннего состояния.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Состояние используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда поведение объекта должно зависеть от его состояния и может изменяться динамически во время выполнения.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда в коде методов объекта используются многочисленные условные конструкции, выбор которых зависит от текущего состояния объекта.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- State:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет интерфейс состояния.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- StateA и StateB:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретные реализации состояний.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Context:");
            dp.InsertText(richTextBoxDescribe, false, false, " представляет объект, поведение которого должно динамически изменяться в соответствии с состоянием. Выполнение же конкретных действий делегируется объекту состояния.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Реализация паттерна Состояние позволяет вынести поведение, зависящее от текущего состояния объекта, в отдельные классы, и избежать перегруженности методов объекта условными конструкциями, как if..else или switch. Кроме того, при необходимости мы можем ввести в систему новые классы состояний, а имеющиеся классы состояний использовать в других объектах.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(IWaterState), typeof(SolidWaterState), typeof(LiquidWaterState), typeof(GasWaterState), typeof(Water) }, richTextBoxClass);
        }

        private void Example()
        {
            water = new Water(new LiquidWaterState());
            listBoxWaterState.Items.Add("Жидкое состояние");
        }

        private void buttonHeat_Click(object sender, EventArgs e)
        {
            listBoxWaterState.Items.Add(water.Heat());
        }

        private void buttonFrost_Click(object sender, EventArgs e)
        {
            listBoxWaterState.Items.Add(water.Frost());
        }
    }
}
