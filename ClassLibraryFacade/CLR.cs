using ClassLibraryAttribute;

namespace ClassLibraryFacade
{
    [ClassAttributeDescribe(Describe = "Класс, имитирующий работу среды выполнения")]
    public class CLR
    {
        [ClassAttributeDescribe(Describe = "Если программа не запущена, сохранена и откомпилирована, то можем запустить")]
        public string Execute(Proga prog)
        {
            if (!prog.Save)
            {
                return "Программа не сохранена";
            }
            if (!prog.Compile)
            {
                return "Программа не откомпилирована, запустить невозможно";
            }
            if (prog.Run)
            {
                return "Программа уже запущена";
            }
            prog.Run = true;
            return "Выполнение приложения";
        }

        [ClassAttributeDescribe(Describe = "Если программа запущена, то можем ее остановить")]
        public string Finish(Proga prog)
        {
            if (!prog.Run)
            {
                return "Программа не запущена";
            }
            prog.Run = false;
            return "Завершение работы приложения";
        }
    }
}
