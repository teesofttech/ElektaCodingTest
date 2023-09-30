namespace VeterinaryPracticeApp.Models.Common
{
    public abstract class Pet
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfVisits { get; set; }
        public DateTime JoinedPractice { get; set; }

        protected Pet(string firstName, string lastName, int numberOfVisits, DateTime joinedPractice)
        {
            FirstName = firstName;
            LastName = lastName;
            NumberOfVisits = numberOfVisits;
            JoinedPractice = joinedPractice;
        }
    }
}
