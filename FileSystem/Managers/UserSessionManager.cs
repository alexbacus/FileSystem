using Homework.Interfaces;
using Homework.Models;

namespace Homework.Managers
{
    public class UserSessionManager : IUserSessionManager
    {
        private UserSession activeSession;

        public UserSession GetActiveSession()
        {
            if (activeSession == null)
            {
                activeSession = new UserSession();
            }
            return activeSession;
        }
    }
}
