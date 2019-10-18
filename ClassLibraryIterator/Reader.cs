using ClassLibraryAttribute;
using System.Text;

namespace ClassLibraryIterator
{
    [ClassAttributeDescribe(Describe = "Читатель, просматривающий все книги")]
    public class Reader
    {
        StringBuilder sb;

        IBookIterator iterator;

        public Reader(Library library)
        {
            sb = new StringBuilder();
            iterator = library.CreateNumerator();
        }

        public string SeeNextBook()
        {
            if (iterator.HasNext())
            {
                Book book = iterator.Next();
                return (book.Name);
            }
            else
            {
                iterator.Reset();
                return "Книг более нет, вернитесь в начало";
            }
        }
    }
}
