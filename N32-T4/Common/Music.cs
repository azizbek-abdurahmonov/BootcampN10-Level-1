namespace N32_T4.Model;

public class Music
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string SingerName { get; set; }

    public Music(string name, string singerName)
    {
        Id = Guid.NewGuid();
        Name = name;
        SingerName = singerName;
    }
}