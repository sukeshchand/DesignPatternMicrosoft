using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTechWhizz
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adhaar Adapter example. Import Adhaar person data into our local person table");
            Console.WriteLine("----------------------------------------------------------------------------------");
            IPersonAdapter adhaarAdapter = new AdhaarAdapter();
            List<PersonLocal> transformedPersonsFromAdhaar = adhaarAdapter.TransformData();
            foreach (var personLocal in transformedPersonsFromAdhaar)
            {
                Console.WriteLine("Person Code:" + personLocal.PersonCode + ", " + "Person Name: " + personLocal.PersonName);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("PAN Adapter example. Import PAN person data into our local person table");
            Console.WriteLine("----------------------------------------------------------------------------------");
            IPersonAdapter panAdapter = new PANAdapter();
            List<PersonLocal> transformedPersonsFromPAN = panAdapter.TransformData();
            foreach (var personLocal in transformedPersonsFromPAN)
            {
                Console.WriteLine("Person Code:" + personLocal.PersonCode + ", " + "Person Name: " + personLocal.PersonName);
            }
            Console.ReadKey();
        }
    }

}
