using ClassLibraryInterpreter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormInterpreter : Form
    {
        Context context;

        public FormInterpreter()
        {
            InitializeComponent();
        }

        private void FormInterpreter_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн Интерпретатор (Interpreter) определяет представление грамматики для заданного языка и интерпретатор предложений этого языка. Как правило, данный шаблон проектирования применяется для часто повторяющихся операций.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- AbstractExpression:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет интерфейс выражения, объявляет метод Interpret().");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- TerminalExpression:");
            dp.InsertText(richTextBoxDescribe, false, false, " терминальное выражение, реализует метод Interpret() для терминальных символов грамматики. Для каждого символа грамматики создается свой объект TerminalExpression.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- NonterminalExpression:");
            dp.InsertText(richTextBoxDescribe, false, false, " нетерминальное выражение, представляет правило грамматики. Для каждого отдельного правила грамматики создается свой объект NonterminalExpression.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Context:");
            dp.InsertText(richTextBoxDescribe, false, false, " содержит общую для интерпретатора информацию. Может использоваться объектами терминальных и нетерминальных выражений для сохранения состояния операций и последующего доступа к сохраненному состоянию.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Client:");
            dp.InsertText(richTextBoxDescribe, false, false, " строит предложения языка с данной грамматикой в виде абстрактного синтаксического дерева, узлами которого являются объекты TerminalExpression и NonterminalExpression.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Методы Interpret в нетерминальных выражениях позволяют реализовать правила грамматики. При этом мы легко может добавить новые правила грамматики, определив новые объекты NonterminalExpression со своей реализацией метода Interpret. Однако данный паттерн подходит только для тех случаев, когда правила грамматики относительно простые. В более сложных случаях следует выбирать другие способы проектирования приложения.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(Context), typeof(IExpression), typeof(NumberExpression), typeof(AddExpression), typeof(SubtractExpression) }, richTextBoxClass);
        }

        private void Example()
        {
            context = new Context();
            var childs = (typeof(IExpression)).Assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IExpression)) && !t.IsAbstract).ToList();
            foreach (var child in childs)
            {
                if (!child.Name.Contains("Number"))
                {
                    comboBoxExpression.Items.Add(child.Name);
                }
            }
        }

        private void buttonSaveNumber_Click(object sender, EventArgs e)
        {
            if (textBoxNumberName.Text != "" && textBoxNumberValue.Text != null)
            {
                int val = 0;
                if (int.TryParse(textBoxNumberValue.Text, out val))
                {
                    context.SetVariable(textBoxNumberName.Text, val);
                }
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (comboBoxExpression.SelectedIndex > -1 && textBoxLeftNumber.Text != "" && textBoxRightNumber.Text != "")
            {
                IExpression expre = null;
                if (comboBoxExpression.Text.Contains("Add"))
                {
                    expre = new AddExpression(new NumberExpression(textBoxLeftNumber.Text), new NumberExpression(textBoxRightNumber.Text));
                }
                else if (comboBoxExpression.Text.Contains("Sub"))
                {
                    expre = new SubtractExpression(new NumberExpression(textBoxLeftNumber.Text), new NumberExpression(textBoxRightNumber.Text));
                }
                if (expre != null)
                {
                    listBoxResult.Items.Add(expre.Interpret(context).ToString());
                }
            }
        }
    }
}
