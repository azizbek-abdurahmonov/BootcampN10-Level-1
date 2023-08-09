using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_Task1
{
    internal class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks { get; set; }

        public Project(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            Tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
    }
}
