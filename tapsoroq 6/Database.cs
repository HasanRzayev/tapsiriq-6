using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsoroq_6
{
    class Database
    {
        public Admin.Admin[] admin=new Admin.Admin[] { };
        public User.User[] users = new User.User[] { };
        public void AddAdmin(Admin.Admin c)
        {
            Array.Resize(ref admin, admin.Length + 1);
            admin[admin.Length - 1] = c;
        }

        public void AddUser(User.User c)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = c;
        }

        public bool CheckAdmin(string username,string password)
        {
            for (int i = 0; i < admin.Length; i++)
            {
                if (admin[i].username == username && admin[i].password == password) return true;
            }
            return false;
        }
        public int CheckUser(string name, string password)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].name == name && users[i].password == password) return i;
            }
            return -1;
        }
       
    }
}
