using System.Collections.Generic;

namespace BridgeTechWhizz
{
    partial class Program
    {
        // Adhaar Adaptee will provide the data
        public class AdhaarAdaptee
        {
            public List<PersonAdhaar> GetPersonList()
            {
                List <PersonAdhaar> dataForImport = new List<PersonAdhaar>();
                for (int i = 0; i < 10; i++)
                {
                    dataForImport.Add(new PersonAdhaar(){ AdhaarPersonCode = i.ToString(), AdhaarPersonName = "Adhaar Person_" + i.ToString()});
                }
                return dataForImport;
            }
        }
    }

}
