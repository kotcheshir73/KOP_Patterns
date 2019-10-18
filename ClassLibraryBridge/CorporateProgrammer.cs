using ClassLibraryAttribute;

namespace ClassLibraryBridge
{
    [ClassAttributeDescribe(Describe = "Предстаялет программиста, работающего в компании и пишущего на каком-то языке")]
    public class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage lang)
           : base(lang)
        {
        }

        public override string EarnMoney()
        {
            return "Получаем в конце месяца зарплату";
        }
    }
}
