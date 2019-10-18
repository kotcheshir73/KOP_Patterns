using ClassLibraryAttribute;

namespace ClassLibraryPrototype
{
    [ClassAttributeDescribe (Describe = "Интерфейс, описывающий фигуру")]
    public interface IFigure
    {
        [ClassAttributeDescribe(Describe = "Метод, возвращающий дубликат фигуры")]
        IFigure Clone();

        [ClassAttributeDescribe(Describe = "Метод, возвращающий информацию по фигуре")]
        string GetInfo();
    }
}
