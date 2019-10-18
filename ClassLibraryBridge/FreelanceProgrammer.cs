using ClassLibraryAttribute;

namespace ClassLibraryBridge
{
    [ClassAttributeDescribe(Describe = "Предстаялет программиста-фрилансера, пишущего на каком-то языке")]
    public class FreelanceProgrammer : Programmer
    {
        public FreelanceProgrammer(ILanguage lang) : base(lang)
        {
        }

        public override string EarnMoney()
        {
            return "Получаем оплату за выполненный заказ";
        }
    }
}
