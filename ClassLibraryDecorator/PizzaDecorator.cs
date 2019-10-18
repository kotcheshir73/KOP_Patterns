using ClassLibraryAttribute;

namespace ClassLibraryDecorator
{
    [ClassAttributeDescribe(Describe = "абстрактный класс PizzaDecorator, который унаследован от класса Pizza и содержит ссылку на декорируемый объект Pizza. В отличие от формальной схемы здесь установка декорируемого объекта происходит не в методе SetComponent, а в конструкторе.")]
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;

        public PizzaDecorator(string n, Pizza _pizza) : base(n)
        {
            pizza = _pizza;
        }
    }
}
