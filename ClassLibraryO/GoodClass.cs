using ClassLibraryAttribute;

namespace ClassLibraryO
{
    [ClassAttributeDescribe(Describe = "Хороший класс, использует интерфейс")]
    public class GoodClass
    {
        [ClassAttributeDescribe(Describe = "класс для работы с БД (без раницы с какой)")]
        private InterfaceWorkWithBD workWithBD;

        [ClassAttributeDescribe(Describe = "получаем реализацию интерфейса InterfaceWorkWithBD")]
        public GoodClass(InterfaceWorkWithBD workWithBD)
        {
            this.workWithBD = workWithBD;
        }

        [ClassAttributeDescribe(Describe = "получаем из БД")]
        public SomeObjectForBadClass Get()
        {
            return workWithBD.Get();
        }

        [ClassAttributeDescribe(Describe = "сохраняем o в БД")]
        public void Add(SomeObjectForBadClass o)
        {
            workWithBD.Add(o);
        }

        [ClassAttributeDescribe(Describe = "обновляем o в БД")]
        public void Upd(SomeObjectForBadClass o)
        {
            workWithBD.Upd(o);
        }

        [ClassAttributeDescribe(Describe = "удаляем o из БД")]
        public void Del(SomeObjectForBadClass o)
        {
            workWithBD.Del(o);
        }
    }
}
