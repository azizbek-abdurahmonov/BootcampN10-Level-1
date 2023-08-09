using N21_Task1;

var system = new TaskManagerSystem();
var developer1 = new Developer(1, "abdura", "abdura", "azizbek@gmail.com", isAdmin: true);

while (true)
{
    Console.WriteLine("1. Kirish\n2.Chiqish: ");
    var Res = Console.ReadLine();

    switch (Res)
    {
        case "1":
            string username, password;
            Console.WriteLine("Username kiriting: ");
            username = Console.ReadLine();

            Console.WriteLine("Password kiriting: ");
            password = Console.ReadLine();


            if (system.CheckUser(username, password))
            {
                while (true)
                {
                    Console.WriteLine("1.Project yaratish\n2.Task yaratish\n3.User yaratish\n4.Notification jo'natish5.Log out");
                    Res = Console.ReadLine();

                    //Check log out
                    if (Res == "5")
                        break;


                    switch (Res)
                    {
                        case "1":
                            int id;
                            string title, description;

                            Console.WriteLine("Project ID sini kiriting: ");
                            id = int.Parse(Console.ReadLine());

                            Console.WriteLine("Title kiriting: ");
                            title = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(title))
                            {
                                Console.WriteLine("Title yaroqsiz!");
                                break;
                            }

                            Console.WriteLine("Description kiriting: ");
                            description = Console.ReadLine();
                            if (string.IsNullOrEmpty(description))
                            {
                                Console.WriteLine("Desc yaroqsiz!");
                                break;
                            }

                            system.CreateProject(new Project(id, title, description));
                            Console.WriteLine("Qo'shildi!");
                            break;

                        case "2":
                            if (system.ShowProjects())
                            {
                                Console.WriteLine("Task qo'shmoqchi bo'lgan proyektingizni ID sini kiriting: ");
                                id = int.Parse(Console.ReadLine());
                                var project = system.GetProject(id);

                                Console.WriteLine("Task ID sini kiriting: ");
                                var taskID = int.Parse(Console.ReadLine());

                                Console.WriteLine("Task title kiriting: ");
                                var taskTitle = Console.ReadLine();

                                Console.WriteLine("Task Desc kiriting: ");
                                var taskDesc = Console.ReadLine();

                                Console.WriteLine("Deadline kiriting: yyyy-MM-dd :");
                                DateTime deadline = DateTime.Parse(Console.ReadLine());

                                project.AddTask(new N21_Task1.Task(taskID, taskTitle, taskDesc, deadline));

                            }

                            break;

                        case "3":
                            Console.WriteLine("Yangi user ID sini kiriting: ");
                            var userID = int.Parse(Console.ReadLine());

                            Console.WriteLine("Username kiriting: ");
                            var userName = Console.ReadLine();

                            Console.WriteLine("Password kiriting: ");
                            var userPass = Console.ReadLine();

                            Console.WriteLine("Email kiriting: ");
                            var userEmail = Console.ReadLine();

                            Console.WriteLine("U Adminmi? y/n");
                            var userIsAdmin = Console.ReadLine().ToLower() == "y" ? true : false;

                            system.AddUser(new Developer(userID, userName, userPass, userEmail, userIsAdmin));
                            break;

                        case "4":
                            //
                            break;

                    }
                }


            }
            else
            {
                Console.WriteLine("User topilmadi!");
            }


            break;

        case "2":
            Console.WriteLine("Good Bye!");
            return;
    }
}