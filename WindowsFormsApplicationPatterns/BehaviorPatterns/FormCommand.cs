using ClassLibraryCommand;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplicationPatterns
{
    public partial class FormCommand : Form
    {
        public FormCommand()
        {
            InitializeComponent();
        }

        private void FormCommand_Load(object sender, EventArgs e)
        {
            Describe();

            Classes();

            Example();
        }

        private void Describe()
        {
            SetTextInRichTextBox dp = new SetTextInRichTextBox();

            dp.InsertText(richTextBoxDescribe, false, false, "Паттерн Команда (Command) позволяет инкапсулировать запрос на выполнение определенного действия в виде отдельного объекта. Этот объект запроса на действие и называется командой. При этом объекты, инициирующие запросы на выполнение действия, отделяются от объектов, которые выполняют это действие.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, false, false, "Команды могут использовать параметры, которые передают ассоциированную с командой информацию. Кроме того, команды могут ставиться в очередь и также могут быть отменены.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");
            dp.InsertText(richTextBoxDescribe, true, false, "Команда используется:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда надо передавать в качестве параметров определенные действия, вызываемые в ответ на другие действия. То есть когда необходимы функции обратного действия в ответ на определенные действия.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда необходимо обеспечить выполнение очереди запросов, а также их возможную отмену.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, false, false, "- Когда надо поддерживать логгирование изменений в результате запросов. Использование логов может помочь восстановить состояние системы - для этого необходимо будет использовать последовательность запротоколированных команд.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, true, false, "Участники:");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Command:");
            dp.InsertText(richTextBoxDescribe, false, false, " интерфейс, представляющий команду. Обычно определяет метод Execute() для выполнения действия, а также нередко включает метод Undo(), реализация которого должна заключаться в отмене действия команды.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- ConcreteCommand:");
            dp.InsertText(richTextBoxDescribe, false, false, "  конкретная реализация команды, реализует метод Execute(), в котором вызывается определенный метод, определенный в классе Receiver.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Receiver:");
            dp.InsertText(richTextBoxDescribe, false, false, " получатель команды. Определяет действия, которые должны выполняться в результате запроса.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Invoker:");
            dp.InsertText(richTextBoxDescribe, false, false, " инициатор команды - вызывает команду для выполнения определенного запроса.");
            dp.InsertText(richTextBoxDescribe, false, false, "\n");
            dp.InsertText(richTextBoxDescribe, true, false, "- Client:");
            dp.InsertText(richTextBoxDescribe, false, false, " клиент - создает команду и устанавливает ее получателя с помощью метода SetCommand().");
            dp.InsertText(richTextBoxDescribe, false, false, "\n\n");

            dp.InsertText(richTextBoxDescribe, false, false, "Таким образом, инициатор, отправляющий запрос, ничего не знает о получателе, который и будет выполнять команду. Кроме того, если нам потребуется применить какие-то новые команды,  мы можем просто унаследовать классы от абстрактного класса Command и реализовать его методы Execute и Undo.");
        }

        private void Classes()
        {
            DescribeClass cl = new DescribeClass();
            cl.MakeDescribe(new List<Type>() { typeof(ICommand), typeof(TV), typeof(TVCommand), typeof(MusicCenter), typeof(MusicCenterCommand), typeof(Volume),
                typeof(VolumeCommand), typeof(Pult), typeof(MacroCommand) }, richTextBoxClass);
        }

        private void Example()
        {
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxTypes.SelectedIndex > -1)
            {
                ICommand command = null;
                switch (comboBoxTypes.SelectedIndex)
                {
                    case 0:
                        command = new TVCommand(new TV());
                        break;
                    case 1:
                        command = new VolumeCommand(new Volume());
                        break;
                    case 2:
                        command = new MusicCenterCommand(new MusicCenter());
                        break;
                }

                Button buttonOn = new Button();
                buttonOn.Left = 20;
                buttonOn.Top = groupBoxPult.Controls.Count / 2 * 40 + 20;
                buttonOn.Width = 40;
                buttonOn.Height = 40;
                buttonOn.Text = "+";
                buttonOn.Click += (object sender1, EventArgs e1) => { listBoxResult.Items.Add(command.OnProcess()); };

                Button buttonOff = new Button();
                buttonOff.Left = 120;
                buttonOff.Top = groupBoxPult.Controls.Count / 2 * 40 + 20;
                buttonOff.Width = 40;
                buttonOff.Height = 40;
                buttonOff.Text = "-";
                buttonOff.Click += (object sender1, EventArgs e1) => { listBoxResult.Items.Add(command.OffProcess()); };

                groupBoxPult.Controls.Add(buttonOn);
                groupBoxPult.Controls.Add(buttonOff);
            }
        }
    }
}
