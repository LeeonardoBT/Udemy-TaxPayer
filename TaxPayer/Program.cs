using System;
using System.Collections.Generic;
using System.Globalization;
using TaxPayer.Entities;

namespace TaxPayer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer_> taxPayers = new List<TaxPayer_>();

            Console.Write("Enter the number of tax payers:");
            int number = int.Parse(Console.ReadLine());

            for (int index = 1; index <= number; index++)
            {
                Console.WriteLine($"Tax payer #{index} data:");

                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAX PAID:");

            double sum = 0.0;
            foreach(TaxPayer_ tx in taxPayers)
            {
                double tax = tx.Tax();
                Console.WriteLine(tx.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
                ;
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum}");
        }
    }
}
