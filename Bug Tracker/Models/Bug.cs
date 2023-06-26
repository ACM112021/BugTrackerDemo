namespace BugTrackerWebApplication.Models
{
    public class Bug
    {
        public int BugId { get; set; }

        public string BugIssue { get; set; }
        public string BugSolution { get; set; }


        public Bug()
        {
            // "will be used by other pieces of code and needs to be left blank"
        }
    }
}
