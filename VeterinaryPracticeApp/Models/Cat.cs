using VeterinaryPracticeApp.Models.Common;

namespace VeterinaryPracticeApp.Models
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
