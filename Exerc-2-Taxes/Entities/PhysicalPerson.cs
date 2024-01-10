using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerc_2_Taxes.Entities
{
    class PhysicalPerson : Person
    {
        public double HealthExpenditures { get; protected set; }


        public PhysicalPerson()
        {
        }

        public PhysicalPerson(string name, double annualtax, double healthexpenditures)
         :base (name, annualtax)
        {
            HealthExpenditures =  healthexpenditures;
        }

        public override double TaxesPaid()
        {
            double healthDiscount = HealthExpenditures * 0.50;
            if (AnnualTax > 20000)
            {
                return (AnnualTax * 0.25) - healthDiscount;
            }
            return (AnnualTax * 0.15) - healthDiscount;
        }
    }
}