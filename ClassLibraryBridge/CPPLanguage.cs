using ClassLibraryAttribute;

namespace ClassLibraryBridge
{
    [ClassAttributeDescribe(Describe = "Определяет язык программирования C++")]
    public class CPPLanguage : ILanguage
    {
        public string Build()
        {
            return "С помощью компилятора C++ компилируем программу в бинарный код";
        }

        public string Execute()
        {
            return "Запускаем исполняемый файл программы";
        }
    }
}
