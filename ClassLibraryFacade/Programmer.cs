using ClassLibraryAttribute;

namespace ClassLibraryFacade
{
    [ClassAttributeDescribe(Describe = "Класс, имитирующий программера")]
    public class Programmer
    {
        [ClassAttributeDescribe(Describe = "Поле - программа, которую создают")]
        Proga prog;

        [ClassAttributeDescribe(Describe = "Поле - среда разработки")]
        Facade facade;

        public Programmer(Facade _facade)
        {
            facade = _facade;
        }

        [ClassAttributeDescribe(Describe = "Создаем новую программу")]
        public string CreateProg(string name)
        {
            prog = new Proga(name);
            return "Программа " + prog.Name + " создана";
        }

        [ClassAttributeDescribe(Describe = "Пишем код новой программы")]
        public string MakeCode()
        {
            if(facade != null)
            {
                if (prog != null)
                {
                    return facade.ChangeText(prog);
                }
                return "Программы нет, что изменять?";
            }
            return "Нет среды разработки, где кодить?";
        }

        [ClassAttributeDescribe(Describe = "Запускаем новую программу")]
        public string Run()
        {
            if (facade != null)
            {
                if (prog != null)
                {
                    return facade.Run(prog);
                }
                return "Программы нет, что запускать?";
            }
            return "Нет среды разработки, где запускать?";
        }

        [ClassAttributeDescribe(Describe = "Останавливаем новую программу")]
        public string Stop()
        {
            if (facade != null)
            {
                if (prog != null)
                {
                    return facade.Stop(prog);
                }
                return "Программы нет, что останавливать?";
            }
            return "Нет среды разработки, где останавливать?";
        }
    }
}
