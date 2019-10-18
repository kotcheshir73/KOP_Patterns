using System;
using ClassLibraryAttribute;

namespace ClassLibraryIterator
{
    [ClassAttributeDescribe(Describe = "Конкретная реализация итератора для обхода объекта Aggregate")]
    public class LibraryNumerator : IBookIterator
    {
        [ClassAttributeDescribe(Describe = "Объект Aggregate")]
        IBookNumerable aggregate;

        [ClassAttributeDescribe(Describe = "Номер текущей книги для просмотра")]
        int index = 0;

        public LibraryNumerator(IBookNumerable a)
        {
            aggregate = a;
        }

        [ClassAttributeDescribe(Describe = "Проверяем, есть ли следующая книга")]
        public bool HasNext()
        {
            return index < aggregate.Count;
        }

        [ClassAttributeDescribe(Describe = "Передаем книгу и индекс увелиичваем на 1")]
        public Book Next()
        {
            return aggregate[index++];
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
