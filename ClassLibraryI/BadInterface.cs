using ClassLibraryAttribute;
using System;

namespace ClassLibraryI
{
    [ClassAttributeDescribe(Describe = "Плохой интерфейс, отвечает много за что")]
    public interface BadInterface
    {
        [ClassAttributeDescribe(Describe = "Поиск пользователя по логину и паролю")]
        void setUser(string login, string password);

        [ClassAttributeDescribe(Describe = "Получение роли пользователя по логину")]
        int getUserRole(string login);

        [ClassAttributeDescribe(Describe = "Подсоединение к БД")]
        void CreateConnectToBD(string connectionStr);

        [ClassAttributeDescribe(Describe = "Сохранение данных в БД")]
        bool saveData(Object data);
    }
}
