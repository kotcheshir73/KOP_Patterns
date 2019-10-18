using ClassLibraryAttribute;

namespace ClassLibraryIterator
{
    [ClassAttributeDescribe(Describe = "Интерфейс агрегатора")]
    public interface IBookNumerable
    {
        IBookIterator CreateNumerator();

        int Count { get; }

        Book this[int index] { get; }
    }
}
