using ClassLibraryAttribute;

namespace ClassLibraryTemplateMethod
{
    [ClassAttributeDescribe(Describe = "Обучение в школе")]
    public class School : Education
    {
        public override string Enter()
        {
            return "Идем в первый класс";
        }

        public override string Study()
        {
            return "Посещаем уроки, делаем домашние задания";
        }

        public override string GetDocument()
        {
            return "Получаем аттестат о среднем образовании";
        }
    }
}
