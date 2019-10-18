using ClassLibraryAttribute;

namespace ClassLibraryL
{
    [ClassAttributeDescribe(Describe = "Класс, описывает прямоугольник")]
    public class ClassRectangle
    {
        protected int width;
        protected int height;

        public void setWidth(int width)
        {
            this.width = width;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }

        public int getWidth()
        {
            return this.width;
        }

        public int getHeight()
        {
            return this.height;
        }
    }
}
