using Homework.Models;

namespace Homework.Interfaces
{
    public interface IUserSessionManager
    {
        public UserSession GetActiveSession();
    }
}
