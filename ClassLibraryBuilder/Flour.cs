using ClassLibraryAttribute;

namespace ClassLibraryBuilder
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий муку")]
    public class Flour
    {
        [ClassAttributeDescribe(Describe = "Какого сорта мука")]
        public string Sort { get; set; }
    }
}
