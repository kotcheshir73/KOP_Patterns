using ClassLibraryAttribute;

namespace ClassLibraryChainOfResponsibility
{
    [ClassAttributeDescribe(Describe = "Обаботчик запроса. В данном случае - возможность перевода через банк")]
    public class BankPaymentHandler : PaymentHandler
    {
        public override string Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
            {
                return "Выполняем банковский перевод";
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
