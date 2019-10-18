using ClassLibraryAttribute;

namespace ClassLibraryDecorator
{
    [ClassAttributeDescribe(Describe = "PeperonniPizza обертывает объект Pizza и добавляет к его имени название добавки, а к цене - стоимость добавки, то есть переопределяя метод GetCost и изменяя значение свойства Name.")]
    public class PeperonniPizza : PizzaDecorator
    {
        public PeperonniPizza(Pizza _pizza) : base(_pizza.Name + " с пеперони", _pizza)
        {
        }

        public override int GetCost()
        {
            return pizza.GetCost() + 20;
        }
    }
}
