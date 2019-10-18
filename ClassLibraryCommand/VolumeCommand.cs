using ClassLibraryAttribute;

namespace ClassLibraryCommand
{
    [ClassAttributeDescribe(Describe = "Реализация интерфейса команд для управления звуком")]
    public class VolumeCommand : ICommand
    {
        Volume volume;

        public VolumeCommand(Volume v)
        {
            volume = v;
        }

        [ClassAttributeDescribe(Describe = "Увелиичваем звук")]
        public string OnProcess()
        {
            return volume.RaiseLevel();
        }

        [ClassAttributeDescribe(Describe = "Уменьшаем звук")]
        public string OffProcess()
        {
            return volume.DropLevel();
        }
    }
}
