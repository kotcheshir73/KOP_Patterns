using ClassLibraryAttribute;

namespace ClassLibraryMediator
{
    [ClassAttributeDescribe(Describe = "Абстрактный класс, предоставляющий интерфейс для взаимодействия с объектом Mediator")]
    public abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual string Send(string message)
        {
            return mediator.Send(message, this);
        }

        public abstract string Notify(string message);
    }
}
