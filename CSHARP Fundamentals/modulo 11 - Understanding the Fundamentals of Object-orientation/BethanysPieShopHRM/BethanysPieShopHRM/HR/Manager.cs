using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Manager : Employee
    {
        public Manager(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
            
        }

        public void AttendManagementMeeting()
        {
            NumberOfHoursWorked += 10;
            Console.WriteLine($"{FirstName} {LastName} is attending a management meeting.");
        }

        public override void GiveBonus()
        {
              if(NumberOfHoursWorked > 5)
              {
                  Console.WriteLine($"{FirstName} {LastName} has received a manager bonus of 500.");
              }
              else
              {
                  Console.WriteLine($"{FirstName} {LastName} has received a manager bonus of 200.");
            }
        }
    }
}
