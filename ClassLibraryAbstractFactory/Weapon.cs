using ClassLibraryAttribute;

namespace ClassLibraryAbstractFactory
{
    [ClassAttributeDescribe(Describe = "Абстрактный класс, описывающий оружие")]
    public abstract class Weapon
    {
        public abstract string Hit();
    }
}
