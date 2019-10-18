using ClassLibraryAttribute;

namespace ClassLibraryState
{
    [ClassAttributeDescribe(Describe = "Состояние воды - газообразное")]
    public class GasWaterState : IWaterState
    {
        public string Heat(Water water)
        {
            return "Повышаем температуру водяного пара";
        }

        public string Frost(Water water)
        {
            water.State = new LiquidWaterState();
            return "Превращаем водяной пар в жидкость";
        }
    }
}
