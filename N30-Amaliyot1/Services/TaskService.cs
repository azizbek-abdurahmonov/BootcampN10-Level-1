using System.Text.Json;
using N30_Amaliyot1.Models;
using TaskItem = N30_Amaliyot1.Models.TaskItem;

namespace N30_Amaliyot1.Services;

public class TaskService
{
    private List<TaskItem> _tasks;

    public TaskService()
    {
        File.Create("tasks.json").Close();
        _tasks = JsonSerializer.Deserialize<List<TaskItem>>(File.ReadAllText("tasks.json"));
    }

    public async Task<List<TaskItem>> AddTaskAsync(List<TaskItem> task)
    {
        var _tasks = JsonSerializer.Deserialize<List<TaskItem>>(File.ReadAllText("tasks.json"));
        _tasks.AddRange(task);
        return _tasks;
    }

    public void CompleteTask(TaskItem task)
    {
        var find = _tasks.FirstOrDefault(x => x.Id == task.Id);
        if (find != null)
            find.IsCompleted = true;
    }

    public async Task SaveTasksAsync(List<TaskItem> tasks)
    {
        var result = await AddTaskAsync(tasks);
        File.WriteAllText("tasks.json", JsonSerializer.Serialize(result));
    }
}