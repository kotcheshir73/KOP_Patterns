using ClassLibraryAttribute;
using System;

namespace ClassLibraryCommand
{
    [ClassAttributeDescribe(Describe = "Receiver - Получатель (звук)")]
    public class Volume
    {
        public const int OFF = 0;
        public const int HIGH = 20;
        private int level;

        public Volume()
        {
            level = OFF;
        }

        [ClassAttributeDescribe(Describe = "Увеличиваем звук")]
        public string RaiseLevel()
        {
            if (level < HIGH)
            {
                level++;
            }
            return String.Format("Уровень звука {0}", level);
        }

        [ClassAttributeDescribe(Describe = "Уменьшаем звук")]
        public string DropLevel()
        {
            if (level > OFF)
            {
                level--;
            }
            return String.Format("Уровень звука {0}", level);
        }
    }
}
