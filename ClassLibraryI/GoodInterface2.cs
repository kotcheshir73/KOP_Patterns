using ClassLibraryAttribute;
using System;

namespace ClassLibraryI
{
    [ClassAttributeDescribe(Describe = "Хороший интерфейс 2, отвечает за работу с БД")]
    public interface GoodInterface2
    {
        [ClassAttributeDescribe(Describe = "Подсоединение к БД")]
        void CreateConnectToBD(string connectionStr);

        [ClassAttributeDescribe(Describe = "Сохранение данных в БД")]
        bool saveData(Object data);
    }
}
