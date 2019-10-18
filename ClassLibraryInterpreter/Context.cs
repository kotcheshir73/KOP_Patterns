using ClassLibraryAttribute;
using System.Collections.Generic;

namespace ClassLibraryInterpreter
{
    [ClassAttributeDescribe(Describe = "Определяет методы для установки значений переменных и для получения их значений")]
    public class Context
    {
        [ClassAttributeDescribe(Describe = "Определяет методы для установки значений переменных и для получения их значений")]
        Dictionary<string, int> variables;

        public Context()
        {
            variables = new Dictionary<string, int>();
        }

        [ClassAttributeDescribe(Describe = "Получаем значение переменной по ее имени")]
        public int GetVariable(string name)
        {
            return variables[name];
        }

        [ClassAttributeDescribe(Describe = "Устанавливаем значение переменной по имени")]
        public void SetVariable(string name, int value)
        {
            if (variables.ContainsKey(name))
                variables[name] = value;
            else
                variables.Add(name, value);
        }
    }
}
