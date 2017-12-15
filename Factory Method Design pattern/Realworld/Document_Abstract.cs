using System.Collections.Generic;

namespace BridgeTechWhizz
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class Document_Abstract
    {
        // Constructor calls abstract Factory method
        public Document_Abstract()
        {
            Pages = new List<Page_Abstract>();
            this.CreatePages();
        }

        public List<Page_Abstract> Pages { get; set; }

        // Factory Method
        public abstract void CreatePages();
    }
}