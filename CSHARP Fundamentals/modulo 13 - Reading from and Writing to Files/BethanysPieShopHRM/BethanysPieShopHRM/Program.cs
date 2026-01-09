using BethanysPieShopHRM.HR;

IEmployee bethany = new Employee("Bethany", "Smith", "bethany.smith@gmail.com", new DateTime (2001, 05, 03), 25);

Console.WriteLine("How many hours do we need to register for Bethany?");

int numberOfHours = 0;

string input = Console.ReadLine();

numberOfHours = int.Parse(input);

bethany.DisplayEmployeeDetails();

bethany.PerformWork();

bethany.PerformWork(numberOfHours);
