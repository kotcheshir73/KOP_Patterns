using ClassLibraryAttribute;

namespace ClassLibraryO
{
    [ClassAttributeDescribe(Describe = "Плохой класс")]
    public class BadClass
    {
        [ClassAttributeDescribe(Describe ="получаем из БД, используя, скажем, LINQ to SQL")]
        public SomeObjectForBadClass Get()
        {
            return new SomeObjectForBadClass();
        }

        [ClassAttributeDescribe(Describe = "сохраняем o в БД")]
        public void Add(SomeObjectForBadClass o)
        {
        }

        [ClassAttributeDescribe(Describe = "обновляем o в БД")]
        public void Upd(SomeObjectForBadClass o)
        {
        }

        [ClassAttributeDescribe(Describe = "удаляем o из БД")]
        public void Del(SomeObjectForBadClass o)
        {
        }
    }
}
