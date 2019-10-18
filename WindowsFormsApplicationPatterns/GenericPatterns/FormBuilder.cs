using ClassLibraryBuilder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormBuilder : Form
    {
        Baker baker;

        public FormBuilder()
        {
            InitializeComponent();
        }

        private void FormBuilder_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();
            dp.InsertText(richTextBoxDescribe, false, false, "Строитель (Builder) - шаблон проектирования, который инкапсулирует создание объекта и позволяет разделить его на различные этапы.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, true, false, "Строитель используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда процесс создания нового объекта не должен зависеть от того, из каких частей этот объект состоит и как эти части связаны между собой.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда необходимо обеспечить получение различных вариаций объекта в процессе его создания.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Product:");
            dp.InsertText(richTextBoxDescribe, false, false, " представляет объект, который должен быть создан. В данном случае все части объекта заключены в списке parts.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Builder:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет интерфейс для создания различных частей объекта Product.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteBuilder:");
            dp.InsertText(richTextBoxDescribe, false, false, " конкретная реализация Buildera. Создает объект Product и определяет интерфейс для доступа к нему.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Director:");
            dp.InsertText(richTextBoxDescribe, false, false, " распорядитель - создает объект, используя объекты Builder.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(Salt), typeof(Additives), typeof(Flour), typeof(Bread), typeof(BreadBuilder), typeof(RyeBreadBuilder),
                typeof(WheatBreadBuilder), typeof(Baker) }, richTextBoxClass);
        }

        private void Example()
        {
            baker = new Baker();
            var childs = (typeof(BreadBuilder)).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(BreadBuilder)) && !t.IsAbstract).ToList();
            foreach (var child in childs)
            {
                comboBoxTypeBeard.Items.Add(child.Name.Replace("Builder", ""));
            }
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeBeard.SelectedIndex > -1)
            {
                var childs = (typeof(BreadBuilder)).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(BreadBuilder)) && !t.IsAbstract);
                var builder = (BreadBuilder)((childs.SingleOrDefault(r => r.Name == comboBoxTypeBeard.Text + "Builder")?.GetConstructor(new Type[] { }).Invoke(new object[] { })) ?? null);

                var beard = baker.Make(builder);

                richTextBoxResult.AppendText(beard.ToString() + "\n");
            }
        }
    }
}
