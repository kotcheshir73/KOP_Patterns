using ClassLibraryAttribute;

namespace ClassLibraryCommand
{
    [ClassAttributeDescribe(Describe = "Реализация интерфейса команд для управления музыкальным центром")]
    public class MusicCenterCommand : ICommand
    {
        [ClassAttributeDescribe(Describe = "Объект, над которым будут производиться манипуляции")]
        MusicCenter mc;

        public MusicCenterCommand(MusicCenter mcSet)
        {
            mc = mcSet;
        }

        [ClassAttributeDescribe(Describe = "Метод, который будет включать центр")]
        public string OnProcess()
        {
            return mc.CenterOn();
        }

        [ClassAttributeDescribe(Describe = "Метод, который будет выключать центр")]
        public string OffProcess()
        {
            return mc.CenterOff();
        }
    }
}
