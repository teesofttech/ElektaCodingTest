namespace ElektaCodingTest.PetReporting
{
    public class PetReportGenerator : IPetReportGenerator
    {
        public void GenerateReport(IEnumerable<Pet> pets, string filename)
        {
            List<string> entries = new List<string>();
            entries.Add("Owner's name,Date Joined Practice,Number Of Visits,Number of Lives");

            foreach (var pet in pets)
            {
                string entry = $"{pet.FirstName} {pet.LastName},{pet.JoinedPractice},{pet.NumberOfVisits}";

                if (pet is Cat cat)
                {
                    entry += $",{cat.NumberOfLives}";
                }

                entries.Add(entry);
            }

            File.WriteAllLines(filename, entries);
        }
    }
}
