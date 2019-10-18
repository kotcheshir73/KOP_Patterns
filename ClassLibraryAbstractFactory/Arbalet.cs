using ClassLibraryAttribute;

namespace ClassLibraryAbstractFactory
{
    [ClassAttributeDescribe(Describe = "Конкретный класс, описывающий арболет")]
    public class Arbalet : Weapon
    {
        public override string Hit()
        {
            return "стреляет из арбалета";
        }
    }
}
