using ClassLibraryAttribute;

namespace ClassLibraryL
{
    [ClassAttributeDescribe(Describe = "Плохой класс, наследник от прямоугольника, В понятиях объектов, квадрат не есть прямоугольник, поскольку поведение объекта «квадрат» не согласуется с поведением объекта «прямоугольник».")]
    public class BadClassSquare : ClassRectangle
    {
        [ClassAttributeDescribe(Describe = "Если за постусловие метода setWidth принять ((this.width == width) && (this.height == oldHeight)) (oldHeight мы присвоили вначале метода setWidth), то это условие не выполняется в дочернем классе и соответственно мы его ослабили и принцип Лисков нарушен.")]
        public new void setWidth(int width)
        {
            base.setWidth(width);
            base.setHeight(width);
        }

        public new void setHeight(int  height)
        {
            base.setHeight(height);
            base.setWidth(height);
        }
    }
}
