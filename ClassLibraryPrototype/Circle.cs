using ClassLibraryAttribute;
using System;

namespace ClassLibraryPrototype
{
    [ClassAttributeDescribe(Describe = "Конкретный класс, описывающий фигуру - круг")]
    public class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(this.radius);
        }
        public string GetInfo()
        {
            return String.Format("Круг радиусом {0}", radius);
        }
    }
}
