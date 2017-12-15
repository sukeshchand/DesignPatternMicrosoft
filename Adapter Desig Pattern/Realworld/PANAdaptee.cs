using System.Collections.Generic;

namespace BridgeTechWhizz
{
    partial class Program
    {
        // PAN Adaptee will provide the data
        public class PANAdaptee
        {
            public List<PersonPAN> GetPersonList()
            {
                List<PersonPAN> dataForImport = new List<PersonPAN>();
                for (int i = 0; i < 10; i++)
                {
                    dataForImport.Add(new PersonPAN() { PANPersonCode = i.ToString(), PANPersonName = "PAN Person_" + i.ToString() });
                }
                return dataForImport;
            }
        }
    }

}
