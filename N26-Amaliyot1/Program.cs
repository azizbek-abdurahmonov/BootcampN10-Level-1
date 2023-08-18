using N26_Amaliyot1;
using Task = N26_Amaliyot1.Task;

var service = new TaskService();



service.AddTask(new Task(Task.GetNextId(), "qanaqadir task", Priority.Low, DateTime.MaxValue, false));
service.AddTask(new Task(Task.GetNextId(), "qanaqadir task - 2", Priority.High, DateTime.Now.AddHours(50)));

// service.CompleteTask(2);

// service.GetTasks(Priority.Low).ForEach(Console.WriteLine);