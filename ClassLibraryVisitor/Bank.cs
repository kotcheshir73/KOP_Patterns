using ClassLibraryAttribute;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryVisitor
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий работу банк. Нас в нем интересует дополнительный функционал, который мы можем дополнять через посетителя")]
    public class Bank
    {
        [ClassAttributeDescribe(Describe = "Список клиентов банка")]
        List<IAccount> accounts = new List<IAccount>();

        [ClassAttributeDescribe(Describe = "Добавление клиента")]
        public void Add(IAccount acc)
        {
            accounts.Add(acc);
        }

        [ClassAttributeDescribe(Describe = "Удаление клиента")]
        public void Remove(IAccount acc)
        {
            accounts.Remove(acc);
        }

        [ClassAttributeDescribe(Describe = "Вызов доп функционала по каждому клиенту")]
        public string Accept(IVisitor visitor)
        {
            StringBuilder sb = new StringBuilder();
            foreach (IAccount acc in accounts)
            {
                sb.Append(acc.Accept(visitor));
            }
            return sb.ToString();
        }
    }
}
