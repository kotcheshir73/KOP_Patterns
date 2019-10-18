using ClassLibraryAttribute;

namespace ClassLibraryBuilder
{
    [ClassAttributeDescribe(Describe = "Класс-пекарь задает последовательность действий для выпекания хлеба")]
    public class Baker
    {
        public Bread Make(BreadBuilder breadBuilder)
        {
            breadBuilder.CreateBread();
            breadBuilder.SetWheatFlour();
            breadBuilder.SetRyeFlour();
            breadBuilder.SetSalt();
            breadBuilder.SetAdditives();
            return breadBuilder.Bread;
        }
    }
}
