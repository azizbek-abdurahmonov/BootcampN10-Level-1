using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_Task1
{
    internal class TaskManagerSystem
    {
        private List<Developer> users;
        private List<Project> projects;

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
        public bool CheckUser(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.UserName == username && user.Password == password)
                {
                    return true;
                }
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
    }
}
