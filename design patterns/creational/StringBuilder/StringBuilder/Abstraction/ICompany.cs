using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.Abstraction
{
    public interface ICompany
    {
        ICompany AddMyVat(int vatId);
        ICompany AddEmployee(string name, decimal salary, int ssn, int countOfChild, bool isMarried);
        ICompany CalculateExpensesEmployeeSalary();
    }
}
