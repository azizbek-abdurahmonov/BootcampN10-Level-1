using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace N21_Task1
{
    internal class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }
        public List<string> Comments;

        public Task(int id, string title, string desciption, DateTime deadline, bool isCompleted = false)
        {
            Id = id;
            Title = title;
            Description = desciption;
            Deadline = deadline;
            Comments = new List<string>();

        }
    }
}
