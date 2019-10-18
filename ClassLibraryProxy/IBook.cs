using ClassLibraryAttribute;

namespace ClassLibraryProxy
{
    [ClassAttributeDescribe(Describe = "Интерфейс, описывающий книгу. Являеется общим интерфейсом для реального объекта и для его прокси-класса")]
    public interface IBook
    {
        Page GetPage(int number);
    }
}
