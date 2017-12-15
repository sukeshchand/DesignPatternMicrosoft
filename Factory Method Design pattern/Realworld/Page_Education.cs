namespace BridgeTechWhizz
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Page_Education : Page_Abstract
    {
        // Factory Method
        public Page_Education()
        {
            PageContent = "EducationPage";
        }
        public override string PageContent { get; set; }
    }
}