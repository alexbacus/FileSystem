using Homework.Interfaces;
using Homework.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserManager userManager;
        private IUserSessionManager userSessionManager;

        public UserController(IUserManager userManager, IUserSessionManager userSessionManager)
        {
            this.userSessionManager = userSessionManager;
            this.userManager = userManager;
        }

        [HttpPost("login")]
        public ActionResult Login(User user)
        {
            UserSession session = userSessionManager.GetActiveSession();

            session.Login(user);

            return this.NoContent();
        }
    }
}
