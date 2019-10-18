using System;

namespace ClassLibraryI
{
    public class BadClass : BadInterface
    {
        public void CreateConnectToBD(string connectionStr)
        {
            throw new NotImplementedException();
        }

        public int getUserRole(string login)
        {
            throw new NotImplementedException();
        }

        public bool saveData(object data)
        {
            throw new NotImplementedException();
        }

        public void setUser(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
