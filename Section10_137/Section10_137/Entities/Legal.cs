using System;
using System.Collections.Generic;
using System.Text;

namespace Section10_137.Entities
{
    class Legal : Person
    {
        public int EmployeesQuantity { get; set; }

        public Legal()
        {
        }

        public Legal(string name, double income, int employeesQuantity)
            : base(name, income)
        {
            EmployeesQuantity = employeesQuantity;
        }

        public override double Tax()
        {
            if (EmployeesQuantity > 10)
            {
                return Income*0.14;
            }
            else
            {
                return Income * 0.16;
            }
        }
    }
}
