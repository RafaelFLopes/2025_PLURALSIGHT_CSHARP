using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.HR;
using System.Text;
 

Console.WriteLine("Creating an employee");
Console.WriteLine("-----------------------");

Employee bethany = new Employee("Bethany", "Smith", "bethany.smith@gmail.com", new DateTime(1995, 09, 13), 25, EmployeeType.Manager); // cria uma nova instância da classe Employee com os detalhes fornecidos

bethany.CalculateWage();


Account account = new Account("123456789"); // cria uma nova instância do record Account com o número de conta fornecido
//account.AccountNumber = "12315787"; // tenta alterar o número da conta (isso não é permitido em records imutáveis)