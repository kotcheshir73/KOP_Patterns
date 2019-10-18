using ClassLibraryAttribute;

namespace ClassLibraryFacade
{
    [ClassAttributeDescribe(Describe = "Текстовый редактор для написания кода программы")]
    public class TextEditor
    {
        [ClassAttributeDescribe(Describe = "Если программа не запущена, то можем изменять")]
        public string CreateCode(Proga prog)
        {
            if(prog.Run)
            {
                return "Программа запущена, изменения невозможны";
            }
            prog.Save = false;
            prog.Compile = false;
            return "Код программы изменили";
        }

        [ClassAttributeDescribe(Describe = "Если программа не запущена, то можем сохранить")]
        public string Save(Proga prog)
        {
            if (prog.Run)
            {
                return "Программа запущена, сохранения невозможны";
            }
            prog.Save = true;
            return "Сохранение кода";
        }
    }
}
