var app = new ToDoList();
while (true)
{
    var commands = new[] { "d", "m", "a", "c", "e" };
    var command = default(string);
    Console.Write("Choose a command: \ndisplay all - d,\nmark down - m, \nadd - a\nscreen clear - c\nexit - e : ");
    command = Console.ReadLine();

    if (commands.Contains(command.ToLower()))
    {
        switch (command)
        {
            case "d" or "D":
                if (app.Tasks.Count > 0)
                    app.Display();
                else
                    Console.WriteLine("HEch qanday vazifa yo'q");
                break;

            case "a" or "A":
                var taskName = default(string);
                Console.WriteLine("Enter task name: ");
                taskName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(taskName))
                {
                    Console.WriteLine("Task nomini kiritmadingiz!");
                    break;
                }
                var newTask = new ToDo
                {
                    Title = taskName,
                    isDone = false
                };
                app.Tasks.Add(newTask);
                Console.WriteLine("Added!");
                break;

            case "m" or "M":
                if (app.Tasks.Count == 0) {
                    Console.WriteLine("Hech qanday vazifa yo'q");
                    break;
                }
                Console.WriteLine("CHoose which task");
                app.Display();
                var num = default(string);
                num = Console.ReadLine();
                if(int.TryParse(num, out int idx))
                {
                    if (idx <= app.Tasks.Count)
                    {
                        app.Tasks[idx-1].isDone = true;
                        app.Tasks.Remove(app.Tasks[idx - 1]);
                        Console.WriteLine("Done!");
                    }
                        
                        
                    else
                        Console.WriteLine($"{idx} - task mavjud emas!");
                }
                else
                {
                    Console.WriteLine("Siz xato malumot kiritdingiz!");
                }
                break;

            case "c" or "C":
                Console.Clear();
                break;

            case "e" or "E":
                Console.WriteLine("Good Bye!");
                return;
        }
    }
    else
    {
        Console.WriteLine("Command not found, Please try again.");
    }
}


public class ToDo
{
    public string Title;
    public bool isDone;
}

public class ToDoList
{
    public List<ToDo> Tasks = new List<ToDo>();

    public void Display()
    {
        var num = 1;
        foreach(ToDo toDo in Tasks)
        {
            Console.WriteLine($"{num}. {toDo.Title}");
            num++;
        }
    }
    
}