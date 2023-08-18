using Newtonsoft.Json;
using N26_Amaliyot1;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace N26_Amaliyot1;

public class Task
{
    public const string PATH = @"D:\PROJECTS\BootcampN10-Level-1\N26-Amaliyot1\Tasks.txt";
    public int Id { get; set; }
    public string Description { get; set; }

    public Priority Priority { get; }

    public DateTime Deadline { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedDate { get; set; }

    public static int GetNextId()
    {
        using (var sr = new StreamReader(PATH))
        {
            var tasks = JsonSerializer.Deserialize<List<Task>>(sr.ReadToEnd());
            if (tasks.Count == 0) return 1;
            return tasks.Last().Id + 1;
        }
    }

    public Task(int id,string description, Priority priority, DateTime deadline, bool isCompleted = false)
    {
        Id = id;
        Description = description;
        Deadline = deadline;
        Priority = priority;
        IsCompleted = isCompleted;
        CreatedDate = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Id} ";
    }
}