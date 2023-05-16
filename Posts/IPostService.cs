namespace Kantar_test.Posts
{
    public interface IPostService
    {
        Task<List<PostItem>> GetPosts();
    }
}
