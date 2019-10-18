using ClassLibraryAttribute;

namespace ClassLibraryComposite
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий файл файловой системы (Leaf)")]
    public class File : Component
    {
        public File(string name)
                : base(name)
        { }
    }
}
