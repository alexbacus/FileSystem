using FileSystem.Models.Enums;
using Homework.Models;

namespace Homework.Interfaces
{
    public interface IUserManager
    {
        User ReadUser(int id);

        void UpdateUser(int id, User user);

        void DeleteUser(int id);

        void AssignPermission(int userId, string path, Permission permission);

        Dictionary<string, Permission> ReadPermissions(int userId);

        void RemovePermission(int userId, string path);

        List<Permission> ReadPermissionsForPath(string path, int userId);
    }
}
