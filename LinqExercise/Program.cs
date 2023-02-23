using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            Console.WriteLine("Sum of Numbers:");
            int sum = numbers.Sum();
            Console.WriteLine(sum);
            Console.WriteLine("---------------------------------");

            //TODO: Print the Average of numbers
            
            Console.WriteLine("Average:");
            var average1 = numbers.Average(x => x);
            Console.WriteLine(average1);
            Console.WriteLine("---------------------------------");

            //TODO: Order numbers in ascending order and print to the console

            
            Console.WriteLine("Ascending Order:");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("---------------------------------");

            //TODO: Order numbers in decsending order and print to the console


            Console.WriteLine("Decsending Order:");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("---------------------------------");


            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("Numbers Greater than 6:");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("---------------------------------");

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Only 4 numbers:");
            numbers.Where(x => x < 9 && x >= 5).ToList().ForEach(numbers => Console.WriteLine(numbers));
            Console.WriteLine("---------------------------------");

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            Console.WriteLine("Added Age:");
            numbers[4] = 27;
            numbers.OrderByDescending(x => x).ToList().ForEach(x=> Console.WriteLine(x));
            Console.WriteLine("---------------------------------");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Names with C or S:");
            employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine("---------------------------------");


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employees over 26:");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"{x.FullName} - {x.Age}"));
            Console.WriteLine("---------------------------------");


            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("Sum of Employees w/ 10 YOE and over 35");
            var sumYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList().Sum(x => x.YearsOfExperience);
            Console.WriteLine(sumYOE);

            Console.WriteLine("Average of Employees' YOE: ");
            var averageYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList().Average(x => x.YearsOfExperience);
            Console.WriteLine(averageYOE);


            Console.WriteLine("---------------------------------");

            //TODO: Add an employee to the end of the list without using employees.Add()

           employees.Append(new Employee { FirstName = "Sawyer", LastName = "Tarr", Age = 27, YearsOfExperience = 1 });

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
