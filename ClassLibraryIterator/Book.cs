using ClassLibraryAttribute;

namespace ClassLibraryIterator
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий книгу в библиотеке")]
    public class Book
    {
        [ClassAttributeDescribe(Describe = "Название книги")]
        public string Name { get; set; }
    }
}
