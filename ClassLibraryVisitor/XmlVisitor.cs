using ClassLibraryAttribute;

namespace ClassLibraryVisitor
{
    [ClassAttributeDescribe(Describe = "Реализатор посетителя, который создает xml-разметку по данным объекта одного из двух классов, Person или Company")]
    public class XmlVisitor : IVisitor
    {
        public string VisitPersonAcc(Person acc)
        {
            return "<Person><Name>" + acc.Name + "</Name>" +
                "<Number>" + acc.Number + "</Number><Person>\n";
        }

        public string VisitCompanyAc(Company acc)
        {
            return "<Company><Name>" + acc.Name + "</Name>" +
                "<RegNumber>" + acc.RegNumber + "</RegNumber>" +
                "<Number>" + acc.Number + "</Number><Company>\n";
        }
    }
}
