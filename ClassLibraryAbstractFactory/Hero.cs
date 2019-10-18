using ClassLibraryAttribute;

namespace ClassLibraryAbstractFactory
{
    [ClassAttributeDescribe(Describe = "Конкретный класс, создающий героя")]
    public class Hero
    {
        [ClassAttributeDescribe(Describe = "Имя героя")]
        private string name;

        [ClassAttributeDescribe(Describe = "Оружие героя")]
        private Weapon weapon;

        [ClassAttributeDescribe(Describe = "Способ перемещения")]
        private Movement movement;

        public Hero(HeroFactory factory)
        {
            name = factory.getName();
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }

        [ClassAttributeDescribe(Describe = "Имя героя")]
        public string getName()
        {
            return name;
        }

        [ClassAttributeDescribe(Describe = "Двигаемся")]
        public string Move()
        {
            return movement.Move();
        }

        [ClassAttributeDescribe(Describe = "Бьем")]
        public string Hit()
        {
            return weapon.Hit();
        }
    }
}
