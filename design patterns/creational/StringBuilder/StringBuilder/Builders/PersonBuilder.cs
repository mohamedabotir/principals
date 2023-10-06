using StringBuilder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.Builders
{
    public class PersonBuilder
    {
        protected Person person { get; set; }
        public PersonBuilder()
        {
            person = new Person();
        }
        protected PersonBuilder(Person person) => this.person = person;
        public PersonAddressBuilder Lives => new(person);
        public PersonJobBuilder Works => new(person);

        public static implicit operator Person(PersonBuilder builder) => builder.person;
    }
}
