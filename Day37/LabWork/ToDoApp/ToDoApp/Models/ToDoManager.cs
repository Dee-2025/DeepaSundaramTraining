using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class ToDoManager
    {
        public ToDoManager() {
            list = new List<ToDo>();
        }
        public List<ToDo> list ;
        public void AddToDo(ToDo toDo) { 
            list.Add(toDo);
        }
        public List<ToDo> GetToDos() {
            return list;
        }
        public void RemoveToDoById(int id) {
            list.RemoveAll(x => x.Id == id);
        }

        public void MarkComplete(int id) {
            ToDo toDo = list.Find(x => x.Id == id);
            toDo.IsComplete = true;
        }

            
    }
}
