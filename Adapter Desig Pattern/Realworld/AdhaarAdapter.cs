using System.Collections.Generic;

namespace BridgeTechWhizz
{
    partial class Program
    {
        // Adapter will transform the data
        public class AdhaarAdapter : IPersonAdapter
        {
            public List<PersonLocal> TransformData()
            {
                AdhaarAdaptee adhaarAdaptee = new AdhaarAdaptee();
                var adhaarData = adhaarAdaptee.GetPersonList();

                var localPersons = new List<PersonLocal>();
                foreach (var personAdhaar in adhaarData)
                {
                    localPersons.Add(new PersonLocal()
                    {
                        PersonCode = personAdhaar.AdhaarPersonCode,
                        PersonName = personAdhaar.AdhaarPersonName
                    });
                }
                return localPersons;
            }
        }
    }

}
