using ClassLibraryAttribute;

namespace ClassLibraryO
{
    [ClassAttributeDescribe(Describe = "Делаем интерфейс для раобты с БД")]
    public interface InterfaceWorkWithBD
    {
        [ClassAttributeDescribe(Describe = "получаем из БД, используя, скажем, LINQ to SQL")]
        SomeObjectForBadClass Get();

        [ClassAttributeDescribe(Describe = "сохраняем o в БД")]
        void Add(SomeObjectForBadClass o);

        [ClassAttributeDescribe(Describe = "обновляем o в БД")]
        void Upd(SomeObjectForBadClass o);

        [ClassAttributeDescribe(Describe = "удаляем o из БД")]
        void Del(SomeObjectForBadClass o);
    }
}
