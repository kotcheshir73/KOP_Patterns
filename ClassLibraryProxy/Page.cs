using ClassLibraryAttribute;

namespace ClassLibraryProxy
{
    [ClassAttributeDescribe(Describe = "Класс-таблица в БД, имитирующая страницу книги")]
    public class Page
    {
        public int Number { get; set; }

        public string Text { get; set; }
    }
}
