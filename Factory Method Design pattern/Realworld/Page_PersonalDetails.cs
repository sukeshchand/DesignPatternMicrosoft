namespace BridgeTechWhizz
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Page_PersonalDetails : Page_Abstract
    {
        // Factory Method
        public Page_PersonalDetails()
        {
            PageContent = "PersonalDetails";
        }
        public override string PageContent { get; set; }
    }
}