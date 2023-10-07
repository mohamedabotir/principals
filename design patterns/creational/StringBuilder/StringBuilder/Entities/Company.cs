using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.Entities
{
    internal class Company
    {
        public int VatId { get; set; }
        public decimal TotalExpense { get; set; }
        public int EmployeeCount { get; set; }

        private Lazy<List<Employee>> _employees;

        public  void CreateEmployee(string name, decimal salary, int ssn, int countOfChild, bool isMarried) { 
        if (!_employees.IsValueCreated) {
                _employees.Value.Add(Employee.Create(name, salary, ssn, countOfChild, isMarried));
            }
           else
        _employees = new Lazy<List<Employee>>(new List<Employee>() {
            Employee.Create(name, salary, ssn, countOfChild, isMarried) });
        }

    }
    class Employee
    {
        public string Name { get; set; }
        public int SSN { get; set; }
        public decimal Salary { get; set; }
        public int CountOfChild { get; set; }
        public bool IsMarried { get; set; }
        private int IndexScore { get; set; }
        public double Vat { get { return CalculateVat(); } }

        private double CalculateVat()
        {
            IndexScore += IsMarried ? 10 : 20;
            IndexScore += CountOfChild>1 ? 15 : 20;
            return 100 / IndexScore;
        }
        public static Employee Create(string name, decimal salary, int ssn, int countOfChild, bool isMarried)
        {
            return new Employee( name,  salary,  ssn,  countOfChild,  isMarried);
        }

        private Employee(string name , decimal salary,int ssn ,int countOfChild,bool isMarried )
        {
            Name = name;
            Salary = salary;
            SSN = ssn;
            CountOfChild = countOfChild;
            IsMarried = isMarried;
        }
    }
}
