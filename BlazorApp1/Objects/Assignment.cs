using Microsoft.Extensions.Options;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace BlazorApp1.Objects
{
    public class Assignment
    {
        public static List<Assignment> AssignmentList = new List<Assignment>();
        public string assignmentName { get; set; }
        public string score { get; set; }

        public bool taken = false;
        public string dueDate { get; set; }

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

                    // Read a text file line by line.
                    string[] lines = File.ReadAllLines(FolderPath + A.assignmentName);
                    bool Due = false;
                    foreach(string s in lines)
                    {
                        if(s == "DUE|")
                        {
                            Due = true;
                            continue;
                        }
                        else if (Due)
                        {
                            A.dueDate = s;
                            break;
                        }
                    }

                    foreach (string[] name in User.user.takenAssignments) 
                    {
                        if (A.assignmentName == name[0])
                        {
                            A.taken = true;
                            A.score = name[1];
                        }
                    }

                    Assignment.AssignmentList.Add(A);
                }
                added = false;
            }
        }

    }
}
