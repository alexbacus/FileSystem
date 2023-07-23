using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Models
{
    public class UserSession
    {
        private static UserSession instance;

        public static UserSession Instance ()
        {
            if (instance == null)
            {
                instance = new UserSession();
            }
            return instance;
        }

        public User CurrentUser { get; private set; }

        private UserSession()
        {

        }

        public void Login(User user)
        {
            CurrentUser = user;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }

}
