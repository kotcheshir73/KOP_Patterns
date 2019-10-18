using ClassLibraryAttribute;

namespace ClassLibraryState
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий воду")]
    public class Water
    {
        [ClassAttributeDescribe(Describe = "Состояние воды")]
        public IWaterState State { get; set; }

        public Water(IWaterState ws)
        {
            State = ws;
        }

        [ClassAttributeDescribe(Describe = "Нагрев воды")]
        public string Heat()
        {
            return State.Heat(this);
        }

        [ClassAttributeDescribe(Describe = "Остужение воды")]
        public string Frost()
        {
            return State.Frost(this);
        }
    }
}
