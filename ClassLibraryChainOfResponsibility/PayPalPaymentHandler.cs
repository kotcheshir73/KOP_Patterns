using ClassLibraryAttribute;

namespace ClassLibraryChainOfResponsibility
{
    [ClassAttributeDescribe(Describe = "Обаботчик запроса. В данном случае - возможность перевода через PayPal")]
    public class PayPalPaymentHandler : PaymentHandler
    {
        public override string Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
            {
                return "Выполняем перевод через PayPal";
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
