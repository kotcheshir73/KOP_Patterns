using ClassLibraryAttribute;

namespace ClassLibraryD
{
    [ClassAttributeDescribe(Describe = "Хороший класс, зависит от класса интерфейса")]
    public class GoodClass
    {
        public void Get(InterfaceForSomeClass inter)
        {
            inter.method("get");
        }
    }
}
