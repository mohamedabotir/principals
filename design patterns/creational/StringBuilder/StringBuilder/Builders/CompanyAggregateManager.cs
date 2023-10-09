using StringBuilder.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.Builders
{
    public class CompanyAggregateManager : IBuilderManager<ExpenseBuilder, CompanyBuilder>
    {
        ExpenseBuilder IBuilderManager<ExpenseBuilder, CompanyBuilder>.New => new ExpenseBuilder();
    }
}
