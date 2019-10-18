using ClassLibraryAttribute;
using System.Collections.Generic;

namespace ClassLibraryMemento
{
    [ClassAttributeDescribe(Describe = "Хранит данные по настройкам героя")]
    public class GameHistory
    {
        [ClassAttributeDescribe(Describe = "Стек хранения состояний")]
        private Stack<HeroMemento> history;

        public GameHistory()
        {
            history = new Stack<HeroMemento>();
        }

        [ClassAttributeDescribe(Describe = "Добавляем в стек состояние")]
        public void SaveState(HeroMemento moment)
        {
            history.Push(moment);
        }

        [ClassAttributeDescribe(Describe = "Извлекаем из стека состояние")]
        public HeroMemento GetLastState()
        {
            if (history.Count > 1)
            {
                return history.Pop();
            }
            else
            {
                return history.Peek();
            }
        }
    }
}
