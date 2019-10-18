using ClassLibraryAttribute;

using System.Text;

namespace ClassLibraryBridge
{
    [ClassAttributeDescribe(Describe = "класс Programmer выступает в роли Abstraction и обозначет программиста")]
    public abstract class Programmer
    {
        protected ILanguage language;

        public ILanguage Language
        {
            set { language = value; }
        }

        public Programmer(ILanguage lang)
        {
            language = lang;
        }

        [ClassAttributeDescribe(Describe = "Вызывает методы языка, ал-я пишет код")]
        public virtual string DoWork()
        {
            StringBuilder str = new StringBuilder();
            str.Append(language.Build());
            str.Append(language.Execute());
            return str.ToString();
        }

        [ClassAttributeDescribe(Describe = "Как программист получает зарплату")]
        public abstract string EarnMoney();
    }
}
