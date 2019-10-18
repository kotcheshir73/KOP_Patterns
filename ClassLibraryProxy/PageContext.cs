using ClassLibraryAttribute;
using System;
using System.Collections.Generic;

namespace ClassLibraryProxy
{
    [ClassAttributeDescribe(Describe = "Класс,имитирующий подключение к БД (на самом деле просто генерим случайное количество страниц)")]
    public class PageContext
    {
        public List<Page> Pages { get; set; }

        public PageContext()
        {
            Pages = new List<Page>();
            Random rnd = new Random();
            int count = rnd.Next(50, 101);

            for (int i = 1; i <= count; ++i)
            {
                Pages.Add(new Page() { Number = i, Text = "Текст на странице " + i });
            }
        }
    }
}
