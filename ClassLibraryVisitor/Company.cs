using ClassLibraryAttribute;

namespace ClassLibraryVisitor
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий организацию  в банке. Класс дополнили Accept для дополнительного функционала")]
    public class Company : IAccount
    {
        public string Name { get; set; }

        public string RegNumber { get; set; }

        public string Number { get; set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitCompanyAc(this);
        }
    }
}
