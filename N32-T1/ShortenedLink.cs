namespace N32_T1;

public class ShortenedLink
{
    public Guid Id { get; set; }
    public string OriginalUrl { get; set; }
    public string ShortenedUrl { get; set; }

    public override int GetHashCode()
    {
        return this.OriginalUrl.GetHashCode() + this.ShortenedUrl.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        return obj.GetHashCode() == this.GetHashCode();
    }

    public ShortenedLink(string originalUrl, string shortenedUrl)
    {
        Id = Guid.NewGuid();
        OriginalUrl = originalUrl;
        ShortenedUrl = shortenedUrl;
    }
}