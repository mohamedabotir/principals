using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.Abstraction
{
    public interface IBuilderManager <out TBuilder,TSubject>
       where TBuilder : IBuilder<TSubject>
        where TSubject : ICompany
    {
        TBuilder New { get; }

    }
}
