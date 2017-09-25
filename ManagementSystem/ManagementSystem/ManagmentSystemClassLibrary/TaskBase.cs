using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementSystem
{
    public abstract class TaskBase
    {
        public long Id { get; set; }
        public string NameOfTask { get; set; }
        public string DiscriptionOfTask { get; set; }
        public int Priority { get; set; }
        public string ToWhatCategory { get; set; }
        public DateTime Deadline { get; set; }
        public long MyUserId { get; set; }
        public bool IsDone { get; set; }
    }
}