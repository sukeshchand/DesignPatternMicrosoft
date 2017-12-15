// Client class

using System;

namespace BridgeTechWhizz
{
    public class MainApp
    {
        static void Main()
        {
            Console.WriteLine("Create Resume for Higher Education (Creation is happening inside the concrete object)\n------------------------");
            Document_Abstract resumeEducation1 = new Document_HigherEducationResume();
            foreach (var resumeEducationPage in resumeEducation1.Pages)
            {
                Console.WriteLine(resumeEducationPage.PageContent);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Create Resume for Job (Creation is happening inside the concrete object)\n------------------------");
            Document_Abstract resumeJob1 = new Document_JobResume();
            foreach (var resumeJobPage in resumeJob1.Pages)
            {
                Console.WriteLine(resumeJobPage.PageContent);
            }

            Console.WriteLine("\n\n\n\n");


            Console.WriteLine("Create Resume for Higher Education (Creation is happening in a separate factory class)\n------------------------");
            Document_Abstract resumeEducation2 = new DocumentFactory().GetDocument(1);
            foreach (var resumeEducationPage in resumeEducation2.Pages)
            {
                Console.WriteLine(resumeEducationPage.PageContent);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Create Resume for Job (Creation is happening in a separate factory class)\n------------------------");
            Document_Abstract resumeJob2 = new DocumentFactory().GetDocument(2);
            foreach (var resumeJobPage in resumeJob2.Pages)
            {
                Console.WriteLine(resumeJobPage.PageContent);
            }


            Console.ReadKey();
        }
    }
}
