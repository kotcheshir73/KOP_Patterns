using ClassLibraryAttribute;

namespace ClassLibraryVisitor
{
    [ClassAttributeDescribe(Describe = "Посетитель для двух классов, Person и Company")]
    public interface IVisitor
    {
        [ClassAttributeDescribe(Describe = "Посетитель для класса Person")]
        string VisitPersonAcc(Person acc);

        [ClassAttributeDescribe(Describe = "Посетитель для класса Company")]
        string VisitCompanyAc(Company acc);
    }
}
