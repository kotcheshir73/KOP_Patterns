using ClassLibraryAttribute;
using System;

namespace ClassLibraryObserver
{
    [ClassAttributeDescribe(Describe = "Наблюдатель")]
    public class Broker : IObserver
    {
        public string Name { get; set; }

        IObservable stock;

        public Broker(string name, IObservable obs)
        {
            this.Name = name;
            stock = obs;
            stock.RegisterObserver(this);
        }

        public string Update(Object ob)
        {
            if(ob is StockInfo)
            {
                StockInfo sInfo = ob as StockInfo;
                if (sInfo.USD > 30)
                    return String.Format("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
                else
                    return String.Format("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
            }
            return "Полученную информацию не удалось обработать";
        }

        [ClassAttributeDescribe(Describe = "Отписываемся от наблюдения")]
        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
