using ClassLibraryAttribute;

namespace ClassLibraryObserver
{
    [ClassAttributeDescribe(Describe = "Информация по курсу валют")]
    public class StockInfo
    {
        public int USD { get; set; }
        public int Euro { get; set; }
    }
}
