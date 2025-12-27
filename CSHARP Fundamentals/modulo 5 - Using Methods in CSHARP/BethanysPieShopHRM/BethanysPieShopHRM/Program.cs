using BethanysPieShopHRM;

Console.WriteLine("Bem-vindo ao sistema de RH da Bethany's Pie Shop!");
Console.WriteLine("Calculando o salário anual...");
Console.Write("Digite o salário mensal: ");
int salarioMensal = int.Parse(Console.ReadLine());
Console.Write("Digite o número de meses trabalhados: ");
int numeroDeMesesTrabalhados = int.Parse(Console.ReadLine());
Console.Write("Digite o bonus: ");
int bonus = int.Parse(Console.ReadLine());


//CalculaSalarioAnual(salarioMensal, numeroDeMesesTrabalhados);

int resultado = Utilities.CalculaSalarioAnual(salarioMensal, numeroDeMesesTrabalhados, bonus);

Console.WriteLine($"Salário anual: {resultado}");
