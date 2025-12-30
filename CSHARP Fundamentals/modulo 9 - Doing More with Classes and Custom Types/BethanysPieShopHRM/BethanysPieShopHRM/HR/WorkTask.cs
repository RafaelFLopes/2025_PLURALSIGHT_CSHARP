using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    // utilizamos struct para definir um tipo de valor leve que pode ser usado para agrupar dados relacionados
    internal struct WorkTask
    {
        public string description;
        public int hours;
        public void PerformWorkTask()
        {
            Console.WriteLine($"Performing task: {description} for {hours} hour(s).");
        }
    }
}
