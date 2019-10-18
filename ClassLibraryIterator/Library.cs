using ClassLibraryAttribute;
using System.Collections.Generic;

namespace ClassLibraryIterator
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий библиотеку (реализует агригатор)")]
    public class Library : IBookNumerable
    {
        [ClassAttributeDescribe(Describe = "Список книг")]
        private List<Book> books;
        
        public Library()
        {
            books = new List<Book>()
            {
                new Book{Name="Война и мир"},
                new Book {Name="Отцы и дети"},
                new Book {Name="Вишневый сад"}
            };
        }

        [ClassAttributeDescribe(Describe = "Сколько книг в бибилотеке")]
        public int Count
        {
            get { return books.Count; }
        }

        [ClassAttributeDescribe(Describe = "Книга бибилотеки")]
        public Book this[int index]
        {
            get { return books[index]; }
        }

        [ClassAttributeDescribe(Describe = "Итератор библиотеки")]
        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
}
