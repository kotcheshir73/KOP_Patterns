using ClassLibraryAttribute;

namespace ClassLibraryFacade
{
    [ClassAttributeDescribe(Describe = "Класс, описывающий состояние разрабатываемой программы")]
    public class Proga
    {
        [ClassAttributeDescribe(Describe = "Название программы")]
        public string Name { get; }

        [ClassAttributeDescribe(Describe = "Текст кода сохранен или нет")]
        public bool Save { set; get; }

        [ClassAttributeDescribe(Describe = "Программа откомпилирована или нет")]
        public bool Compile { set; get; }

        [ClassAttributeDescribe(Describe = "Программа запущена или нет")]
        public bool Run { set; get; }

        public Proga(string name)
        {
            Name = name;
        }
    }
}
