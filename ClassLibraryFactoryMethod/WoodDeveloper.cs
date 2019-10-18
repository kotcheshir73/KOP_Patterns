using ClassLibraryAttribute;

namespace ClassLibraryFactoryMethod
{
    [ClassAttributeDescribe(Describe = "Строитель, строющий деревянные дома")]
    public class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
