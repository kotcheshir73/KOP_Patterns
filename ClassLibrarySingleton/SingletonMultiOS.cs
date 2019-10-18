using ClassLibraryAttribute;
using System;

namespace ClassLibrarySingleton
{
    [ClassAttributeDescribe(Describe = "Класс, реализующий Singleton для мультипоточности")]
    public class SingletonMultiOS
    {
        [ClassAttributeDescribe(Describe = "Объект от класса Singleton")]
        private static SingletonMultiOS instance;

        [ClassAttributeDescribe(Describe = "Простое поле, для примера")]
        public string Name { get; private set; }

        [ClassAttributeDescribe(Describe = "Поле для оператора lock")]
        private static object syncRoot = new Object();

        [ClassAttributeDescribe(Describe = "Конструктор с непубличным модификатором доступа Singleton")]
        protected SingletonMultiOS(string name)
        {
            Name = name;
        }

        [ClassAttributeDescribe(Describe = "Метод для получения ссылки на объект класса (instance)")]
        public static SingletonMultiOS getInstance(string name)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new SingletonMultiOS(name);
                    }
                }
            }
            return instance;
        }
    }
}
