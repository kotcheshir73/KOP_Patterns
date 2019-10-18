using ClassLibraryComposite;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormComposite : Form
    {
        Directory root;

        public FormComposite()
        {
            InitializeComponent();
        }

        private void FormComposite_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн Компоновщик (Composite) объединяет группы объектов в древовидную структуру по принципу \"часть - целое\" и позволяет клиенту одинаково работать как с отдельными объектами, так и с группой объектов.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Образно реализацию паттерна можно представить в виде меню, которое имеет различные пункты. Эти пункты могут содержать подменю, в которых, в свою очередь, также имеются пункты. То есть пункт меню служит с одной стороны частью меню, а с другой стороны еще одним меню. В итоге мы однообразно можем работать как с пунктом меню, так и со всем меню в целом.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Компоновщик используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда объекты должны быть реализованы в виде иерархической древовидной структуры.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда клиенты единообразно должны управлять как целыми объектами, так и их составными частями. То есть целое и его части должны реализовать один и тот же интерфейс.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Component:");
            dp.InsertText(richTextBoxDescribe, false, false, " определяет интерфейс для всех компонентов в древовидной структуре.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Composite:");
            dp.InsertText(richTextBoxDescribe, false, false, " представляет компонент, который может содержать другие компоненты и реализует механизм для их добавления и удаления.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Leaf:");
            dp.InsertText(richTextBoxDescribe, false, false, " представляет отдельный компонент, который не может содержать другие компоненты.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Client:");
            dp.InsertText(richTextBoxDescribe, false, false, " клиент, который использует компоненты.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(Component), typeof(Directory), typeof(File) },  richTextBoxClass);
        }

        private void Example()
        {
            root = new Directory("Корень");
            ReloadTree();
        }

        private void ReloadTree()
        {
            richTextBoxFileSystem.Clear();
            richTextBoxFileSystem.AppendText(root.Print(0));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxNewName.Text == "")
            {
                MessageBox.Show("Введите название нового каталога");
                return;
            }
            if (textBoxParentName.Text == "")
            {
                MessageBox.Show("Введите название родительского каталога");
                return;
            }
            if(!root.CheckNewName(textBoxNewName.Text))
            {
                MessageBox.Show("Такое имя уже используется");
                return;
            }
            if (root.CheckNewName(textBoxParentName.Text))
            {
                MessageBox.Show("Нет такого родительского каталога");
                return;
            }
            Component comp = null;
            if(radioButtonDirectory.Checked)
            {
                comp = new Directory(textBoxNewName.Text);
            }
            else if(radioButtonFile.Checked)
            {
                comp = new File(textBoxNewName.Text);
            }
            root.Add(comp, textBoxParentName.Text);
            ReloadTree();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBoxRemoveName.Text == "")
            {
                MessageBox.Show("Введите название удаляемого каталога");
                return;
            }
            if (textBoxRemoveName.Text == root.Name)
            {
                MessageBox.Show("Корневой каталог удалять нельзя");
                return;
            }
            root.Remove(textBoxRemoveName.Text);
            ReloadTree();
        }
    }
}
