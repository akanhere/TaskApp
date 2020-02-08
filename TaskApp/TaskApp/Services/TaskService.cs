using System;
using System.Collections.Generic;
using System.Text;
using TaskApp.Models;

namespace TaskApp.Services
{
    public class TaskService
    {
        private static TaskService _instance;

        public static TaskService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TaskService();
                }
                return _instance;
            }
        }

        public List<Task> GetTasks()
        {
            return new List<Task>
            {
                new Task {Name="Plumbing Task", AssignedDate = DateTime.Now, Category="General"},
                new Task {Name="Carpentary Task", AssignedDate=DateTime.Now, Category="General"},
                new Task {Name="Electrical Task", AssignedDate = DateTime.Now, Category="General"},
                new Task {Name="Janitory Task", AssignedDate=DateTime.Now, Category="General"},
                new Task {Name="Gardening Task", AssignedDate = DateTime.Now, Category="General"},
                new Task {Name="Masonary Task", AssignedDate=DateTime.Now, Category="General"}
            };
        }
    }
}
