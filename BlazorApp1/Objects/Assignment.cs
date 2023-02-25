namespace BlazorApp1.Objects
{
    public class Assignment
    {
        public static List<Assignment> AssignmentList = new List<Assignment>();
        public string assignmentName { get; set; }
        public string score { get; set; }

        public bool taken = false;

        public static void getAssignments()
        {
            string[] Files;
            bool added = false;
            string FolderPath = Directory.GetCurrentDirectory() + @"\AssignmentFolder\";

            Files = Directory.GetFiles(FolderPath);

            foreach (string file in Files)
            {
                foreach (Assignment assignment in Assignment.AssignmentList)
                {
                    if (assignment.assignmentName == Path.GetFileName(file))
                    {
                        added = true;
                    }
                }

                if (!added)
                {
                    Assignment A = new Assignment();
                    A.assignmentName = Path.GetFileName(file);
                    Assignment.AssignmentList.Add(A);
                }
                added = false;
            }
        }

    }
}
