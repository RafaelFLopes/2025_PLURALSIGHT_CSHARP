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
        private string firstName; // criando atributos
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate;

        private Address address;

        private const int minimalHoursWorkedUnit = 1; // constante para representar a unidade mínima de horas trabalhadas
        private DateTime birthDay;

        public static double taxRate = 0.15; // atributo estático para representar a taxa de imposto aplicável a todos os funcionários


        public string FirstName
        {
            get { 
                return firstName; 
            }
            set { 
                firstName = value; 
            }
        }

        public string LastName
        {
            get {
                return lastName;
            }
            set {
                lastName = value;
            }
        }

        public string Email
        {
            get {
                return email;
            }
            set {
                email = value;
            }
        }

        public int NumberOfHoursWorked
        {
            get {
                return numberOfHoursWorked;
            }
            protected set {
                numberOfHoursWorked = value;
            }
        }

        public double Wage
        {
            get {
                return wage;
            }
            private set {
                wage = value;
            }
        }

        public double? HourlyRate
        {
            get { return hourlyRate; }
            set {
                if (hourlyRate < 0) {
                    hourlyRate = 0;
                }
                else {
                    hourlyRate = value;
                }
            }
        }

        public DateTime BirthDay
        {
            get {
                return birthDay;
            }
            set {
                birthDay = value;
            }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDay) : this (firstName, lastName, email, birthDay, 0) // construtor que inicializa os atributos da class
        {

        }
        public Employee(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10;
            
        }
        public Employee(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate, string street, string houseNumber, string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10;

            Address = new Address(street, houseNumber, zip, city);
        }

        public void PerformWork() // método para realizar o trabalho, contabilizando as horas trabalhadas
        {
            //numberOfHoursWorked++; // incrementa 1 hora trabalhada toda vez que o método é chamado

            PerformWork(minimalHoursWorkedUnit); // chama o método sobrecarregado para contabilizar 1 hora trabalhada

            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }
        public void PerformWork(int numberOfHours) // método sobrecarregado para contabilizar várias horas trabalhadas
        {
            NumberOfHoursWorked += numberOfHours; // incrementa o número de horas trabalhadas com base no numberOfHours fornecido
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {
            if (NumberOfHoursWorked > 10)
            {
                bonus *= 2;
            }

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;

            if (NumberOfHoursWorked > 10)
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
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value; // calculo para obter o salário

            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage} for {NumberOfHoursWorked} hour(s) of work."); // exibe o salário recebido e as horas trabalhadas

            if (resetHours) // verifica se deve resetar as horas trabalhadas
            {
                NumberOfHoursWorked = 0; // reseta as horas trabalhadas para 0
            }

            return Wage; // retorna o salário calculado
        }


        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }


        public virtual void GiveBonus() // método virtual para dar um bônus ao funcionário que pode ser sobrescrito por classes herdadas
        {
            Console.WriteLine($"{FirstName} {LastName} has received a standard bonus: 100 doll.");
        }

        public void DisplayEmployeeDetails() // método para exibir os detalhes do funcionário
        {
            Console.WriteLine($"Employee Details:");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Birthday: {BirthDay.ToShortDateString()}");
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

            double calculatedValue = wageCalculations.ComplexWageCalculation(Wage, taxRate, 3, 42);

            return calculatedValue;
        }

    }
}