using ClassLibraryAttribute;

namespace ClassLibraryStrategy
{
    [ClassAttributeDescribe(Describe = "Реализация интерфейса - машина на батареях")]
    public class ElectricMove : IMovable
    {
        private bool back = false;

        public string DriveTo()
        {
            if (back)
            {
                back = false;
                return "едем до пункта назначения, пока не кончится заряд";
            }
            return "Заряда нет, нужна пеерзарядка";
        }

        public string FullBack()
        {
            back = true;
            return "заряжаемся от розетки";
        }
    }
}
