using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.Accouting;
using BethanysPieShopHRM.HR;
using System.Text;


Console.WriteLine("Creating an employee");
Console.WriteLine("-----------------------");

Employee bethany = new Employee("Bethany", "Smith", "bethany.smith@gmail.com", new DateTime(1995, 09, 13), 25, EmployeeType.Manager); // cria uma nova instância da classe Employee com os detalhes fornecidos

//Criando uma array simples

int[] sampleArray1 = new int[5];

int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };

//int[] sampleArray3 = new int[5] { 1, 2, 3, 4, 5, 6 }; vai dar erro, pois escrevi 5 e coloquei 6 elementos

// arrays podem ser dinamicas tbm

Console.WriteLine("How many employees IDs do you want to register?");

int lenght = int.Parse(Console.ReadLine());

int[] employeeIds = new int[lenght];

var testId = employeeIds[0]; // inicializa a variável testId com o valor do primeiro elemento do array employeeIDs (que é 0 por padrão)
//var erroId = employeeIds[lenght];

for(int i = 0; i < employeeIds.Length; i++) // loop para preencher o array com IDs de funcionários fornecidos pelo usuário
{
    Console.WriteLine($"Enter the employee ID for employee:"); // solicita ao usuário que insira o ID do funcionário
    employeeIds[i] = int.Parse(Console.ReadLine()); // lê o ID do funcionário inserido pelo usuário e o armazena no array na posição i
}

for (int i = 0; i < employeeIds.Length; i++) // loop para exibir os IDs dos funcionários armazenados no array
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}"); // exibe o ID do funcionário na posição i do array
}