using System.Collections.Generic;

namespace BridgeTechWhizz
{
    partial class Program
    {
        public class PANAdapter : IPersonAdapter
        {
            public List<PersonLocal> TransformData()
            {
                PANAdaptee PANAdaptee = new PANAdaptee();
                var PANData = PANAdaptee.GetPersonList();

                var localPersons = new List<PersonLocal>();
                foreach (var personPAN in PANData)
                {
                    localPersons.Add(new PersonLocal()
                    {
                        PersonCode = personPAN.PANPersonCode,
                        PersonName = personPAN.PANPersonName
                    });
                }
                return localPersons;
            }
        }
    }

}
