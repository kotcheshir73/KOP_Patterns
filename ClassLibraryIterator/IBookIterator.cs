using ClassLibraryAttribute;

namespace ClassLibraryIterator
{
    [ClassAttributeDescribe(Describe = "Интерфейс итератора")]
    public interface IBookIterator
    {
        bool HasNext();

        Book Next();

        void Reset();
    }
}
