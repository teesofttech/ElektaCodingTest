﻿namespace ElektaCodingTest.PetReporting
{
    public interface IPetReportGenerator
    {
        void GenerateReport(IEnumerable<Pet> pets, string filename);
    }
}
