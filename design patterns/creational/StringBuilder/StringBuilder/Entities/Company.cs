using StringBuilder.Abstraction;
using StringBuilder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.Entities
{
    public class Company
    {
        public int VatId { get; set; }
        public decimal TotalExpense { get; set; }
        public int EmployeeCount { get { return _employees.Value.Count; } }



        private Lazy<List<Employee>> _employees = new Lazy<List<Employee>>(new List<Employee>());
        public IReadOnlyCollection<Employee> Employees{ get { return _employees.Value; } }
        public  void CreateEmployee(string name, decimal salary, int ssn, int countOfChild, bool isMarried) { 
        if (_employees.IsValueCreated) {
                _employees.Value.Add(Employee.Create(name, salary, ssn, countOfChild, isMarried));
            }
           else
        _employees = new Lazy<List<Employee>>(new List<Employee>() {
            Employee.Create(name, salary, ssn, countOfChild, isMarried) });
        }



    }
    public class Employee
    {
        public string Name { get; set; }
        public int SSN { get; set; }
        public decimal Salary { get; set; }
        public int CountOfChild { get; set; }
        public bool IsMarried { get; set; }
        private int IndexScore { get; set; }
        public double Vat { get { return CalculateVat(); } }

        public decimal NetSalary { get { return (Salary - (decimal)Vat * Salary ); }  }
        private double CalculateVat()
        {
            IndexScore += IsMarried ? 10 : 20;
            IndexScore += CountOfChild>1 ? 15 : 20;
            return   IndexScore/ 100.0;
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
