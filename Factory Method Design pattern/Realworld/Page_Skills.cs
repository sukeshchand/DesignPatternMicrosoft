namespace BridgeTechWhizz
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Page_Skills : Page_Abstract
    {
        // Factory Method
        public Page_Skills()
        {
            PageContent = "SkillsPageContent";
        }
        public override string PageContent { get; set; }
    }
}