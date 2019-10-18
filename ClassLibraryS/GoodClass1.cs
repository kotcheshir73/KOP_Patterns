using ClassLibraryAttribute;

namespace ClassLibraryS
{
    [ClassAttributeDescribe(Describe = "Хороший класс1. Работает с пользователем")]
    public class GoodClass1
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
    }
}
