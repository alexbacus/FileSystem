using FileSystem.Models.Enums;
using Homework.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Directory = Homework.Models.Directory;

namespace Homework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoryController : ControllerBase
    {
        private IUserSessionManager userSessionManager;
        private IUserManager userManager;
        private IDirectoryManager directoryManager;

        public DirectoryController(IUserSessionManager userSessionManager, IUserManager userManager, IDirectoryManager directoryManager)
        {
            this.userSessionManager = userSessionManager;
            this.userManager = userManager;
            this.directoryManager = directoryManager;
        }

        [HttpGet]
        public ActionResult<Directory> ReadDirectory(string path)
        {
            var currentSession = userSessionManager.GetActiveSession();
            var permissions = this.userManager.ReadPermissionsForPath(path, currentSession.CurrentUser.Id);

            if (permissions.Contains(Permission.Read))
            {
                return this.Ok(directoryManager.ReadDirectory(path));
            }
            else
            {
                return this.Unauthorized($"Current user does not have read permissions for {path}");
            }
        }

        [HttpPost]
        public ActionResult<Directory> CreateDirectory(Directory directory, string parentPath)
        {
            var currentSession = userSessionManager.GetActiveSession();
            var userPermissions = this.userManager.ReadPermissionsForPath(parentPath, currentSession.CurrentUser.Id);

            if (userPermissions.Contains(Permission.Create))
            {
                var parent = directoryManager.ReadDirectory(parentPath);
                return this.Ok(directoryManager.CreateDirectory(directory.Name, directory.Id, currentSession.CurrentUser, parent, directory.Permissions, directory.Path));
            }
            else
            {
                return this.Unauthorized($"Current user does not have create permissions for {parentPath}");
            }
        }

        [HttpPut]
        public ActionResult UpdateDirectoryPermissions(List<Permission> permissions, string directoryPath)
        {
            var currentSession = userSessionManager.GetActiveSession();
            var userPermissions = this.userManager.ReadPermissionsForPath(directoryPath, currentSession.CurrentUser.Id);

            if (userPermissions.Contains(Permission.Write))
            {
                directoryManager.UpdateDirectoryPermissions(permissions, directoryPath);
                return this.NoContent();
            }
            else
            {
                return this.Unauthorized($"Current user does not have write permissions for {directoryPath}");
            }
        }
    }
}
