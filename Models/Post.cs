using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models
{
    internal class Post : IRequestable
    {
        public int userId { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
