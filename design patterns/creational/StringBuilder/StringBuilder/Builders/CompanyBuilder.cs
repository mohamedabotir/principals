using StringBuilder.Abstraction;
using StringBuilder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.Builders
{
    public class CompanyBuilder : ICompany
    {
        protected  Company _company = new Company();
        private decimal TotalNetSalaries { get; set; }

        public ICompany AddEmployee(string name, decimal salary, int ssn, int countOfChild, bool isMarried)
        {
            _company.CreateEmployee(name, salary, ssn, countOfChild, isMarried);
            return this;
        }

        public ICompany AddMyVat(int vatId)
        {
            _company.VatId = vatId;
            return this;
        }

        public ICompany CalculateExpensesEmployeeSalary()
        {
            TotalNetSalaries= _company.Employees.Sum(e => e.NetSalary);
            return this;
        }

        public override string ToString()
        {
            CalculateExpensesEmployeeSalary();
            return @$"Company VatId {_company.VatId} with Total Employee {_company.EmployeeCount} , Total Expenses Salaries {TotalNetSalaries}";
        }
    }
}
