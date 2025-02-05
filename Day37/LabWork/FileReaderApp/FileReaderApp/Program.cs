using System;
using System.Collections.Generic;
using System.IO;


namespace FileReaderApp
{
    
    class Program
    {
        static void Main()
        {
            
            string filePath = @"emp_duplicate - emp_duplicate.csv";           
            var jobCount = LoadAndCountEmployees(filePath);

           
            foreach (var job in jobCount)
            {
                Console.WriteLine($"{job.Key} --> {job.Value}");
            }
        }

        static Dictionary<string, int> LoadAndCountEmployees(string filePath)
        {
            
            var employeeSet = new HashSet<string>();
            var jobCount = new Dictionary<string, int>();
            var lineCount = 0;
            if (File.Exists(filePath))
            {
                var fs = new FileStream(filePath, FileMode.Open);
                var sr = new StreamReader(fs);
                while (true)
                {

                    var line = sr.ReadLine();
                    if (line == null) break;
                    var fields = line.Split(',');

                    if (fields.Length >= 2 && lineCount != 0)
                    {
                        string jobTitle = fields[2].Trim().Trim('\''); ;
                        string employeeName = fields[1].Trim().Trim('\'');
                        if (employeeSet.Add(employeeName))
                        {

                            if (!jobCount.ContainsKey(jobTitle))
                            {
                                jobCount[jobTitle] = 0;
                            }
                            jobCount[jobTitle]++;
                        }
                    }
                    lineCount++;
                }
                sr.Close();
                fs.Close();
            }
            else
            {
                Console.WriteLine("File does not exist");
                return jobCount;
            }
            
           
          

            return jobCount;
        }
    }

}
