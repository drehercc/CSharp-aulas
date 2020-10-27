using Section10_137.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Section10_137
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1;i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (c == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenses = double.Parse(Console.ReadLine());
                    person.Add(new Physical(name,income,healthExpenses));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    person.Add(new Legal(name, income, employees));
                }

            }


            double total = 0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(Person p in person)
            {
                total += p.Tax();
                Console.WriteLine(p.Name 
                    + " $ " 
                    + p.Tax().ToString("F2",CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ "+ total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
