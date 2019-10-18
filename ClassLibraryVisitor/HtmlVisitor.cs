using ClassLibraryAttribute;
using System.Text;

namespace ClassLibraryVisitor
{
    [ClassAttributeDescribe(Describe = "Реализатор посетителя, который создает html-код по данным объекта одного из двух классов, Person или Company")]
    public class HtmlVisitor : IVisitor
    {
        public string VisitPersonAcc(Person acc)
        {
            StringBuilder result = new StringBuilder("<tr><td>Свойство<td><td>Значение</td></tr>");
            result.Append("<tr><td>Name<td><td>" + acc.Name + "</td></tr>");
            result.Append("<tr><td>Number<td><td>" + acc.Number + "</td></tr>\n");
            return result.ToString();
        }

        public string VisitCompanyAc(Company acc)
        {
            StringBuilder result = new StringBuilder("<tr><td>Свойство<td><td>Значение</td></tr>");
            result.Append("<tr><td>Name<td><td>" + acc.Name + "</td></tr>");
            result.Append("<tr><td>RegNumber<td><td>" + acc.RegNumber + "</td></tr>");
            result.Append("<tr><td>Number<td><td>" + acc.Number + "</td></tr>\n");
            return result.ToString();
        }
    }
}
