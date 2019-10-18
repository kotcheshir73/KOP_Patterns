using ClassLibraryTemplateMethod;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormTemplateMethod : Form
    {
        public FormTemplateMethod()
        {
            InitializeComponent();
        }

        private void FormTemplateMethod_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Шаблонный метод (Template Method) определяет общий алгоритм поведения подклассов, позволяя им переопределить отдельные шаги этого алгоритма без изменения его структуры.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Шаблонный метод используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда планируется, что в будущем подклассы должны будут переопределять различные этапы алгоритма без изменения его структуры.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда в классах, реализующим схожий алгоритм, происходит дублирование кода. Вынесение общего кода в шаблонный метод уменьшит его дублирование в подклассах.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- AbstractClass:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет шаблонный метод TemplateMethod(), который реализует алгоритм. Алгоритм может состоять из последовательности вызовов других методов, часть из которых может быть абстрактными и должны быть переопределены в классах-наследниках. При этом сам метод TemplateMethod(), представляющий структуру алгоритма, переопределяться не должен.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteClass:");
            dp.InsertText(richTextBoxDescribe, false, false, " подкласс, который может переопределять различные методы родительского класса.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(Education), typeof(School), typeof(University) }, richTextBoxClass);
        }

        private void Example()
        {
            var childs = (typeof(Education)).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Education)) && !t.IsAbstract).ToList();
            foreach (var child in childs)
            {
                comboBoxLearnTypes.Items.Add(child.Name);
            }
        }

        private void buttonSeeLearn_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Clear();
            if (comboBoxLearnTypes.SelectedIndex > -1)
            {
                var childs = (typeof(Education)).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Education)) && !t.IsAbstract).ToList();
                var ed = (Education)((childs.SingleOrDefault(r => r.Name == comboBoxLearnTypes.Text)?.GetConstructor(new Type[] { }).Invoke(new object[] { })) ?? null);

                if(ed != null)
                {
                    richTextBoxResult.AppendText(ed.Learn());
                }
            }
        }
    }
}
