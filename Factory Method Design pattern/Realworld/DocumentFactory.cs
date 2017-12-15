using System;
using System.Collections.Generic;

namespace BridgeTechWhizz
{
    /// <summary>
    /// The 'Creator' factory class
    /// </summary>
    public class DocumentFactory
    {
        public Document_Abstract GetDocument(int documentType)
        {
            if (documentType == 1)
            {
                return new Document_HigherEducationResume();
            }
            else if (documentType == 2)
            {
                return new Document_JobResume();
            }
            else
            {
                throw new Exception("Invalid document type");
            }
        }
    }
}