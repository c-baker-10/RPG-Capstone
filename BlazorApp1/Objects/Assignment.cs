namespace BlazorApp1.Objects
{
    public class Assignment
    {
        public static List<Assignment> AssignmentList = new List<Assignment>();
        public string assignmentName { get; set; }
        public string score { get; set; }

        public bool taken = false;

    }
}
