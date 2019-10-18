using ClassLibraryAttribute;

namespace ClassLibraryMediator
{
    [ClassAttributeDescribe(Describe = "Заказчик")]
    public class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator)
            : base(mediator)
        { }

        public override string Notify(string message)
        {
            return "Сообщение заказчику: " + message;
        }
    }
}
