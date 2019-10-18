using ClassLibraryAttribute;

namespace ClassLibraryInterpreter
{
    [ClassAttributeDescribe(Describe = "Терминальное выражение (обычные переменные хранятся)")]
    public class NumberExpression : IExpression
    {
        [ClassAttributeDescribe(Describe = "Имя переменной")]
        string name;

        public NumberExpression(string variableName)
        {
            name = variableName;
        }

        public int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}
