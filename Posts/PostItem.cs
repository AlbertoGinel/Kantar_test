using Microsoft.AspNetCore.Components;

namespace Kantar_test.Posts
{
    public class PostItem
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string? title { get; set; }
        public string? body { get; set; }
    }
}