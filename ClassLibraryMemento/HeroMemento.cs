using ClassLibraryAttribute;

namespace ClassLibraryMemento
{
    [ClassAttributeDescribe(Describe = "Хранитель, который сохраняет состояние объекта героя")]
    public class HeroMemento
    {
        public int Patrons { get; private set; }
        public int Lives { get; private set; }

        public HeroMemento(int patrons, int lives)
        {
            this.Patrons = patrons;
            this.Lives = lives;
        }
    }
}
