using BethanysPieShopHRM.HR;

Employee bethany = new Employee("Bethany", "Smith", "bethany.smith@gmail.com", new DateTime (2001, 05, 03), 25);
Manager rafael = new Manager("Rafael", "Lopes", "rafael.lopes@gmail.com", new DateTime (2008, 03, 25), 30);

JuniorResearcher bobPedro = new JuniorResearcher("Bob", "Pedro", "bob.pedro@gmail.com", new DateTime (1995, 11, 15), 20);



bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork(3);
bethany.PerformWork(4);
bethany.ReceiveWage();

rafael.DisplayEmployeeDetails();

rafael.PerformWork(5);
rafael.AttendManagementMeeting();
rafael.ReceiveWage();

bobPedro.ResearchNewPieTastes(4);


//bethany.firstName = "sda"; // Erro de compilação: 'Employee.firstName' is inaccessible due to its protection level porque o atributo firstName é privado

bethany.FirstName = "Bethany Updated"; // Usando a propriedade para definir o valor do nome
string fn = bethany.FirstName; // Usando a propriedade para obter o valor do nome