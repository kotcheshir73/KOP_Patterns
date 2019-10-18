using ClassLibraryAttribute;

namespace ClassLibraryAdapter
{
    [ClassAttributeDescribe(Describe ="Класс человек-путешественник, который предпочитает передвигаться на такси")]
    public class Traveler
    {
        public string Drive(InterfaceCar car)
        {
            return car.Move();
        }
    }
}
