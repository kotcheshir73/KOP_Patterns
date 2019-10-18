using ClassLibraryAttribute;

namespace ClassLibraryMediator
{
    [ClassAttributeDescribe(Describe = "Абстрактный класс, предоставляющий интерфейс для взаимодействия с объектами Colleague")]
    public abstract class Mediator
    {
        public abstract string Send(string msg, Colleague colleague);
    }
}
