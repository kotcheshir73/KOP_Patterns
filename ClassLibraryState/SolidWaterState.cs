using ClassLibraryAttribute;

namespace ClassLibraryState
{
    [ClassAttributeDescribe(Describe = "Состояние воды - твердое")]
    public class SolidWaterState : IWaterState
    {
        public string Heat(Water water)
        {
            water.State = new LiquidWaterState();
            return "Превращаем лед в жидкость";
        }

        public string Frost(Water water)
        {
            return "Продолжаем заморозку льда";
        }
    }
}
