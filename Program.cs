using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_Resolvido_01_Enumeracao.Entities.Enums;
using System.Globalization;
using Exercicio_Resolvido_01_Enumeracao.Entities;

namespace Exercicio_Resolvido_01_Enumeracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament`s name: ");
            string deptname = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level;
            Enum.TryParse(Console.ReadLine(), out level);
            Console.Write("Base salaray: ");
            double basesalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptname);
            Worker worker = new Worker(name, level, basesalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valueperhour, hours);
                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthandyear = Console.ReadLine();
            int month = int.Parse(monthandyear.Substring(0, 2));
            int year = int.Parse(monthandyear.Substring(3));

            Console.WriteLine("Name:" + worker.Name);
            Console.WriteLine("Department:" + worker.Department.Name);
            Console.WriteLine("Income for " + monthandyear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)); ;
        }
    }
}
