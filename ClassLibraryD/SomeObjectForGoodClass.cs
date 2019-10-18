using ClassLibraryAttribute;
using System;

namespace ClassLibraryD
{
    [ClassAttributeDescribe(Describe = "Класс - наследник от интерфейса, который будет подставляться посредством Unity")]
    public class SomeObjectForGoodClass : InterfaceForSomeClass
    {
        public void method(string info)
        {
            throw new NotImplementedException();
        }
    }
}
