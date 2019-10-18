using ClassLibraryAttribute;

namespace ClassLibraryDecorator
{
    [ClassAttributeDescribe(Describe = "Абстрактный класс, имитирует Component. Определяет базовую функциональность в виде свойства Name и метода GetCost().")]
    public abstract class Pizza
    {
        public Pizza(string n)
        {
            Name = n;
        }
        public string Name { get; protected set; }

        public abstract int GetCost();
    }
}
