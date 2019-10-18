using ClassLibraryAttribute;

namespace ClassLibraryBuilder
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий пищевые добавки")]
    public class Additives
    {
        public string Name { get; set; }
    }
}
