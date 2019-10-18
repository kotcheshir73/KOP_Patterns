using ClassLibraryAttribute;

namespace ClassLibraryDecorator
{
    [ClassAttributeDescribe(Describe = "Функциональность абстрактного класса Pizza реализуется подклассом ItalianPizza, в которой жестко закодированы название пиццы и ее цена.")]
    public class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Итальянская пицца")
        {
        }

        public override int GetCost()
        {
            return 10;
        }
    }
}
