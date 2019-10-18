using ClassLibraryAttribute;
using System.Text;

namespace ClassLibraryTemplateMethod
{
    [ClassAttributeDescribe(Describe = "Абстрактный класс, описывающий процесс обучения")]
    public abstract class Education
    {
        [ClassAttributeDescribe(Describe = "Главный метод, описывающий процесс обучения. Вызывает Enter, Study, PassExams, GetDocument")]
        public string Learn()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Enter() + "\n");
            sb.Append(Study() + "\n");
            sb.Append(PassExams() + "\n");
            sb.Append(GetDocument() + "\n");
            return sb.ToString();
        }

        [ClassAttributeDescribe(Describe = "Метод поступления")]
        public abstract string Enter();

        [ClassAttributeDescribe(Describe = "Метод обучения")]
        public abstract string Study();

        [ClassAttributeDescribe(Describe = "Метод сдачи выппускных экзаменов")]
        public virtual string PassExams()
        {
           return "Сдаем выпускные экзамены";
        }

        [ClassAttributeDescribe(Describe = "Метод получения итогового документа")]
        public abstract string GetDocument();
    }
}
