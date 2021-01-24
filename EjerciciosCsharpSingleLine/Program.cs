using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCsharpSingleLine
{
    class Program
    {
        public static void Exercise1()
        {
            var array1 = new[] { 1, 4, 5, 10, 11, 22 };
            var array2 = array1.Select(element => element * 2).ToArray();
        }

        public static void Exercise2()
        {
            var array1 = new[] { 50, 4, 1, 15, 20, 22 };
            var array2 = array1.Where(element => element >= 20).ToArray();
        }

        public static void Exercise3()
        {
            var array1 = new[] { 1, 2, 3, 5, 8 };
            var result = array1.Select(s => s * 2).Sum();
        }

        public static void Exercise4()
        {
            var array1 = new[] { 1, 0.38, 0.95, 0.05, 0.236 };
            var result = array1.Select(s => s * s).OrderByDescending(o => o).ToList();
        }

        public static void Exercise5()
        {
            var employee1 = new Employee();
            employee1.Name = "Rolando";
            employee1.LastName = "Dominguez";
            employee1.IncomeAmount = 2300;
            employee1.Birthdate = new DateTime(1992, 11, 29);

            var employee2 = new Employee()
            {
                Name = "Angel",
                LastName = "Dominguez",
                IncomeAmount = 2389,
                Birthdate = new DateTime(1995, 03, 27),
            };

            var employee3 = new Employee() { Name = "Rodrigo", LastName="Tamayo", Birthdate = new DateTime(1993, 07, 21), IncomeAmount = 4959.99m };

            var employeeArray = new[] { employee1, employee2, employee3 };

            decimal c = employeeArray.Sum(s => s.IncomeAmount);
            Employee d = employeeArray.OrderByDescending(o => o.IncomeAmount).FirstOrDefault();
            Employee[] e = employeeArray.OrderBy(o => o.Birthdate).ToArray();

        }

        static void Main(string[] args)
        
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();

        }
    }
}
