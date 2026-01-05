using BethanysPieShopHRM.HR;
using BethanysPieShopHRM.Logic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Employee
    { // criando a classe funcinario e adicionando atributos e metodos
        public string firstName; // criando atributos
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double? hourlyRate;
        const int minimalHoursWorkedUnit = 1; // constante para representar a unidade mínima de horas trabalhadas
        public DateTime birthDay;

        public EmployeeType employeeType;

        public static double taxRate = 0.15; // atributo estático para representar a taxa de imposto aplicável a todos os funcionários

        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0, EmployeeType.StoreManager) // construtor que inicializa os atributos da class
        {

        }
        public Employee(string first, string last, string em, DateTime bd, double? rate, EmployeeType empType)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bd;
            hourlyRate = rate ?? 10;
            employeeType = empType;
        }

        public void PerformWork() // método para realizar o trabalho, contabilizando as horas trabalhadas
        {
            //numberOfHoursWorked++; // incrementa 1 hora trabalhada toda vez que o método é chamado

            PerformWork(minimalHoursWorkedUnit); // chama o método sobrecarregado para contabilizar 1 hora trabalhada

            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }
        public void PerformWork(int numberOfHours) // método sobrecarregado para contabilizar várias horas trabalhadas
        {
            numberOfHoursWorked += numberOfHours; // incrementa o número de horas trabalhadas com base no numberOfHours fornecido
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {
            if (numberOfHoursWorked > 10)
            {
                bonus *= 2;
            }

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;

            if (numberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} with a tax of {bonusTax}");
            return bonus;
        }

        //public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        //{
        //    if (numberOfHoursWorked > 10)
        //        bonus *= 2;

        //    if (bonus >= 200)
        //    {
        //        bonusTax = bonus / 10;
        //        bonus -= bonusTax;
        //    }

        //    Console.WriteLine($"The employee got a bonus of {bonus} with a tax of {bonusTax}");
        //    return bonus;
        //}

        public double ReceiveWage(bool resetHours = true) // método para calcular o salário com base nas horas trabalhadas e na taxa horária e resetar as horas trabalhadas se necessário
        {

            double wageBeforeTax = 0.0;

            if (employeeType == EmployeeType.Manager)
            {
                wage = numberOfHoursWorked * hourlyRate.Value * 1.25;
            }
            else { 
                wage = numberOfHoursWorked * hourlyRate.Value; // calculo para obter o salário
            }

            double taxAmount = wageBeforeTax * taxRate;

            wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work."); // exibe o salário recebido e as horas trabalhadas

            if (resetHours) // verifica se deve resetar as horas trabalhadas
            {
                numberOfHoursWorked = 0; // reseta as horas trabalhadas para 0
            }

            return wage; // retorna o salário calculado
        }


        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

        public void DisplayEmployeeDetails() // método para exibir os detalhes do funcionário
        {
            Console.WriteLine($"Employee Details:");
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Birthday: {birthDay.ToShortDateString()}");
        }

        // método para converter o objeto Employee em uma string JSON utilizando a biblioteca Newtonsoft.Json de código aberto
        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public double CalculateWage()
        {
            WageCalculations wageCalculations = new WageCalculations();

            double calculatedValue = wageCalculations.ComplexWageCalculation(wage, taxRate, 3, 42);

            return calculatedValue;
        }

    }
}