using ClassLibraryAttribute;

namespace ClassLibraryFlyweight
{
    [ClassAttributeDescribe(Describe = "Внутренние характеристики дома")]
    public abstract class House
    {
        [ClassAttributeDescribe(Describe = "количество этажей")]
        protected int stages; 

        public abstract string Build(double longitude, double latitude);
    }
}
