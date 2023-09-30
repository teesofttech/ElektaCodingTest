namespace ElektaCodingTest.PetReporting.Test
{
    public class PetReportingTest
    {
        [Fact]
        public void Pet_Report_Should_Return_Generate_CSV_Valid()
        {
            var pets = new List<Pet>
            {
                new Dog("Jim", "Rogers", 5, DateTime.Now),
                new Dog("Tony", "Smith", 10, new DateTime(1985, 7, 13)),
                new Cat("Steve", "Roberts", 20, new DateTime(2002, 5, 6), 9)
            };

            var reportGenerator = new PetReportGenerator();
            reportGenerator.GenerateReport(pets, "PetsReport.csv");

            var outPets = File.ReadAllLines("PetsReport.csv");

            Assert.Equal(4, outPets.Length);
        }
    }
}
