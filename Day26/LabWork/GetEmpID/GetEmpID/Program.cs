
using GetEmpID.Models;
using System;

namespace GetEmpID
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Employee("Deepa");
            PrintDetails(emp1);

            var emp2 = new Employee("mathi");
            PrintDetails(emp2);
            Console.WriteLine($"Head Count: {Employee.HeadCount}");
            var emp3 = new Employee("Sachin");
            PrintDetails(emp3);
            PrintDetails(emp1);
            PrintDetails(emp2);

            var emp4 = new Employee("Prem");
            PrintDetails(emp4);
            Console.WriteLine($"Head Count: {Employee.HeadCount}");

        }

        public static void PrintDetails(Employee emp)
        {
            Console.WriteLine($"Employee Name: {emp.EmpName}");
            Console.WriteLine($"Employee ID: {emp.EmpId}");
            //Console.WriteLine($"Head Count: {Employee.HeadCount}");
            Console.WriteLine();
        }
    }
}