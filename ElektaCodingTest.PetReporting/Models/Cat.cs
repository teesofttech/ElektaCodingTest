using ElektaCodingTest.PetReporting.Models.Common;

namespace ElektaCodingTest.PetReporting.Models
{
    public class Cat : Pet
    {
        public int? NumberOfLives { get; set; }
        public double CostPerVisit { get; set; }

        public Cat(string firstName, string lastName, int numberOfVisits, DateTime joinedPractice, int? numberOfLives)
            : base(firstName, lastName, numberOfVisits, joinedPractice)
        {
            NumberOfLives = numberOfLives;
        }
    }
}
