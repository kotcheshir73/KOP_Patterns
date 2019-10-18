using ClassLibraryVisitor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormVisitor : Form
    {
        Bank bank;

        public FormVisitor()
        {
            InitializeComponent();
        }

        private void FormVisitor_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн Посетитель (Visitor) позволяет определить операцию для объектов других классов без изменения этих классов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "При использовании паттерна Посетитель определяются две иерархии классов: одна для элементов, для которых надо определить новую операцию, и вторая иерархия для посетителей, описывающих данную операцию.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Посетитель используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда имеется много объектов разнородных классов с разными интерфейсами, и требуется выполнить ряд операций над каждым из этих объектов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда классам необходимо добавить одинаковый набор операций без изменения этих классов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда часто добавляются новые операции к классам, при этом общая структура классов стабильна и практически не изменяется.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Visitor:");
            dp.InsertText(richTextBoxDescribe, false, false, " интерфейс посетителя, который определяет метод Visit() для каждого объекта Element.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteVisitor1 / ConcreteVisitor2:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретные классы посетителей, реализуют интерфейс, определенный в Visitor.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Element:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет метод Accept(), в котором в качестве параметра принимается объект Visitor.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ElementA / ElementB:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретные элементы, которые реализуют метод Accept().");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ObjectStructure:");
            dp.InsertText(richTextBoxDescribe, false, false, " некоторая структура, которая хранит объекты Element и предоставляет к ним доступ. Это могут быть и простые списки, и сложные составные структуры в виде деревьев.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Данная техника еще называется двойной диспетчеризацией (double dispatch), когда выполнение операции зависит от имени запроса и двух типов получателей (объект Visitor и объект Element).");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(IVisitor), typeof(HtmlVisitor), typeof(XmlVisitor), typeof(IAccount), typeof(Person), typeof(Company), typeof(Bank) }, richTextBoxClass);
        }

        private void Example()
        {
            bank = new Bank();

            var childsClients = (typeof(IAccount)).Assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IAccount)) && !t.IsAbstract).ToList();
            foreach (var child in childsClients)
            {
                comboBoxClientType.Items.Add(child.Name);
            }

            var childsTypesLoads = (typeof(IVisitor)).Assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IVisitor)) && !t.IsAbstract).ToList();
            foreach (var child in childsTypesLoads)
            {
                comboBoxTypeLoad.Items.Add(child.Name);
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (comboBoxClientType.SelectedIndex > -1 && textBoxName.Text != "" && textBoxNumber.Text != "")
            {
                switch (comboBoxClientType.Text)
                {
                    case "Person":
                        var per = new Person();
                        per.Name = textBoxName.Text;
                        per.Number = textBoxNumber.Text;

                        bank.Add(per);
                        break;
                    case "Company":
                        var com = new Company();
                        com.Name = textBoxName.Text;
                        com.Number = textBoxNumber.Text;
                        com.RegNumber = textBoxRegNumber.Text;

                        bank.Add(com);
                        break;
                }
                textBoxName.Text = "";
                textBoxNumber.Text = "";
                textBoxRegNumber.Text = "";
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Clear();
            if (comboBoxTypeLoad.SelectedIndex > -1)
            {
                var childsTypesLoads = (typeof(IVisitor)).Assembly.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IVisitor)) && !t.IsAbstract).ToList();
                var visitor = (IVisitor)((childsTypesLoads.SingleOrDefault(r => r.Name == comboBoxTypeLoad.Text)?.GetConstructor(new Type[] { }).Invoke(new object[] { })) ?? null);

                richTextBoxResult.AppendText(bank.Accept(visitor));
            }
        }
    }
}
