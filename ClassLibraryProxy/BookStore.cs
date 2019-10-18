using ClassLibraryAttribute;
using System.Linq;
using System.Threading;

namespace ClassLibraryProxy
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий книгу. Использует контекст данных для извлечения информации о странице из базы данных")]
    public class BookStore : IBook
    {
        PageContext db;

        public BookStore()
        {
            db = new PageContext();
        }

        [ClassAttributeDescribe(Describe = "делаем задержку, чтобы имитировать подключение к БД")]
        public Page GetPage(int number)
        {
            Thread.Sleep(3000);
            return db.Pages.FirstOrDefault(p => p.Number == number);
        }
    }
}
