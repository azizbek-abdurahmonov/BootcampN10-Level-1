using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_Task1
{
    internal class Developer
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

        public List<Task> Tasks;
        public List<string> Comments;

        public Developer(int id, string username, string password, string email, bool isAdmin = false)
        {
            Id = id;
            UserName = username;
            Password = password;
            Email = email;
            IsAdmin = isAdmin;
            Tasks = new List<Task>();
            Comments = new List<string>();
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
    }
}
