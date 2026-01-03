using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.HR;
using System.Text;


//Console.WriteLine("Creating an employee");
//Console.WriteLine("-----------------------");

//Employee bethany = new Employee("Bethany", "Smith", "bethany.smith@gmail.com", new DateTime(1995, 09, 13), 25, EmployeeType.Manager); // cria uma nova instância da classe Employee com os detalhes fornecidos

//Criando uma array simples

int[] sampleArray1 = new int[5];

int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };

//int[] sampleArray3 = new int[5] { 1, 2, 3, 4, 5, 6 }; vai dar erro, pois escrevi 5 e coloquei 6 elementos








// arrays podem ser dinamicas tbm

Console.WriteLine("How many employees IDs do you want to register?");

int lenght = int.Parse(Console.ReadLine());

int[] employeeIds = new int[lenght];



for (int i = 0; i < employeeIds.Length; i++) // loop para preencher o array com IDs de funcionários fornecidos pelo usuário
{
    Console.WriteLine($"Enter the employee ID for employee:"); // solicita ao usuário que insira o ID do funcionário
    employeeIds[i] = int.Parse(Console.ReadLine()); // lê o ID do funcionário inserido pelo usuário e o armazena no array na posição i
}

for (int i = 0; i < employeeIds.Length; i++) // loop para exibir os IDs dos funcionários armazenados no array
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}"); // exibe o ID do funcionário na posição i do array
}



Console.WriteLine("Sorting employee IDs...");

Array.Sort(employeeIds);

for (int i = 0; i < employeeIds.Length; i++) // loop para exibir os IDs dos funcionários armazenados no array
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}"); // exibe o ID do funcionário na posição i do array
}



int[] employeeIdsCopy = new int[lenght]; // cria um novo array employeeIdsCopy com o mesmo tamanho do array employeeIds

employeeIds.CopyTo(employeeIdsCopy, 0); // copia os elementos do array employeeIds para o array employeeIdsCopy, começando na posição 0 do array de destino

Array.Reverse(employeeIds); // inverte a ordem dos elementos no array employeeIds


Console.WriteLine("after reversing original array...");

for (int i = 0; i < employeeIds.Length; i++) // loop para exibir os IDs dos funcionários armazenados no array
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}"); // exibe o ID do funcionário na posição i do array
}

Console.WriteLine("copy of array");

for (int i = 0; i < employeeIdsCopy.Length; i++) // loop para exibir os IDs dos funcionários armazenados no array
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIdsCopy[i]}"); // exibe o ID do funcionário na posição i do array
}

//Employee bethany = new Employee("Bethany", "Smith", "bethany.smith@gmail.com", new DateTime(1995, 09, 13), 25, EmployeeType.Manager);

//Employee lucas = new Employee("Lucas", "Pereira", "lucas.pereira@gmail.com", new DateTime(1990, 03, 22), 32, EmployeeType.Sales);

//Employee mariana = new Employee("Mariana", "Oliveira", "mariana.oliveira@gmail.com", new DateTime(1998, 07, 10), 26, EmployeeType.Research);

//Employee carlos = new Employee("Carlos", "Santos", "carlos.santos@gmail.com", new DateTime(1985, 11, 05), 39, EmployeeType.StoreManager);

//Employee ana = new Employee("Ana", "Costa", "ana.costa@gmail.com", new DateTime(1996, 01, 18), 28, EmployeeType.Manager);

//Employee rafael = new Employee("Rafael", "Almeida", "rafael.almeida@gmail.com", new DateTime(1992, 06, 30), 31, EmployeeType.Sales);

//Employee beatriz= new Employee("Beatriz", "Rocha", "beatriz.rocha@gmail.com", new DateTime(1999, 09, 14), 25, EmployeeType.Research);

//Employee fernando = new Employee("Fernando", "Lima", "fernando.lima@gmail.com", new DateTime(1988, 12, 02), 36, EmployeeType.StoreManager);

//Employee juliana = new Employee("Juliana", "Mendes", "juliana.mendes@gmail.com", new DateTime(1994, 04, 27), 30, EmployeeType.Manager);

//Employee pedro = new Employee("Pedro", "Araujo", "pedro.araujo@gmail.com", new DateTime(2000, 08, 09), 24, EmployeeType.Sales);

//Employee camila = new Employee("Camila", "Teixeira", "camila.teixeira@gmail.com", new DateTime(1997, 10, 21), 27, EmployeeType.Research);

//Employee[] employees = new Employee[11];

//employees[0] = bethany;
//employees[1] = lucas;
//employees[2] = mariana;
//employees[3] = carlos;
//employees[4] = ana;
//employees[5] = rafael;
//employees[6] = beatriz;
//employees[7] = fernando;
//employees[8] = juliana;
//employees[9] = pedro;
//employees[10] = camila;


//foreach (Employee e in employees)
//{
//    e.DisplayEmployeeDetails();
//    var numberOfHours = new Random().Next(25);
//    e.PerformWork(15);
//    e.ReceiveWage();
//}

//Console.ReadLine();