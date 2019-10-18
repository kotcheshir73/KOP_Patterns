using ClassLibraryAttribute;

namespace ClassLibraryL
{
    [ClassAttributeDescribe(Describe = "Хороший класс. Не делать иерархию «квадрат» наследует «прямоугольник», а сделать их как 2 отдельные сущности/")]
    public class GoodClassSquare
    {
        protected int size;

        public void setSize(int size)
        {
            this.size = size;
        }

        public int getSize()
        {
            return this.size;
        }
    }
}
