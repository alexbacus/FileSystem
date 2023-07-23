namespace Homework
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileSystem fileSystem = new();
            fileSystem.Startup();
            fileSystem.Instantiate();
        }
    }
}
