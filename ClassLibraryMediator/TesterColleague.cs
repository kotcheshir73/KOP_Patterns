using ClassLibraryAttribute;

namespace ClassLibraryMediator
{
    [ClassAttributeDescribe(Describe = "Тестер")]
    public class TesterColleague : Colleague
    {
        public TesterColleague(Mediator mediator)
            : base(mediator)
        { }

        public override string Notify(string message)
        {
            return "Сообщение тестеру: " + message;
        }
    }
}
