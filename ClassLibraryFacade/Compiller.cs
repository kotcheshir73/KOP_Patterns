using ClassLibraryAttribute;

namespace ClassLibraryFacade
{
    [ClassAttributeDescribe(Describe = "Класс, имитирующий работу компилятора")]
    public class Compiller
    {
        [ClassAttributeDescribe(Describe = "Если программа не запущена и все сохранено, то можем откомпилить")]
        public string Compile(Proga prog)
        {
            if (prog.Run)
            {
                return "Программа запущена, компиляция невозможна";
            }
            if(!prog.Save)
            {
                return "Программа не сохранена, компиляция невозможна";
            }
            prog.Compile = true;
            return "Компиляция приложения";
        }
    }
}
