using ClassLibraryAttribute;
using System;

namespace ClassLibraryPrototype
{
    [ClassAttributeDescribe(Describe = "Конкретный класс, описывающий фигуру - прямоугольник")]
    public class Rectangle : IFigure
    {
        int width;
        int height;

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }

        public string GetInfo()
        {
            return String.Format("Прямоугольник длиной {0} и шириной {1}", height, width);
        }
    }
}
