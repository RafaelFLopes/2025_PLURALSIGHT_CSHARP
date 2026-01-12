using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using BethanysPieShopHRM.HR;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {
        private static string directory = @"C:\data\BethanysPieShopHRM";

        private static string fileName = "employees.txt";

        internal static void RegisterEmployee(List<Employee> employees) {

            Console.WriteLine("Registering a new employee...");

            Console.WriteLine("What type of employee do you want to register?");
            Console.WriteLine("1: Employee \n2: Manager \n3: Store manager \n4: Researcher \n5: Junior researcher");

            string employeeType = Console.ReadLine();

            if(employeeType != "1" && employeeType != "2" && employeeType != "3" && employeeType != "4" && employeeType != "5")
            {
                Console.WriteLine("Invalid selection!");
                return;
            }

            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter the last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter the email: ");
            string email = Console.ReadLine();

            Console.Write("Enter the birth day: ");
            DateTime birthDay =  DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the hourly rate: ");
            string hourlyRate = Console.ReadLine();

            double rate = double.Parse(hourlyRate);

            Employee employee = null;

            switch (employeeType)
            {
                case "1":
                    employee = new Employee
                        (
                        firstName,
                        lastName,
                        email,
                        birthDay,
                        rate
                    );
                    break;
                case "2":
                    employee = new Manager
                    (
                        firstName,
                        lastName,
                        email,
                        birthDay,
                        rate
                    );
                    break;
                case "3":
                    employee = new StoreManager
                    (
                        firstName,
                        lastName,
                        email,
                        birthDay,
                        rate
                    );
                    break;
                case "4":
                    employee = new Researcher
                    (
                        firstName,
                        lastName,
                        email,
                        birthDay,
                        rate
                    );
                    break;
                case "5":
                    employee = new JuniorResearcher
                    (
                        firstName,
                        lastName,
                        email,
                        birthDay,
                        rate
                    );
                    break;
            }

            employees.Add(employee);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Successfully registered {employee.FirstName} {employee.LastName} as a new employee.");
        }

        internal static void ViewAllEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].DisplayEmployeeDetails();
            }
        }

        internal static void SaveEmployees(List<Employee> employees)
        {
            string path = $"{directory}\\{fileName}";
            StringBuilder sb = new StringBuilder();
            foreach (Employee employee in employees)
            {
                string type = GetEmployeeType(employee);
                sb.Append($"firstName:{employee.FirstName};");
                sb.Append($"lastName:{employee.LastName};");
                sb.Append($"email:{employee.Email};");
                sb.Append($"birthDay:{employee.BirthDay.ToShortDateString()};");
                sb.Append($"hourlyRate:{employee.HourlyRate};");
                sb.Append($"type:{type};");

                sb.Append(Environment.NewLine);
            }
            File.WriteAllText(path, sb.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saved employees successfully");
            Console.ResetColor();
        }

        private static string GetEmployeeType(Employee employee)
        {
            if(employee is Manager)
                return "2";
            else if(employee is StoreManager)
                return "3";
            else if(employee is Researcher)
                return "4";
            else if(employee is JuniorResearcher)
                return "5";
            else if (employee is Employee)
                return "1";
            return "0";

        }

        internal static void LoadEmployees(List<Employee> employees)
        {
            
        }
        internal static void CheckForExistingEmployeeFile()
        {
            string path = $"{directory}{fileName}";

            bool existingFileFound = File.Exists(path);

            if(existingFileFound)
            {
                Console.WriteLine("An existing file with Employee data is found ");
            }
            else
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Directory is read for saving files.");
                    Console.ResetColor();
                }
            }
        }
    }
}
