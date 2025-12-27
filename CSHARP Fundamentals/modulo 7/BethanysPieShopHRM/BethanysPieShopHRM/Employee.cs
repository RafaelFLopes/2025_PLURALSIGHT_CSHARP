using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Employee { // criando a classe funcinario e adicionando atributos e metodos
        public string firstName; // criando atributos
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;
        const int minimalHoursWorkedUnit = 1; // constante para representar a unidade mínima de horas trabalhadas
        public DateTime birthDay;

        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0 ) // construtor que inicializa os atributos da class
        {

        }
        public Employee(string first, string last, string em, DateTime bd, double rate)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bd;
            hourlyRate = rate;
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

        public double ReceiveWage(bool resetHours = true) // método para calcular o salário com base nas horas trabalhadas e na taxa horária e resetar as horas trabalhadas se necessário
        {
            wage = numberOfHoursWorked * hourlyRate; // calculo para obter o salário

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work."); // exibe o salário recebido e as horas trabalhadas

            if (resetHours) // verifica se deve resetar as horas trabalhadas
            {
                numberOfHoursWorked = 0; // reseta as horas trabalhadas para 0
            }

            return wage; // retorna o salário calculado
        }
        
        public void DisplayEmployeeDetails() // método para exibir os detalhes do funcionário
        {
            Console.WriteLine($"Employee Details:");
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Birthday: {birthDay.ToShortDateString()}");
        }
    }
}
