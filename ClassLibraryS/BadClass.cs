using ClassLibraryAttribute;
using System;

namespace ClassLibraryS
{
    [ClassAttributeDescribe(Describe = "Плохой класс, вся логика в одном месте")]
    public class BadClass
    {
        [ClassAttributeDescribe(Describe = "Имя пользователя")]
        protected string login;
        [ClassAttributeDescribe(Describe = "Пароль")]
        string password;

        [ClassAttributeDescribe(Describe = "Поиск пользователя по логину и паролю")]
        public void setUser(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

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
