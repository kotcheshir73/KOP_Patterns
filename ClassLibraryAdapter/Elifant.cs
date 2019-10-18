using ClassLibraryAttribute;

namespace ClassLibraryAdapter
{
    [ClassAttributeDescribe(Describe = "Класс Слон, который перевозит людей из пункта А в пункт В.")]
    public class Elifant : InterfaceAnimal
    {
        public string Go()
        {
            return "Садимся на слона и неспеша едем";
        }
    }
}
