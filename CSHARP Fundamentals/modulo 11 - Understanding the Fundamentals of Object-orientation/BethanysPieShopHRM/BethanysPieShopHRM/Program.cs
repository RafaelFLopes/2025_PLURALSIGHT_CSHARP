using BethanysPieShopHRM.HR;

Employee bethany = new Employee("Bethany", "Smith", "bethany.smith@gmail.com", new DateTime (2001, 05,03), 25, EmployeeType.Manager);
Employee rafael = new Employee("Rafael", "Lopes", "rafael.lopes@gmail.com", new DateTime (2008, 03,25), 30, EmployeeType.Research);

bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork(3);
bethany.PerformWork(4);
bethany.ReceiveWage();


//bethany.firstName = "sda"; // Erro de compilação: 'Employee.firstName' is inaccessible due to its protection level porque o atributo firstName é privado

bethany.FirstName = "Bethany Updated"; // Usando a propriedade para definir o valor do nome
string fn = bethany.FirstName; // Usando a propriedade para obter o valor do nome