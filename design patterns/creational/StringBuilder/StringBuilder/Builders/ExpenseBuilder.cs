using StringBuilder.Abstraction;
using StringBuilder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.Builders
{
    internal class ExpenseBuilder : IBuilder<CompanyBuilder>
    {
        private Company company;

         
        public CompanyBuilder Build()
        {
            return new CompanyBuilder();
        }
          
    }
}
