using ClassLibraryAttribute;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryCommand
{
    [ClassAttributeDescribe(Describe = "Реализация интерфейса команд для управления сразу несколькими командами")]
    public class MacroCommand : ICommand
    {
        [ClassAttributeDescribe(Describe = "набор команд, которые нужно выполнить разом")]
        List<ICommand> commands;

        public MacroCommand(List<ICommand> coms)
        {
            commands = coms;
        }

        public string OnProcess()
        {
            StringBuilder sb = new StringBuilder();
            foreach (ICommand c in commands)
            {
                sb.Append(c.OnProcess() + "\n");
            }
            return sb.ToString();
        }

        public string OffProcess()
        {
            StringBuilder sb = new StringBuilder();
            foreach (ICommand c in commands)
            {
                sb.Append(c.OffProcess() + "\n");
            }
            return sb.ToString();
        }
    }
}
