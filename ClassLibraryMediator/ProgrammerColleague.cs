using ClassLibraryAttribute;

namespace ClassLibraryMediator
{
    [ClassAttributeDescribe(Describe = "Программист")]
    public class ProgrammerColleague : Colleague
    {
        public ProgrammerColleague(Mediator mediator)
            : base(mediator)
        { }

        public override string Notify(string message)
        {
            return "Сообщение программисту: " + message;
        }
    }
}
