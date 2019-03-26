using System;
using Calculator;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Hazırlama Aşaması
            SalaryCalculator salaryCalculator = new SalaryCalculator();

            //Hareket Aşaması - Act
            decimal annualSalary = salaryCalculator.GetAnnualSalary(40);

            //İddia Etme Aşaması - Assert
            Assert.Equal(93600, annualSalary);
        }

        [Fact]
        public void Test2()
        {
            SalaryCalculator salaryCalculator = new SalaryCalculator();

            decimal hourlyWage = salaryCalculator.GetHourlyWage(93600);

            Assert.Equal(40, hourlyWage);
        }
    }
}
