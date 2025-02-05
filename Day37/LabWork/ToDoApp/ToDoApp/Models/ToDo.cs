using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsComplete;
        public PriorityLevel Priority { get; set; }
        public enum PriorityLevel
        {
            Low,
            Medium,
            High
        }
    }
}
