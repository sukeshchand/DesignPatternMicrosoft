namespace BridgeTechWhizz
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class Document_JobResume : Document_Abstract
    {

        // Factory Method implementation in the constructor
        public override void CreatePages()
        {
            Pages.Add(new Page_PersonalDetails());
            Pages.Add(new Page_Skills());
            Pages.Add(new Page_Education());
            Pages.Add(new Page_Experience());
        }
    }
}