using ClassLibraryAttribute;

namespace ClassLibraryBridge
{
    [ClassAttributeDescribe(Describe = "Определяет язык программирования C#")]
    public class CSharpLanguage : ILanguage
    {
        public string Build()
        {
            return "С помощью компилятора Roslyn компилируем исходный код в файл exe";
        }

        public string Execute()
        {
            return "JIT компилирует программу бинарный код\nCLR выполняет скомпилированный бинарный код";
        }
    }
}
