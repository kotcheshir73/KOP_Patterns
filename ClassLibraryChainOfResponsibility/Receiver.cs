using ClassLibraryAttribute;

namespace ClassLibraryChainOfResponsibility
{
    [ClassAttributeDescribe(Describe = "Переводчик денег, определяет, через какие системы мы можем перевести деньги")]
    public class Receiver
    {
        [ClassAttributeDescribe(Describe = "Банковские переводы")]
        public bool BankTransfer { get; set; }

        [ClassAttributeDescribe(Describe = "Денежные переводы - WesternUnion, Unistream")]
        public bool MoneyTransfer { get; set; }

        [ClassAttributeDescribe(Describe = "Перевод через PayPal")]
        public bool PayPalTransfer { get; set; }

        public Receiver(bool bt, bool ppt, bool mt)
        {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = ppt;
        }
    }
}
