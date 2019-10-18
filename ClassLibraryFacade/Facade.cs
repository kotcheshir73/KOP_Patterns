using ClassLibraryAttribute;
using System.Text;

namespace ClassLibraryFacade
{
    [ClassAttributeDescribe(Describe = "имитируем среду разработки")]
    public class Facade
    {
        TextEditor textEd;
        Compiller compiler;
        CLR clr;

        public Facade(TextEditor _textEd, Compiller _compiler, CLR _clr)
        {
            textEd = _textEd;
            compiler = _compiler;
            clr = _clr;
        }

        [ClassAttributeDescribe(Describe = "Изменяем код")]
        public string ChangeText(Proga prog)
        {
            return textEd.CreateCode(prog);
        }

        [ClassAttributeDescribe(Describe = "Сохраняем, компилируем и запускаем")]
        public string Run(Proga prog)
        {
            StringBuilder str = new StringBuilder();
            str.Append(prog.Name + ":");
            str.Append("\n");
            str.Append(textEd.Save(prog));
            str.Append("\n");
            str.Append(compiler.Compile(prog));
            str.Append("\n");
            str.Append(clr.Execute(prog));
            return str.ToString();
        }

        [ClassAttributeDescribe(Describe = "Останавливаем выполнение")]
        public string Stop(Proga prog)
        {
            return clr.Finish(prog);
        }
    }
}
