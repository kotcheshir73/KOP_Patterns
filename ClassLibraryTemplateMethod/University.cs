using ClassLibraryAttribute;

namespace ClassLibraryTemplateMethod
{
    [ClassAttributeDescribe(Describe = "Абстрактный класс, описывающий процесс обучения")]
    public class University : Education
    {
        public override string Enter()
        {
            return "Сдаем вступительные экзамены и поступаем в ВУЗ";
        }

        public override string Study()
        {
            return "Посещаем лекции\nПосещаем практики\nСдаем сессии";
        }

        public override string PassExams()
        {
            return "Сдаем экзамен по специальности";
        }

        public override string GetDocument()
        {
            return "Получаем диплом о высшем образовании";
        }
    }
}
