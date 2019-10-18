using ClassLibraryAttribute;

namespace ClassLibraryVisitor
{
    [ClassAttributeDescribe(Describe = "Интерфейс, представляющий метод Accept для приниятия посетителя")]
    public interface IAccount
    {
        string Accept(IVisitor visitor);
    }
}
