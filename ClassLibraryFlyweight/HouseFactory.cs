using ClassLibraryAttribute;

using System.Collections.Generic;

namespace ClassLibraryFlyweight
{
    [ClassAttributeDescribe(Describe = "Фабрика, возвращащющая экземпляр дома")]
    public class HouseFactory
    {
        [ClassAttributeDescribe(Describe = "Словарь с возможными экземплярами")]
        Dictionary<string, House> houses = new Dictionary<string, House>();

        [ClassAttributeDescribe(Describe = "В констуркторе создаем 2 экземпляра, блочного и кирпичного домов")]
        public HouseFactory()
        {
            houses.Add("Panel", new PanelHouse());
            houses.Add("Brick", new BrickHouse());
        }

        [ClassAttributeDescribe(Describe = "Получение одного из вариантов домов по ключу")]
        public House GetHouse(string key)
        {
            if (houses.ContainsKey(key))
                return houses[key];
            else
                return null;
        }
    }
}
