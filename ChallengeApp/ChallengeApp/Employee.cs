namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public string Age { get; private set; }
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
    }
}
