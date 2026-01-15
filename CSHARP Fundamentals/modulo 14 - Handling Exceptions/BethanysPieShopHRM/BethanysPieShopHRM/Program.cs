using BethanysPieShopHRM;
using BethanysPieShopHRM.HR;

List<Employee> employees = new List<Employee>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("********************************************");
Console.WriteLine("* Welcome to Bethany's Pie Shop HRM System *");
Console.WriteLine("********************************************");
Console.ForegroundColor = ConsoleColor.White;


String userSelection;

Utilities.CheckForExistingEmployeeFile();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {employees.Count} employee(s)\n");
    Console.ResetColor();

    Console.WriteLine("********************");
    Console.WriteLine("* Select an action *");
    Console.WriteLine("********************");

    Console.WriteLine("1: Register employee");
    Console.WriteLine("2: View all employees");
    Console.WriteLine("3: Save data");
    Console.WriteLine("4: Load data");
    Console.WriteLine("5: Load specific employee");
    Console.WriteLine("99: Exit application");

    userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            Utilities.RegisterEmployee(employees);
            break;
        case "2":
            Utilities.ViewAllEmployees(employees);
            break;
        case "3":
            Utilities.SaveEmployees(employees);
            break;
        case "4":
            Utilities.LoadEmployees(employees);
            break;
        case "5":
            Utilities.LoadEmployeesById(employees);
            break;
        case "99":
            break;
        default:
            Console.WriteLine("Invalid selection, please try again.");
            break;
    }

} while (userSelection != "99");

Console.WriteLine("Exiting application, goodbye!");