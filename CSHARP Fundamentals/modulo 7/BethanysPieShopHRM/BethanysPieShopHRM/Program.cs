using BethanysPieShopHRM;

Console.WriteLine("Creating an employee");
Console.WriteLine("-----------------------");

Employee bethany = new Employee("Bethany", "Smith", "bethany.smith@gmail.com", new DateTime (1995,09,13), 25); // cria uma nova instância da classe Employee com os detalhes fornecidos

bethany.DisplayEmployeeDetails(); // os detalhes do funcionário são exibidos

bethany.PerformWork(); // chama o método para contabilizar 1 hora trabalhada
bethany.PerformWork(); // chama o método para contabilizar 1 hora trabalhada
bethany.PerformWork(5); // chama o método para contabilizar 5 hora trabalhada
bethany.PerformWork(); // chama o método para contabilizar 1 hora trabalhada

//totalizando 8 horas trabalhadas

double receivedWageBethany = bethany.ReceiveWage(); // chama o método para calcular e exibir o salário recebido por Bethany

Console.WriteLine($"Wage: {receivedWageBethany}"); // exibe o salário recebido por Bethany

Console.WriteLine("Creating an employee");
Console.WriteLine("-----------------------");

Employee rafael = new Employee("rafael", "ferreira", "rafael.ferreira@gmail.com", new DateTime(2008, 03, 25), 35);

rafael.DisplayEmployeeDetails();

rafael.PerformWork(4);
rafael.PerformWork(5);
rafael.PerformWork(3);
rafael.PerformWork(2);

double receivedWageRafael = rafael.ReceiveWage();

Console.WriteLine($"Wage: {receivedWageRafael}"); // exibe o salário recebido por Bethany