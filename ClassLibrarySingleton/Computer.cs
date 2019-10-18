using ClassLibraryAttribute;

namespace ClassLibrarySingleton
{
    [ClassAttributeDescribe(Describe = "Класс, использующий объект-Singleton")]
    public class Computer
    {
        public SingletonOS OS { get; set; }

        [ClassAttributeDescribe(Describe = "Получаем объект-Singleton")]
        public void Launch(string osName)
        {
            OS = SingletonOS.getInstance(osName);
        }
    }
}
