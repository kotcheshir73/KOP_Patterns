using ClassLibraryAttribute;
using System;

namespace ClassLibraryObserver
{
    [ClassAttributeDescribe(Describe = "Наблюдатель")]
    public class Bank : IObserver
    {
        public string Name { get; set; }

        IObservable stock;

        public Bank(string name, IObservable obs)
        {
            this.Name = name;
            stock = obs;
            stock.RegisterObserver(this);
        }

        public string Update(object ob)
        {
            if (ob is StockInfo)
            {
                StockInfo sInfo = ob as StockInfo;
                if (sInfo.Euro > 40)
                    return String.Format("Банк {0} продает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
                else
                    return String.Format("Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
            }
            return "Полученную информацию не удалось обработать";
        }
    }
}
