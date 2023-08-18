using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace N26_Amaliyot1;

public class TaskService
{
    public void AddTask(Task task)
    {
        var Tasks = new List<Task>();
        var text = File.ReadAllText(Task.PATH);
        if (string.IsNullOrEmpty(text))
        {
            Tasks = new List<Task>();
            Tasks.Add(task);
        }
        else
        {
            Tasks.Add(task);
        }


        var jsonTasks = JsonConvert.SerializeObject(Tasks, Formatting.Indented);
        File.WriteAllText(Task.PATH, jsonTasks);
    }

    public void CompleteTask(int taskId)
    {
        var Tasks = JsonSerializer.Deserialize<List<Task>>(File.ReadAllText(Task.PATH));
        Tasks[taskId - 1].IsCompleted = true;
        var jsonTasks = JsonConvert.SerializeObject(Tasks, Formatting.Indented);
        File.WriteAllText(Task.PATH, jsonTasks);
    }

    public List<Task> GetTasks(Priority priority)
    {
        var Tasks = JsonSerializer.Deserialize<List<Task>>(File.ReadAllText(Task.PATH));
        return Tasks.Where(x => x.Priority == priority).ToList();
    }
}