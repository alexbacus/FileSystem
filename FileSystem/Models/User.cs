using FileSystem.Models.Enums;

namespace Homework.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
        public Dictionary<string, Permission> Permissions { get; set; }
        public List<Group> Groups { get; set; }

        public User CreateUser(int id, string name, Role role, Dictionary<string, Permission> permissions, List<Group> groups)
        {
            return new User
            {
                Id = id,
                Name = name,
                Role = role,
                Permissions = permissions,
                Groups = groups
            };
        }

        public User ReadUser(int id)
        {
            // check current user's permissions before executing
            return new User();
        }

        public static void UpdateUser(int id, User user)
        {
            // check current user's permissions before executing
            // update user
        }

        public static void DeleteUser(int id)
        {
            // check current user's permissions before executing
            // delete user
        }

        public void AssignPermission(int userId, string path , Permission permission)
        {
            // check current user's permissions before executing
            // find user by Id
            Permissions.Add(path, permission);
        }

        public Dictionary<string, Permission> ReadPermissions(int userId) 
        {
            // check current user's permissions before executing
            // find user by Id
            return new Dictionary<string, Permission>();
        }

        public void RemovePermission(int userId, string path)
        {
            // check current user's permissions before executing
            // find user by Id
            Permissions.Remove(path);
        }
        
        public List<Permission> ReadPermissionsForPath(string path, int userId)
        {
            // check current user's permissions before executing
            // find user by Id
            // get all associated permissions for path
            return new List<Permission>();
        }
    }
}
