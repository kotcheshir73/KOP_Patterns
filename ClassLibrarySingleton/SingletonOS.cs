using ClassLibraryAttribute;

namespace ClassLibrarySingleton
{
    [ClassAttributeDescribe(Describe = "Класс, реализующий простой Singleton")]
    public class SingletonOS
    {
        [ClassAttributeDescribe(Describe = "Объект от класса Singleton")]
        private static SingletonOS instance;

        [ClassAttributeDescribe(Describe = "Простое поле, для примера")]
        public string Name { private set; get; }

        [ClassAttributeDescribe(Describe = "Конструктор с непубличным модификатором доступа Singleton")]
        private SingletonOS(string name)
        {
            Name = name;
        }

        [ClassAttributeDescribe(Describe = "Метод для получения ссылки на объект класса (instance)")]
        public static SingletonOS getInstance(string name)
        {
            if (instance == null)
            {
                instance = new SingletonOS(name);
            }
            return instance;
        }
    }
}
