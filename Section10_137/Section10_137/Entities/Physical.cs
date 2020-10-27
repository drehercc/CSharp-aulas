using System;
using System.Collections.Generic;
using System.Text;

namespace Section10_137.Entities
{
    class Physical : Person
    {
        public double HealthExpenses { get; set; }

        public Physical()
        {
        }

        public Physical(string name, double income, double healthExpenses)
            :base(name, income)
        {
            HealthExpenses = healthExpenses;
        }


        public override double Tax()
        {
            if (Income >= 20000)
            {
                return (Income * 0.25) - (HealthExpenses * 0.5);
            }
            else
            {
                return (Income * 0.15) - (HealthExpenses * 0.5);
            }
        }


    }

}
