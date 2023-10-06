using StringBuilder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.Builders
{
    public class PersonJobBuilder :PersonBuilder
    {
        private Person person;

        public PersonJobBuilder(Person person):base(person)
        {
            this.person = person;
        }

        public PersonJobBuilder WorksOn(string company) { 
            person.CompanyName = company;
        return this;
        }
        public PersonJobBuilder InPosition(string position) { 
            person.Position = position;
        return this;
        }
        public PersonJobBuilder WithAnnualSalary(decimal salary) { 
            person.AnnualIncome = salary;
        return this;
        }
    }
}
