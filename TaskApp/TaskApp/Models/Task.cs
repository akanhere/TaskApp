using System;
using System.Collections.Generic;
using System.Text;
using TaskApp.Common;

namespace TaskApp.Models
{
    public class Task
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public string Priority { get; set; }

        public DateTime PrefferedTime { get; set; }
        public DateTime AssignedDate { get; set; }
        public TaskStatus Status { get; set; }

        public string AssignedTo { get; set; }

        public string ClosedBy { get; set; }

        public DateTime AssignedOnDate { get; set; }
        public DateTime ClosedOnDate { get; set; }
        public string AssignedBy { get; set; }

    }
}
