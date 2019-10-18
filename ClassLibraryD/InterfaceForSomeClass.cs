using ClassLibraryAttribute;

namespace ClassLibraryD
{
    [ClassAttributeDescribe(Describe = "Интерфейса, представляющий как может быть реализован класс SomeObjectForGoodClass")]
    public interface InterfaceForSomeClass
    {
        void method(string info);
    }
}
