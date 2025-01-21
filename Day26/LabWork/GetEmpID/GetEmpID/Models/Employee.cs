using System;

namespace GetEmpID.Models
{
    class Employee
    {
        private readonly int _empId;
        private readonly string _empName;
        private static int _counter = 1000;

        public Employee(string empName)
        {
            _empName = empName;
            _empId = ++_counter;
        }

        public string EmpName
        {
            get { return _empName; }
        }
        public string EmpId
        {
            get { return $"E{_empId}"; }
        }
        public static int HeadCount
        {
            get { return _counter; }
        }
    }
}