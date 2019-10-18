using ClassLibraryAttribute;

namespace ClassLibraryInterpreter
{
    [ClassAttributeDescribe(Describe = "Интерфейс интерпретатора")]
    public interface IExpression
    {
        int Interpret(Context context);
    }
}
