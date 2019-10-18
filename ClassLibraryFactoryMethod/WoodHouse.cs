using ClassLibraryAttribute;

namespace ClassLibraryFactoryMethod
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий деревянный дом")]
    public class WoodHouse : House
    {
        public WoodHouse()
        {
            typeHouse = "Деревянный дом построен";
        }
    }
}
