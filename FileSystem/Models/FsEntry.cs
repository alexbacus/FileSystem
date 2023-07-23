using FileSystem.Models.Enums;

namespace Homework.Models
{
    public abstract class FsEntry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public User User { get; set; }
        public List<Permission> Permissions { get; set; }
        public FsEntry Parent { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
