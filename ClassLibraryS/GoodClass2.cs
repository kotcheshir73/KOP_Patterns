using ClassLibraryAttribute;
using System;

namespace ClassLibraryS
{
    [ClassAttributeDescribe(Describe = "Хороший класс2. Раотает с БД")]
    public class GoodClass2
    {
        [ClassAttributeDescribe(Describe = "Строчка подключения к БД")]
        string connectionToBD;

        [ClassAttributeDescribe(Describe = "Подсоединение к БД")]
        public void CreateConnectToBD(string connectionStr)
        {
            this.connectionToBD = connectionStr;
        }

        [ClassAttributeDescribe(Describe = "Сохранение данных в БД")]
        public bool saveData(Object data)
        {
            if (data != null)
            {
                return true;
            }
            return false;
        }
    }
}
