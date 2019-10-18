using ClassLibraryAttribute;

namespace ClassLibraryStrategy
{
    [ClassAttributeDescribe(Describe = "интерфейс IMovable выступает в качестве IStrategy")]
    public interface IMovable
    {
        [ClassAttributeDescribe(Describe = "Метод заправки транспортного средства")]
        string FullBack();

        [ClassAttributeDescribe(Describe = "Метод езды до пункта назначения")]
        string DriveTo();
    }
}
