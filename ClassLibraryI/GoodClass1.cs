using System;

namespace ClassLibraryI
{
    public class GoodClass1 : GoodInterface1
    {
        public int getUserRole(string login)
        {
            throw new NotImplementedException();
        }

        public void setUser(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
