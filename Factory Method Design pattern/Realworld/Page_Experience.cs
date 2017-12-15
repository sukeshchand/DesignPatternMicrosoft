namespace BridgeTechWhizz
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Page_Experience : Page_Abstract
    {
        // Factory Method
        public Page_Experience()
        {
            PageContent = "ExperiencePage";
        }
        public override string PageContent { get; set; }
    }
}