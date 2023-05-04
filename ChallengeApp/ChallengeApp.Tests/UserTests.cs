

namespace ChallengeApp.Tests
{
    public class UserTests
    {
       
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // arrange
            var user = new Employee("Adam", "Kowalski", "32");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-2);
            user.AddScore(-6);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(3, result);
        }
    }
}