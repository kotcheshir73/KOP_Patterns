using ClassLibraryAttribute;

namespace ClassLibraryAdapter
{
    [ClassAttributeDescribe( Describe = "Класс Такси, который перевозит людей из пункта А в пункт В.")]
    public class Taxi : InterfaceCar
    {
        public string Move()
        {
            return "Поездка на такси";
        }
    }
}
