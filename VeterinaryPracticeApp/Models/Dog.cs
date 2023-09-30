using VeterinaryPracticeApp.Models.Common;

namespace VeterinaryPracticeApp.Models
{
    public class Dog : Pet
    {
        public double CostPerVisit { get; set; }

        public Dog(string firstName, string lastName, int numberOfVisits, DateTime joinedPractice)
            : base(firstName, lastName, numberOfVisits, joinedPractice)
        {
        }
    }
}
