using ClassLibraryAttribute;

namespace ClassLibraryAbstractFactory
{
    [ClassAttributeDescribe(Describe = "Конкретный класс, описывающий перемещение по земле (бег)")]
    public class RunMovement : Movement
    {
        public override string Move()
        {
            return "бежит";
        }
    }
}
