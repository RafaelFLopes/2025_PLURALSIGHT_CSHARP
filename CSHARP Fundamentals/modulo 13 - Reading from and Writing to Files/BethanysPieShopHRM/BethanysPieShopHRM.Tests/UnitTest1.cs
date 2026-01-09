using BethanysPieShopHRM.HR;

namespace BethanysPieShopHRM.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void PerformWork_Adds_NumberOfHours()
        {
            //Arrange
            Employee employee = new Employee("Bethany", "Smith", "bethany.smith@gmail.com", new DateTime(2001, 05, 03), 25);

            int numberOfHours = 3;

            //Act

            employee.PerformWork(numberOfHours);

            //Assert

            Assert.Equal(numberOfHours, employee.NumberOfHoursWorked);
        }

        [Fact]
        public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecified()
        {
            //Arrange
            Employee employee = new Employee("Bethany", "Smith", "bethany.smith@gmail.com", new DateTime(2001, 05, 03), 25);

            employee.PerformWork();

            Assert.Equal(1, employee.NumberOfHoursWorked);
        }
    }
}