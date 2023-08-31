using System.ComponentModel.DataAnnotations;

public class BlogService
{
    private List<Blog> _blogList;

    public void Create(Blog blog)
    {
        if (blog is null) throw new ArgumentNullException(nameof(blog));
        if (!IsUniqueBlog(blog)) throw new ArgumentException("Blog Is already created!");
        _blogList.Add(blog);
    }

    public void Delete(Guid id)
    {
        var foundedBlog = _blogList.FirstOrDefault(x => x.Id == id);
        if (foundedBlog == null) throw new ArgumentOutOfRangeException("Not founded!");

        _blogList.Remove(foundedBlog);
    }

    public Blog Get(Guid id)
    {
        var blog = _blogList.FirstOrDefault(b => b.Id == id);
        if (blog != null) return blog;

        throw new ArgumentOutOfRangeException(nameof(blog));
    }


    public bool IsUniqueBlog(Blog blog)
    {
        if (_blogList.Any(x =>
        x.Id == blog.Id ||
        x.Title == blog.Title ||
        x.Body == blog.Body)) return false;

        return true;
    }

    public void Update(Blog blog)
    {
        if (blog is null) throw new ValidationException(nameof(blog));
        var foundedBlog = _blogList.FirstOrDefault(x => x.Id == blog.Id);
        if (foundedBlog == null) throw new InvalidOperationException(nameof(foundedBlog));

        foundedBlog.Title = blog.Title;
        foundedBlog.Body = blog.Body;
    }
}