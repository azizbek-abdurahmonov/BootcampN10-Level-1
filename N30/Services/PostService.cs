using System.Diagnostics;
using N30.Models;

namespace N30.Services;

public class PostService
{
    private readonly List<Post> _posts = new();

    public Task<List<Post>> GetPostAsync()
    {
        return Task.FromResult(_posts);
    }
}