using ClassLibraryAttribute;

namespace ClassLibraryDecorator
{
    [ClassAttributeDescribe(Describe = "Функциональность абстрактного класса Pizza реализуется подклассом AmericanPizza, в которой жестко закодированы название пиццы и ее цена.")]
    public class AmericanPizza : Pizza
    {
        public AmericanPizza() : base("Американская пицца")
        {
        }

        public override int GetCost()
        {
            return 15;
        }
    }
}
