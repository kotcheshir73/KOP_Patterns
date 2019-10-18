using ClassLibraryAttribute;

namespace ClassLibraryFactoryMethod
{
    [ClassAttributeDescribe(Describe = "Строитель, строющий панельные дома")]
    public class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
}
