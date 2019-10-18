using ClassLibraryAttribute;

namespace ClassLibraryAbstractFactory
{
    [ClassAttributeDescribe(Describe = "Абстрактный класс, описывающий героя (Абстрактная фабрика)")]
    public abstract class HeroFactory
    {
        [ClassAttributeDescribe(Describe = "Абстрактный метод для указания типа героя")]
        public abstract string getName();

        [ClassAttributeDescribe(Describe = "Абстрактный метод для указания способа перемещения")]
        public abstract Movement CreateMovement();

        [ClassAttributeDescribe(Describe = "Абстрактный метод для указания оружия героя")]
        public abstract Weapon CreateWeapon();
    }
}
