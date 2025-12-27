using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {
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
