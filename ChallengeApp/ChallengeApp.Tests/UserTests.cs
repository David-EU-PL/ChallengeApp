using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    public class UserTests
    {
        [Test]
        public void FloatTypeTests()
        {
            // arrange
            float floatValue1 = 1.3f;
            float floatValue2 = 1.3f;

            // act

            // assert
            Assert.AreEqual(floatValue2, floatValue2);
        }

        [Test]
        public void StringTypeTests()
        {
            // arrange
            string user1 = "Dawid";
            string user2 = "Dawid";

            // act


            // assert
            Assert.AreEqual(user1, user2);
        }

        [Test]
        public void IntTypeTests()
        {
            // arrange
            int number1 = 10;
            int number2 = 2;

            // act

            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void ReferenceTypeTests()
        {
            // arrange
           var user1 = GetUser("Dawid");
           var user2 = GetUser("Dawid");

            // act
            

            // assert
            Assert.AreNotEqual(user1, user2);
        }

        private Employee GetUser(string name)
        {
            return new Employee(name);
        }
    }
}
