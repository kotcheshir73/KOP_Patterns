using ClassLibraryAttribute;

namespace ClassLibraryCommand
{
    [ClassAttributeDescribe(Describe = "Receiver - Получатель (музыкальный центр)")]
    public class MusicCenter
    {
        [ClassAttributeDescribe(Describe = "Слушаем музыку")]
        public string CenterOn()
        {
            return "Музыка играет";
        }

        [ClassAttributeDescribe(Describe = "Перестали слушать музыку")]
        public string CenterOff()
        {
            return "Музыка не играет";
        }
    }
}
