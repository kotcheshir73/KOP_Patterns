using ClassLibraryAttribute;

namespace ClassLibraryMemento
{
    [ClassAttributeDescribe(Describe = "Описывает характеристики героя")]
    public class Hero
    {
        [ClassAttributeDescribe(Describe = "кол-во патронов")]
        private int ammo = 10;

        [ClassAttributeDescribe(Describe = "кол-во жизней")]
        private int lives = 5;

        [ClassAttributeDescribe(Describe = "Выстрел, если есть паторны. При выстреле патроны умнеьшаются")]
        public string Shoot()
        {
            if (lives > 0)
            {
                if (ammo > 0)
                {
                    ammo--;
                    return string.Format("Производим выстрел. Осталось {0} патронов", ammo);
                }
                else
                    return "Патронов больше нет";
            }
            else
            {
                return "Герой пал смертью храбрых, он больше не может стрелять";
            }
        }

        [ClassAttributeDescribe(Describe = "Добавление патронов")]
        public string AddAmmo(int ammo)
        {
            if (lives > 0)
            {
                this.ammo += ammo;
                return string.Format("Патронов {0} ", ammo);
            }
            else
            {
                return "Герой пал смертью храбрых, он больше не может стрелять";
            }
        }

        [ClassAttributeDescribe(Describe = "Смерть героя")]
        public string HeroDie()
        {
            lives--;
            return string.Format("Жизней {0} ", lives);
        }

        [ClassAttributeDescribe(Describe = "Сохранение состояния")]
        public HeroMemento SaveState()
        {
            return new HeroMemento(ammo, lives);
        }

        [ClassAttributeDescribe(Describe = "Восстановление состояния")]
        public string RestoreState(HeroMemento memento)
        {
            ammo = memento.Patrons;
            lives = memento.Lives;
            return string.Format("Восстановление игры. Параметры: {0} патронов, {1} жизней", ammo, lives);
        }
    }
}
