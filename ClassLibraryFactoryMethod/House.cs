using ClassLibraryAttribute;

namespace ClassLibraryFactoryMethod
{
    [ClassAttributeDescribe(Describe = "Абстрактный класс, описывающий дом")]
    public abstract class House
    {
        protected string typeHouse;

        public string getTypeHouse() { return typeHouse; }
    }
}
