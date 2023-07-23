using FileSystem.Models.Enums;

namespace Homework.Models
{
    public class Directory : FsEntry
    {
        public List<FsEntry> Children { get; set; }

        public static Directory CreateDirectory(string name, int id, User user, FsEntry parent, List<Permission> permissions)
        {
            return new Directory
            {
                Name = name,
                Id = id,
                User = user,
                Parent = parent,
                Permissions = permissions
            };
        }

        public static Directory ReadDirectory(string path)
        {
            // check current user's permissions for path before executing
            return new Directory();
        }

        public static void UpdateDirectory(string name, Directory directory)
        {
            // check current user's permissions for path before executing
            // update directory
        }

        public static void DeleteDirectory(string name)
        {
            // check current user's permissions for path before executing
            // delete directory
        }
    }
}
