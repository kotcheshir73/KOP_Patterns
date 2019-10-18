using ClassLibraryAttribute;

namespace ClassLibraryChainOfResponsibility
{
    [ClassAttributeDescribe(Describe = "Система перевода денег")]
    public abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; }

        public abstract string Handle(Receiver receiver);
    }
}
