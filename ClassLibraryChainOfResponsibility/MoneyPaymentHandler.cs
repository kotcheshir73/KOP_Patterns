using ClassLibraryAttribute;

namespace ClassLibraryChainOfResponsibility
{
    [ClassAttributeDescribe(Describe = "Обаботчик запроса. В данном случае - возможность перевода через системы денежных переводов")]
    public class MoneyPaymentHandler : PaymentHandler
    {
        public override string Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
            {
                return "Выполняем перевод через системы денежных переводов";
            }
            else if (Successor != null)
            {
                return Successor.Handle(receiver);
            }
            else
            {
                return "Перевод невозможен";
            }
        }
    }
}
