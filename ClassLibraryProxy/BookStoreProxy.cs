using ClassLibraryAttribute;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryProxy
{
    [ClassAttributeDescribe(Describe = "В прокси будет реализована функциональность кэша страниц.")]
    public class BookStoreProxy : IBook
    {
        [ClassAttributeDescribe(Describe = "Страницы кеша")]
        List<Page> pages;

        [ClassAttributeDescribe(Describe = "Реальный орбъект")]
        BookStore bookStore;

        public BookStoreProxy()
        {
            pages = new List<Page>();
        }

        [ClassAttributeDescribe(Describe = "При получении страницы прокси сначала смотрит в этот список, и если там страницы не окажется, то идет обращение к реальному объекту BookStore и его методу.")]
        public Page GetPage(int number)
        {
            Page page = pages.FirstOrDefault(p => p.Number == number);
            if (page == null)
            {
                if (bookStore == null)
                {
                    bookStore = new BookStore();
                }
                page = bookStore.GetPage(number);
                pages.Add(page);
            }
            return page;
        }
    }
}
