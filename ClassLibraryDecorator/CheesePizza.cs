using ClassLibraryAttribute;

namespace ClassLibraryDecorator
{
    [ClassAttributeDescribe(Describe = "CheesePizza обертывает объект Pizza и добавляет к его имени название добавки, а к цене - стоимость добавки, то есть переопределяя метод GetCost и изменяя значение свойства Name.")]
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza _pizza) : base(_pizza.Name + " с сырами", _pizza)
        {
        }

        public override int GetCost()
        {
            return pizza.GetCost() + 45;
        }
    }
}
