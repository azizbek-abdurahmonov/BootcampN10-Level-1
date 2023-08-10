using N21_Task1;

var system = new TaskManagerSystem();
var developer1 = new Developer(1, "abdura", "abdura", "abdura52.uz@gmail.com", isAdmin: true);

system.AddUser(developer1);

var developer2 = new Developer(2, "user", "user", "abdura52.uz@gmail.com");
system.AddUser(developer2);


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


            if (system.CheckProjectManager(username, password))
            {
                while (true)
                {
                    Console.WriteLine("1.Project yaratish\n2.Task yaratish\n3.User yaratish\n4.Notification jo'natish\n5.Developerlarga task berish\n6.Log out");
                    Res = Console.ReadLine();

                    //Check log out
                    if (Res == "6")
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
                                var projectB = system.GetProject(id);

                                Console.WriteLine("Task ID sini kiriting: ");
                                var taskIDB = int.Parse(Console.ReadLine());

                                Console.WriteLine("Task title kiriting: ");
                                var taskTitle = Console.ReadLine();

                                Console.WriteLine("Task Desc kiriting: ");
                                var taskDesc = Console.ReadLine();

                                Console.WriteLine("Deadline kiriting: yyyy-MM-dd :");
                                DateTime deadline = DateTime.Parse(Console.ReadLine());

                                projectB.AddTask(new N21_Task1.Task(taskIDB, taskTitle, taskDesc, deadline));

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
                            system.ShowUsers();
                            Console.WriteLine("Notification jo'natmoqchi bo'lgan developeringizni ID sini kiriting: ");
                            var IdForNotification = int.Parse(Console.ReadLine());
                            var UserForNotification = system.getUser(IdForNotification);

                            Console.WriteLine("Notification message sini kiriting: ");
                            var NotificationMessage = Console.ReadLine();
                            Console.WriteLine("Kuting..");
                            try
                            {
                                system.SendEmail(new Notification(UserForNotification, NotificationMessage, DateTime.Now));
                                Console.WriteLine("Yuborildi!");
                            }
                            catch
                            {
                                Console.WriteLine("Yuborish vaqtida xatolik bo'ldi!");
                            }
                            break;
                        case "5":
                            system.ShowUsers();
                            Console.WriteLine("USER Id sini kiriting: ");
                            var projectID = int.Parse(Console.ReadLine());
                            var project = system.GetProject(projectID);

                            var rres = system.ShowTasks(project);
                            if (!rres) break;
                            Console.WriteLine("Task Id sini kiriting: ");
                            var taskID = int.Parse(Console.ReadLine());
                            var task = system.GetTask(project, taskID);

                            system.ShowUsers();
                            Console.WriteLine("Qaysi developerga biriktirmoqchisiz? ");
                            userID = int.Parse(Console.ReadLine());
                            var developer = system.getUser(userID);
                            developer.AddTask(task);

                            break;
                    }
                }


            }
            else if (system.checkUser(username, password))
            {
                while (true)
                {

                    Console.WriteLine("1.Tasklarni ko'rish\n2.Taskni bajarilganligini kiritish\n3.Password o'zgartirish\n4.Log out");
                    Res = Console.ReadLine();

                    var Me = system.GetUserFromUsername(username);
                    if (Res == "4")
                        break;

                    switch (Res)
                    {
                        case "1":
                            system.ShowDeveloperTasks(Me);
                            break;

                        case "2":
                            system.ShowDeveloperTasks(Me);
                            Console.WriteLine("Task Id sini kiriting: ");
                            system.ChangeComplete(Me, int.Parse(Console.ReadLine()));
                            Console.WriteLine("Task bajarildi  deb belgilandi");
                            break;
                        case "3":
                            Console.WriteLine("Yangi password kiriting: ");
                            var newPass = Console.ReadLine();

                            Me.Password = newPass;
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