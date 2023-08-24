namespace N30_Amaliyot1.Models;

public class TaskItem
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public TaskItem(string description, bool isCompleted)
    {
        Id = Guid.NewGuid();
        Description = description;
        IsCompleted = isCompleted;
    }
}