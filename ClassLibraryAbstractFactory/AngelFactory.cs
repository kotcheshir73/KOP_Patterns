using System;
using ClassLibraryAttribute;

namespace ClassLibraryAbstractFactory
{
    [ClassAttributeDescribe(Describe = "Конкретный класс, описывающий перемещение героя-ангела, умеющего летать и стрелять из арбалета")]
    public class AngelFactory : HeroFactory
    {
        [ClassAttributeDescribe(Describe = "Возвращаем объект типа Arbalet")]
        public override string getName()
        {
            return "Angel";
        }

        [ClassAttributeDescribe(Describe = "Возвращаем объект типа FlyMovement")]
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        [ClassAttributeDescribe(Describe = "Возвращаем объект типа Arbalet")]
        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}
