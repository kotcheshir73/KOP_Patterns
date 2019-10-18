using ClassLibraryAttribute;

namespace ClassLibraryObserver
{
    [ClassAttributeDescribe(Describe = "Наблюдаемый объект")]
    public interface IObservable
    {
        [ClassAttributeDescribe(Describe = "Подписать наблюдателя")]
        void RegisterObserver(IObserver o);

        [ClassAttributeDescribe(Describe = "Отписать наблюдателя")]
        void RemoveObserver(IObserver o);

        [ClassAttributeDescribe(Describe = "Информирование наблюдателей")]
        string NotifyObservers();
    }
}
