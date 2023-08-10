using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace N21_Task1
{
    internal class TaskManagerSystem
    {
        private List<Developer> users;
        private List<Project> projects;

        public TaskManagerSystem()
        {
            users = new List<Developer>();
            projects = new List<Project>();
        }

        public void CreateProject(Project project)
        {
            projects.Add(project);
        }

        public void AddUser(Developer user)
        {
            users.Add(user);
        }

        public void CreateTask(Project project, Task task)
        {
            project.AddTask(task);
        }


        // other methods
        public bool CheckProjectManager(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.UserName == username && user.Password == password && user.IsAdmin == true)
                {
                    return true;
                }
            }

            return false;
        }

        public bool checkUser(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.UserName == username && user.Password == password && user.IsAdmin == false)
                    return true;
            }
            return false;
        }


        public bool ShowProjects()
        {
            if (projects.Count > 0)
            {
                foreach (var project in projects)
                {
                    Console.WriteLine($"ID: {project.Id}\nTitle: {project.Title}\nDesc: {project.Description}\n");
                }
                return true;
            }
            else
            {
                Console.WriteLine("Hech qanday project mavjud emas");
                return false;
            }
        }

        public Project GetProject(int id)
        {
            foreach (var project in projects)
            {
                if (project.Id == id)
                    return project;
            }
            return null;
        }

        public bool ShowTasks(Project project)
        {
            if (projects.Count > 0)
            {

                foreach (var task in project.Tasks)
                {
                    Console.WriteLine($"{task.Id} - {task.Title} - {task.Description}");
                }
                return true;
            }
            else
            {
                Console.WriteLine("Hech qanday task yo'q");
                return false;
            }
        }

        public Developer GetUserFromUsername(string username)
        {
            foreach (var user in users)
            {
                if (user.UserName == username)
                    return user;
            }
            return null;
        }

        public void ShowDeveloperTasks(Developer deve)
        {
            foreach (var item in deve.Tasks)
            {
                Console.WriteLine($"{item.Id}.{item.Title} - {item.Description}");
            }
        }

        public void ChangeComplete(Developer dev, int id)
        {
            foreach (var task in dev.Tasks)
            {
                if (task.Id == id)
                {
                    task.IsCompleted = true;
                    dev.Tasks.Remove(task);
                }
            }
        }

        public Task GetTask(Project project, int id)
        {
            foreach (var task in project.Tasks)
            {
                if (task.Id == id)
                {
                    return task;
                }
            }
            return null;
        }

        public void ShowUsers()
        {
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id}, {user.UserName}");
            }
        }

        public Developer getUser(int id)
        {
            foreach (var user in users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public bool SendEmail(Notification notification)
        {
            try
            {
                var senderEmail = "abdura52.uz@gmail.com";
                var senderPassword = "ucuhmntddpjlxhzf";

                var mail = new MailMessage(senderEmail, notification.Recipient.Email);
                mail.Subject = "New Notification";
                mail.Body = notification.Message;

                var smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
