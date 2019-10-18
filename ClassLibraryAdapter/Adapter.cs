using ClassLibraryAttribute;

namespace ClassLibraryAdapter
{
    [ClassAttributeDescribe(Describe = "Класс-адаптер для модификации исходного класса")]
    public class Adapter : InterfaceCar
    {
        private InterfaceAnimal animal;

        public Adapter(InterfaceAnimal _animal)
        {
            this.animal = _animal;
        }
        
        public string Move()
        {
            return animal.Go();
        }
    }
}
