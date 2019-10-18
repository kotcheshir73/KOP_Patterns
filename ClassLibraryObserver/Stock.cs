using ClassLibraryAttribute;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObserver
{
    [ClassAttributeDescribe(Describe = "Реализация наблюдаемого объекта в виде биржы")]
    public class Stock : IObservable
    {
        [ClassAttributeDescribe(Describe = "Информация о торгах")]
        StockInfo sInfo;

        [ClassAttributeDescribe(Describe = "Подписчики")]
        List<IObserver> observers;

        public Stock()
        {
            observers = new List<IObserver>();
            sInfo = new StockInfo();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public string NotifyObservers()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IObserver o in observers)
            {
                sb.Append(o.Update(sInfo) + "\n");
            }
            return sb.ToString();
        }

        [ClassAttributeDescribe(Describe = "Метод, который имитирует торги и инкапсулирует всю информацию о валютных курсах в объекте StockInfo. И вызывает NotifyObservers()")]
        public string Market()
        {
            Random rnd = new Random();
            sInfo.USD = rnd.Next(20, 40);
            sInfo.Euro = rnd.Next(30, 50);
            return NotifyObservers();
        }
    }
}
