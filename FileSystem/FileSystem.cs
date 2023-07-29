using FileSystem.Models.Enums;
using Homework.Models;
using Directory = Homework.Models.Directory;

namespace Homework
{
    public class FileSystem
    {
        private Directory Root;
        List<User> Users = new List<User>();

        public FileSystem()
        {
            User system = new()
            {
                Id = 0,
                Name = "System",
                Role = Role.Admin
            };

            Users.Add(system);

            Root = Directory.CreateDirectory("/", 0, system, null, new List<Permission> { Permission.Read });
        }

        public void Startup()
        {
            // perform startup tasks
        }

        public void Instantiate()
        {
            // instantiate the file system
        }
    }
}
