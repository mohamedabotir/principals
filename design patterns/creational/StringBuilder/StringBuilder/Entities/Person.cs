using StringBuilder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.Entities
{
    public class Person
    {
        // address
        public string StreetAddress, Postcode, City;
        // employment info
        public string CompanyName, Position;
        public decimal AnnualIncome;

        public override string ToString()
        {
            return $@"Lives on {City} with address {StreetAddress} , postCode{Postcode}
                      Works on {CompanyName} in Position ${Position} with AnnualIncome ${AnnualIncome}
                   ";
        }
        public static PersonBuilder Create() => new PersonBuilder();
    }
}
