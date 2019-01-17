using System;
using Worker.Entites.Enums;
using Worker.Entites;
using System.Globalization;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter Departement's name: ");
            string depart = Console.ReadLine();
            Console.WriteLine("Enter worker data ");
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Level(Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(depart);
            workers worker = new workers(name, level, baseSalary, department);

            Console.Write("How many contract for this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/YY/MM): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration(hours): ");
                int hour = int.Parse(Console.ReadLine());
                HourContracts contract = new HourContracts(date, valueperhour, hour);
                worker.AddContract(contract);

            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("name: " + worker.name);
            Console.WriteLine("Department: " + worker.department.name);
            Console.WriteLine("Income for : " + monthAndYear + ": " + worker.Income(year, month));

        }
    }
}
