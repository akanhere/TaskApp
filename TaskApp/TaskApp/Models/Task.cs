using System;
using System.Collections.Generic;
using System.Text;

namespace TaskApp.Models
{
    public class Task
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime AssignedDate { get; set; }
    }
}
