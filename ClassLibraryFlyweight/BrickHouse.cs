using ClassLibraryAttribute;
using System;

namespace ClassLibraryFlyweight
{
    [ClassAttributeDescribe(Describe = "Внутренние характеристики для кирпичного дома")]
    public class BrickHouse : House
    {
        [ClassAttributeDescribe(Describe = "Задаем количество этажей в доме = 5")]
        public BrickHouse()
        {
            stages = 5;
        }

        public override string Build(double longitude, double latitude)
        {
            return String.Format("Построен кирпичный дом из 5 этажей; координаты: {0} широты и {1} долготы", latitude, longitude);
        }
    }
}
