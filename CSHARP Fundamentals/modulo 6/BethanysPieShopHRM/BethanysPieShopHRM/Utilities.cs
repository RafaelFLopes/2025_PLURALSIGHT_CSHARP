using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {

        public static void UtilizandoTryParse()
        {
            Console.WriteLine("Digite um número para somar");
            

            string numero1 = Console.ReadLine();

            Console.WriteLine("Digite um segundo número para somar");

            string numero2 = Console.ReadLine();

            double numero1Convertido;

            double numero2Convertido;

            if (double.TryParse(numero1, out numero1Convertido) && double.TryParse(numero2, out numero2Convertido))
            {
                Console.WriteLine($"A soma dos números é: {numero1Convertido + numero2Convertido}");
            }
            else
            {
                Console.WriteLine("Um dos valores digitados não é um número válido.");
            }
        }
        public static void UsandoEscapeCaracteres()
        {
            string firstName = "Bethany";
            string lastName = "Smith";
            string displayName1 = ($"Welcome!\n{firstName} {lastName}"); // utilizando \n para quebrar linha
            string displayName2 = ($"Welcome!\n{firstName}\t{lastName}"); // utilizando \n para quebrar linha e \t para dar um tab  (espaço)

            //string caminhoPastaERRADO = ("C:\data\employeelist.xlsx");
            string caminhoPastaCorreto = ("C:\\data\\employeelist.xlsx");

            // Melhorando a legibilidade com @
            string caminhoPastaMelhorado = @"C:\data\employeelist.xlsx";
            string testandocomvariavel = $@" \ gest teste {firstName}";


            Console.WriteLine(displayName1);
            Console.WriteLine(displayName2);    
            Console.WriteLine(caminhoPastaCorreto);
            Console.WriteLine(caminhoPastaMelhorado);
            Console.WriteLine(testandocomvariavel);
        }

        public static void ManipulandoStrings()
        {
            string firstName = "Bethany"; // Criando uma variavel chamada firstName e atribuindo um valor a ela
            string lastName = "Smith"; // Criando uma variavel chamada lastName e atribuindo um valor a ela

            string fullName = firstName + " " + lastName; // Criando uma variavel fullname e juntando o firstname e o last name
            string employeeIdentification = String.Concat(firstName, lastName); // criando uma variavel e o utilizando a propriedade Concat para concatenar as duas variavels (firstName e lastName)
            string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower(); // criando uma variavel para juntar o primeiro e o ultimo nome, ele está utilizando a propriedade ToLower() para deixar o primeiro nome minusclo, e no ultimo nome ta usando a propriedade Trim() para tirar os espaçamenmtos
            int length = empId.Length; // fazendo a contagem de quantas letras tem na variavem empId
            if (fullName.Contains("beth") || fullName.Contains("Beth")) //verificando se a variavel full name contem beth ou "Beth"
            {
                Console.WriteLine("It's Bethany!"); 
            }
            string subString = fullName.Substring(1, 3); //aparecendo apenas após do indice zero ao 3, ent vai aparecer eth
            Console.WriteLine("Chararters 2 to 4 of fullName are + subString");

            string userNameWithInterpolation = $"{firstName}-{lastName}"; // interpolação de string utilziando $
        }

        public static int CalculaSalarioAnual(int salarioMensal, int numeroDeMesesTrabalhados)
        {
            //Console.WriteLine($"Salário anual: {salarioMensal * numeroDeMesesTrabalhados}");
            return salarioMensal * numeroDeMesesTrabalhados;
        }
        public static int CalculaSalarioAnual(int salarioMensal, int numeroDeMesesTrabalhados, int bonus)
        {
            //Console.WriteLine($"Salário anual: {salarioMensal * numeroDeMesesTrabalhados}");
            return salarioMensal * numeroDeMesesTrabalhados + bonus;
        }
    }
}