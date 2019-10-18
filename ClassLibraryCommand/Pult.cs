using ClassLibraryAttribute;
using System.Collections.Generic;

namespace ClassLibraryCommand
{
    [ClassAttributeDescribe(Describe = "Invoker - инициатор. При этом пульт ничего не знает об объекте TV.")]
    public class Pult
    {
        [ClassAttributeDescribe(Describe = "Список команд")]
        Dictionary<int, ICommand> commands;

        public Pult()
        {
            commands = new Dictionary<int, ICommand>();
        }

        public void SetCommand(int number, ICommand com)
        {
            commands.Add(number, com);
        }

        public string PressOn(int number)
        {
            if (commands.ContainsKey(number))
            {
                return commands[number].OnProcess();
            }
            return "Кнопка не найдена";
        }

        public string PressOff(int number)
        {
            if (commands.ContainsKey(number))
            {
                return commands[number].OffProcess();
            }
            return "Кнопка не найдена";
        }
    }
}
