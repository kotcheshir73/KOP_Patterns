using ClassLibraryAttribute;

namespace ClassLibraryMediator
{
    [ClassAttributeDescribe(Describe = "Менеджер проекта, который обеспечивает коммуникацию между учатсниками: закзачиком, программистом и тестером")]
    public class ManagerMediator : Mediator
    {
        public Colleague Customer { get; set; }
        public Colleague Programmer { get; set; }
        public Colleague Tester { get; set; }

        [ClassAttributeDescribe(Describe = "Передача сообщения от персонажа colleague (смотря от кого исходит сообщение, определяем кому писать)")]
        public override string Send(string msg, Colleague colleague)
        {
            // если отправитель - заказчик, значит есть новый заказ
            // отправляем сообщение программисту - выполнить заказ
            if (Customer == colleague)
                return Programmer.Notify(msg);
            // если отправитель - программист, то можно приступать к тестированию
            // отправляем сообщение тестеру
            else if (Programmer == colleague)
                return Tester.Notify(msg);
            // если отправитель - тест, значит продукт готов
            // отправляем сообщение заказчику
            else if (Tester == colleague)
                return Customer.Notify(msg);

            return "не знаем кому отправлять, видно сообщение менеджеру";
        }
    }
}
