using ClassLibraryAttribute;

namespace ClassLibraryD
{
    [ClassAttributeDescribe(Describe = "Плохой класс, зависит от класса SomeObjectForBadClass")]
    public class BadClass
    {
        [ClassAttributeDescribe(Describe = "Зависим от этого класса")]
        SomeObjectForBadClass obj;

        public void Get()
        {
            obj = new SomeObjectForBadClass();
            obj.method("get");
        }
    }
}
