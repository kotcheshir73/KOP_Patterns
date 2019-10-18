using ClassLibraryAttribute;
using System;

namespace ClassLibraryObserver
{
    [ClassAttributeDescribe(Describe = "Наблюдатель")]
    public interface IObserver
    {
        [ClassAttributeDescribe(Describe = "Реакция на изменения")]
        string Update(Object ob);
    }
}
