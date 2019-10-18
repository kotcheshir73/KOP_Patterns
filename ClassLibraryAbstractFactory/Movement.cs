using ClassLibraryAttribute;

namespace ClassLibraryAbstractFactory
{
    [ClassAttributeDescribe(Describe = "Абстрактный класс, описывающий возможное перемещение")]
    public abstract class Movement
    {
        public abstract string Move();
    }
}
