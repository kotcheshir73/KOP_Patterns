using ClassLibraryAttribute;

namespace ClassLibraryState
{
    [ClassAttributeDescribe(Describe = "Интерфейс для определения состояния воды")]
    public interface IWaterState
    {
        string Heat(Water water);
        string Frost(Water water);
    }
}
