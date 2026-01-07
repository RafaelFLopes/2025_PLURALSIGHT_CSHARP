using BethanysPieShopHRM.HR;

IEmployee bethany = new Employee("Bethany", "Smith", "bethany.smith@gmail.com", new DateTime (2001, 05, 03), 25);

IEmployee rafael = new Manager("Rafael", "Lopes", "rafael.lopes@gmail.com", new DateTime (2008, 03, 25), 30);

IEmployee bobPedro = new JuniorResearcher("Bob", "Pedro", "bob.pedro@gmail.com", new DateTime (1995, 11, 15), 20);

IEmployee Samuel = new Employee("Samuel", "Lopes", "samuel.lopes@gmail.com", new DateTime(1995, 11, 15), 25, "new street", "123", "12345-678", "New City");


List<IEmployee> employees = new List<IEmployee>();

employees.Add(bethany);
employees.Add(rafael);
employees.Add(bobPedro);
employees.Add(Samuel);

foreach (Employee emp in employees)
{
    emp.DisplayEmployeeDetails();
    emp.GiveBonus();
    emp.GiveCompliment();
    Console.WriteLine();
}

//string streetName = Samuel.Address.Street;
//Console.WriteLine($"Samuel's street name is: {streetName}");

//bethany.DisplayEmployeeDetails();

//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork(3);
//bethany.PerformWork(4);
//bethany.ReceiveWage();

//rafael.DisplayEmployeeDetails();

//rafael.PerformWork(5);
//rafael.AttendManagementMeeting();
//rafael.ReceiveWage();

//bobPedro.ResearchNewPieTastes(4);


////bethany.firstName = "sda"; // Erro de compilação: 'Employee.firstName' is inaccessible due to its protection level porque o atributo firstName é privado

//bethany.FirstName = "Bethany Updated"; // Usando a propriedade para definir o valor do nome
//string fn = bethany.FirstName; // Usando a propriedade para obter o valor do nome