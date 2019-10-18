using ClassLibraryAttribute;

namespace ClassLibraryAbstractFactory
{
    [ClassAttributeDescribe(Describe = "Конкретный класс, описывающий перемещение героя-воина, умеющего бегать и драться мечом")]
    public class VoinFactory : HeroFactory
    {
        [ClassAttributeDescribe(Describe = "Возвращаем объект типа Arbalet")]
        public override string getName()
        {
            return "Voin";
        }

        [ClassAttributeDescribe(Describe = "Возвращаем объект типа RunMovement")]
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        [ClassAttributeDescribe(Describe = "Возвращаем объект типа Sword")]
        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
