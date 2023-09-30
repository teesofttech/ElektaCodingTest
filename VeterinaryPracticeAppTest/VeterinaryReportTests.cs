using VeterinaryPracticeApp.Models.Common;

namespace VeterinaryPracticeAppTest
{
    public class VeterinaryReportTests
    {
        [Fact]
        public void TestGeneratePetReport()
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

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(4, outPets.Length);
        }
    }

}
