using ClassLibraryAttribute;

namespace ClassLibraryAbstractFactory
{
    [ClassAttributeDescribe(Describe = "Конкретный класс, описывающий перемещение по воздуху")]
    public class FlyMovement : Movement
    {
        public override string Move()
        {
            return "летит";
        }
    }
}
