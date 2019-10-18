using ClassLibraryAttribute;
using System.Text;

namespace ClassLibraryStrategy
{
    [ClassAttributeDescribe(Describe = "Автомобиль")]
    public class Car
    {
        [ClassAttributeDescribe(Describe = "Кол-во пассажиров")]
        protected int passengers;

        [ClassAttributeDescribe(Describe = "Модель автомобиля")]
        protected string model;

        public Car(int num, string model, IMovable mov)
        {
            this.passengers = num;
            this.model = model;
            Movable = mov;
        }

        [ClassAttributeDescribe(Describe = "Тип автомобиля")]
        public IMovable Movable { private get; set; }

        [ClassAttributeDescribe(Describe = "Передвигаемся: заправляемся и едем")]
        public string Move()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Movable.FullBack() + "\n");
            sb.Append(Movable.DriveTo() + "\n");
            return sb.ToString();
        }
    }
}
