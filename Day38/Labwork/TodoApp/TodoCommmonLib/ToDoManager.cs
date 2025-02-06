using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ToDoApp.Models
{
    public class ToDoManager
    {
        public ToDoManager() {
            list = new List<ToDo>();
        }
        public List<ToDo> list ;
        public void AddToDo(ToDo toDo)
        {
            list.Add(toDo);
        }
        public List<ToDo> GetToDos()
        {
            return list;
        }
        public void RemoveToDoById(int id)
        {
            list.RemoveAll(x => x.Id == id);
        }

        public void MarkComplete(int id)
        {
            ToDo toDo = list.Find(x => x.Id == id);
            toDo.IsComplete = true;
        }
        public static void SerializeToFile(ToDo appData, string fileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ToDo));

                // Serialize the object to XML
                using (StringWriter writer = new StringWriter())
                {
                    serializer.Serialize(writer, appData);
                    string xmlOutput = writer.ToString();
                    var sw = new StreamWriter(@"Todo.txt");
                    sw.WriteLine(xmlOutput);
                    sw.Close();
                    Console.WriteLine("Serialized XML:\n" + xmlOutput);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during serialization: {ex.Message}");
            }
        }

        public static ToDo DeserializeFromFile(string fileName)
        {
            ToDo toDo = new ToDo();
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ToDo));               

                using (StringReader reader = new StringReader(fileName))
                {
                     toDo = (ToDo)serializer.Deserialize(reader);

                   
                }
                return toDo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during deserialization: {ex.Message}");
                return null;
            }
        }

    }
}
