using ClassLibraryBridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace WindowsFormsApplicationPatterns
{
    public partial class FormBridge : Form
    {
        List<Programmer> progers;

        public FormBridge()
        {
            InitializeComponent();
        }

        private void FormBridge_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Мост (Bridge) - структурный шаблон проектирования, который позволяет отделить абстракцию от реализации таким образом, чтобы и абстракцию, и реализацию можно было изменять независимо друг от друга. Даже если мы отделим абстракцию от конкретных реализаций, то у нас все равно все наследуемые классы будут жестко привязаны к интерфейсу, определяемому в базовом абстрактном классе. Для преодоления жестких связей и служит паттерн Мост.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Мост используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда надо избежать постоянной привязки абстракции к реализации.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда наряду с реализацией надо изменять и абстракцию независимо друг от друга. То есть изменения в абстракции не должно привести к изменениям в реализации.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Общая реализация паттерна состоит в объявлении классов абстракций и классов реализаций в отдельных параллельных иерархиях классов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Abstraction:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет базовый интерфейс и хранит ссылку на объект Implementor. Выполнение операций в Abstraction делегируется методам объекта Implementor.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- RefinedAbstraction:");
            dp.InsertText(richTextBoxDescribe, false, false, " уточненная абстракция, наследуется от Abstraction и расширяет унаследованный интерфейс.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Implementor:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет базовый интерфейс для конкретных реализаций. Как правило, Implementor определяет только примитивные операции. Более сложные операции, которые базируются на примитивных, определяются в Abstraction.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteImplementorA и ConcreteImplementorB:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретные реализации, которые унаследованы от Implementor.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Client:");
            dp.InsertText(richTextBoxDescribe, false, false, " использует объекты Abstraction.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(ILanguage), typeof(CPPLanguage), typeof(CSharpLanguage), typeof(Programmer), typeof(FreelanceProgrammer), typeof(CorporateProgrammer) }, 
                richTextBoxClass);
        }

        private void Example()
        {
            progers = new List<Programmer>();

            var childsLang = (typeof(ILanguage)).Assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(ILanguage)) && !t.IsAbstract).ToList();
            foreach (var child in childsLang)
            {
                comboBoxLang.Items.Add(child.Name);
            }

            var childsProg = (typeof(Programmer)).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Programmer)) && !t.IsAbstract).ToList();
            foreach (var child in childsProg)
            {
                comboBoxProger.Items.Add(child.Name);
            }

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if(comboBoxLang.SelectedIndex > -1 && comboBoxProger.SelectedIndex > -1)
            {
                var childsLang = (typeof(ILanguage)).Assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(ILanguage)) && !t.IsAbstract).ToList();
                var lang = (ILanguage)((childsLang.SingleOrDefault(r => r.Name == comboBoxLang.Text)?.GetConstructor(new Type[] { }).Invoke(new object[] { })) ?? null);

                var childsProg = (typeof(Programmer)).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Programmer)) && !t.IsAbstract).ToList();
                var proger = (Programmer)((childsProg.SingleOrDefault(r => r.Name == comboBoxProger.Text)?.GetConstructor(new Type[] { typeof(ILanguage) }).Invoke(new object[] { lang  })) ?? null);

                progers.Add(proger);
                listBoxProgers.Items.Add("Программист " + progers.Count);
            }
        }

        private void buttonDoWork_Click(object sender, EventArgs e)
        {
            if(listBoxProgers.SelectedIndex > -1)
            {
                richTextBoxResult.AppendText(progers[listBoxProgers.SelectedIndex].DoWork() + "\n");
                richTextBoxResult.AppendText(progers[listBoxProgers.SelectedIndex].EarnMoney() + "\n");
            }
        }
    }
}
