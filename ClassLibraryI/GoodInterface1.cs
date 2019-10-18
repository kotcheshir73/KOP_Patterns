using ClassLibraryAttribute;

namespace ClassLibraryI
{
    [ClassAttributeDescribe(Describe = "Хороший интерфейс 1, отвечает за работу с пользователями")]
    public interface GoodInterface1
    {
        [ClassAttributeDescribe(Describe = "Поиск пользователя по логину и паролю")]
        void setUser(string login, string password);

        [ClassAttributeDescribe(Describe = "Получение роли пользователя по логину")]
        int getUserRole(string login);
    }
}
