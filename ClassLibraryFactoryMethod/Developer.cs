using ClassLibraryAttribute;

namespace ClassLibraryFactoryMethod
{
    [ClassAttributeDescribe (Describe = "Абстрактный класс, описывающий строителя")]
    public abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }

        [ClassAttributeDescribe(Describe = "Фабричный метод")]
        public abstract House Create();
    }
}
