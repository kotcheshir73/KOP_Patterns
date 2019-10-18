using ClassLibraryAttribute;
using System;

namespace ClassLibraryFlyweight
{
    [ClassAttributeDescribe(Describe = "Внутренние характеристики для панельного дома")]
    public class PanelHouse : House
    {
        [ClassAttributeDescribe(Describe = "Задаем количество этажей в доме = 16")]
        public PanelHouse()
        {
            stages = 16;
        }

        public override string Build(double longitude, double latitude)
        {
            return String.Format("Построен панельный дом из 16 этажей; координаты: {0} широты и {1} долготы",
                latitude, longitude);
        }
    }
}
