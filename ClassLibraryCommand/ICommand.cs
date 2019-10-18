using ClassLibraryAttribute;

namespace ClassLibraryCommand
{
    [ClassAttributeDescribe(Describe = "Интерфейс команды")]
    public interface ICommand
    {
        string OnProcess();

        string OffProcess();
    }
}
