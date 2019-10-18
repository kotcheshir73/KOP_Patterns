using ClassLibraryAttribute;

namespace ClassLibraryVisitor
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий физического лица в банке. Класс дополнили Accept для дополнительного функционала")]
    public class Person : IAccount
    {
        public string Name { get; set; }

        public string Number { get; set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitPersonAcc(this);
        }
    }
}
