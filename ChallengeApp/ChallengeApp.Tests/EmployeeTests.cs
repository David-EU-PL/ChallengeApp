using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void ValueMinStatistics()
        {
            // arrange
            var employee = new Employee("Dawid", "Płatek");
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void ValueMaxStatistics()
        {
            // arrange
            var employee = new Employee("Dawid", "Płatek");
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, statistics.Max);
        }

        [Test]
        public void ValueAverageStatistics()
        {
            // arrange
            var employee = new Employee("Dawid", "Płatek");
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(4.67, 2), Math.Round(statistics.Average, 2));    
        }
    }
}
