using StringBuilder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.Builders
{
    public class PersonAddressBuilder : PersonBuilder
    {
        private Person person;

        public PersonAddressBuilder(Person person):base(person)
        {
            this.person = person;
        }
        public PersonAddressBuilder LivesOn(string liveon)
        {
            person.City = liveon;
            return this;
        }
        public PersonAddressBuilder WithAddress(string address)
        {
            person.StreetAddress = address;
            return this;
        }
        public PersonAddressBuilder OwnPostCode(string postCode)
        {
            person.Postcode = postCode;
            return this;
        }


    }
}
