using ClassLibraryAttribute;

namespace ClassLibraryState
{
    [ClassAttributeDescribe(Describe = "Состояние воды - жидкое")]
    public class LiquidWaterState : IWaterState
    {
        public string Heat(Water water)
        {
            water.State = new GasWaterState();
            return "Превращаем жидкость в пар";
        }

        public string Frost(Water water)
        {
            water.State = new SolidWaterState();
            return "Превращаем жидкость в лед";
        }
    }
}
