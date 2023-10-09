using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.Abstraction
{
    public interface IBuilder <TResult> where TResult : ICompany
    {
        TResult Build();
    }
}
