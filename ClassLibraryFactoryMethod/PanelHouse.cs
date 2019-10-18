using ClassLibraryAttribute;

namespace ClassLibraryFactoryMethod
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий панельный дом")]
    public class PanelHouse : House
    {
        public PanelHouse()
        {
            typeHouse = "Панельный дом построен";
        }
    }
}
