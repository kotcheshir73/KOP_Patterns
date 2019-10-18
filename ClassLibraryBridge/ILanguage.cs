using ClassLibraryAttribute;

namespace ClassLibraryBridge
{
    [ClassAttributeDescribe(Describe = "интерфейс ILanguage выступает в роли Implementor, который представляет язык программирования.")]
    public interface ILanguage
    {
        string Build();

        string Execute();
    }
}
