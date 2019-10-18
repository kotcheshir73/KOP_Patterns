using ClassLibraryAttribute;

namespace ClassLibraryCommand
{
    [ClassAttributeDescribe(Describe = "Receiver - Получатель (телефизор)")]
    public class TV
    {
        [ClassAttributeDescribe(Describe = "Возвращает информацию, что телевизор включен")]
        public string On()
        {
            return "Телевизор включен!";
        }

        [ClassAttributeDescribe(Describe = "Возвращает информацию, что телевизор выключен")]
        public string Off()
        {
            return "Телевизор выключен...";
        }
    }
}
