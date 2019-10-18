using ClassLibraryAttribute;

namespace ClassLibraryCommand
{
    [ClassAttributeDescribe(Describe = "Реализация интерфейса команд для управления телевизором")]
    public class TVCommand : ICommand
    {
        [ClassAttributeDescribe(Describe = "Объект, над которым будут производиться манипуляции")]
        TV tv;

        public TVCommand(TV tvSet)
        {
            tv = tvSet;
        }

        [ClassAttributeDescribe(Describe = "Метод, который будет включать телевизор")]
        public string OnProcess()
        {
            return tv.On();
        }

        [ClassAttributeDescribe(Describe = "Метод, который будет выключать телевизор")]
        public string OffProcess()
        {
            return tv.Off();
        }
    }
}
