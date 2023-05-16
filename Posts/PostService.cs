using Kantar_test.Posts;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace Kantar_test.Posts
{
    public class PostService : IPostService
    {
        private readonly HttpClient _httpClient;

        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<PostItem>> GetPosts()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                var posts = JsonSerializer.Deserialize<List<PostItem>>(data);
                if (posts is null || posts.Count == 0)
                {
                    throw new InvalidOperationException("No posts found.");
                }

                return posts;
            }
            catch (Exception ex)
            {
                // Handle the default case
                throw;
            }

        }
    }
}
