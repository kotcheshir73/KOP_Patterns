using ClassLibraryAttribute;

namespace ClassLibraryStrategy
{
    [ClassAttributeDescribe(Describe = "Реализация интерфейса - машина на бензине")]
    public class PetrolMove : IMovable
    {
        private bool back = false;

        public string DriveTo()
        {
            if (back)
            {
                back = false;
                return "едем до пункта назначения, пока не кончится бензин";
            }
            return "Бак пуст, нужна дозаправка";
        }

        public string FullBack()
        {
            back = true;
            return "запарвляемся бензином";
        }
    }
}
