using ClassLibraryAttribute;

namespace ClassLibraryAbstractFactory
{
    [ClassAttributeDescribe(Describe = "Конкретный класс, описывающий меч")]
    public class Sword : Weapon
    {
        public override string Hit()
        {
            return "бьет мечом";
        }
    }
}
