using ClassLibraryAttribute;

namespace ClassLibraryO
{
    [ClassAttributeDescribe(Describe = "Хороший класс для работы с БД через LINQ")]
    public class WorkWithBDFromLINQToSQL : InterfaceWorkWithBD
    {
        public void Add(SomeObjectForBadClass o)
        {
            
        }

        public void Del(SomeObjectForBadClass o)
        {
            
        }

        public SomeObjectForBadClass Get()
        {
            return new SomeObjectForBadClass();
        }

        public void Upd(SomeObjectForBadClass o)
        {
            
        }
    }
}
