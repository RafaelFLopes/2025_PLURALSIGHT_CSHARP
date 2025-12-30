using BethanysPieShopHRM.HR;
using System.Text;

Console.WriteLine("Creating an employee");
Console.WriteLine("-----------------------");


Employee bethany = new Employee("Bethany", "Smith", "bethany.smith@gmail.com", new DateTime(1995, 09, 13), 25, EmployeeType.Manager); // cria uma nova instância da classe Employee com os detalhes fornecidos



// Convertendo o objeto para JSON
string bethanyConvertedToJson = bethany.ConvertToJson(); // converte o objeto bethany para uma string JSON
Console.WriteLine(bethanyConvertedToJson); // exibe a string JSON no console

bethany.DisplayEmployeeDetails(); // os detalhes do funcionário são exibidos



bethany.PerformWork(15); // chama o método para contabilizar 1 hora trabalhada


int minimalBonus = 100;
int bonusTax; // variavel para armazenar o valor do imposto sobre o bônus 
int calculatedBonus = bethany.CalculateBonusAndBonusTax(minimalBonus, out bonusTax); // chama o método para calcular o bônus com base nas horas trabalhadas
Console.WriteLine($"Calculated Bonus: {calculatedBonus} with Bonus Tax: {bonusTax}"); // exibe o bônus calculado



////exemplo utilizando ref para retornar o valor do imposto sobre o bônus
//int minimalBonus = 100;
//int bonusTax = 0; // variavel para armazenar o valor do imposto sobre o bônus 
//int calculatedBonus = bethany.CalculateBonusAndBonusTax(minimalBonus, ref bonusTax); // chama o método para calcular o bônus com base nas horas trabalhadas
//Console.WriteLine($"Calculated Bonus: {calculatedBonus} with Bonus Tax: {bonusTax}"); // exibe o bônus calculado


//int minimalBonus = 100;
//int calculatedBonus = bethany.CalculateBonus(minimalBonus); // chama o método para calcular o bônus com base nas horas trabalhadas
//Console.WriteLine($"Calculated Bonus: {calculatedBonus}"); // exibe o bônus calculado


bethany.PerformWork(); // chama o método para contabilizar 1 hora trabalhada
bethany.PerformWork(5); // chama o método para contabilizar 5 hora trabalhada
bethany.PerformWork(); // chama o método para contabilizar 1 hora trabalhada

//totalizando 8 horas trabalhadas

double receivedWageBethany = bethany.ReceiveWage(); // chama o método para calcular e exibir o salário recebido por Bethany

Console.WriteLine($"Wage: {receivedWageBethany}"); // exibe o salário recebido por Bethany

Console.WriteLine("Creating an employee");
Console.WriteLine("-----------------------");

Employee rafael = new Employee("rafael", "ferreira", "rafael.ferreira@gmail.com", new DateTime(2008, 03, 25), 35, EmployeeType.Manager);

rafael.DisplayEmployeeDetails();

rafael.PerformWork(4);
rafael.PerformWork(5);
rafael.PerformWork(3);
rafael.PerformWork(2);

double receivedWageRafael = rafael.ReceiveWage();

Console.WriteLine($"Wage: {receivedWageRafael}"); // exibe o salário recebido por Bethany



//TRABALHANDO COM STRINGBUILDER QUE É UMA NOVA FEATURE DO C# 12 E PERMITE MELHORAR A PERFORMANCE NA MANIPULAÇÃO DE STRINGS

StringBuilder builder = new StringBuilder();

builder.AppendLine("Hello, World!");
builder.AppendLine("Welcome to C# 12.");
Console.WriteLine(builder.ToString());


//struct 
WorkTask workTask;
workTask.description = "Prepare monthly report";
workTask.hours = 3;
workTask.PerformWorkTask();