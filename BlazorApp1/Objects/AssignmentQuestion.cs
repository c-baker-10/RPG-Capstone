namespace BlazorApp1.Objects
{
    public class AssignmentQuestion
    {
        public string question;

        public AssignmentQuestion(string question)
        {
            this.question = question;
        }

        public AssignmentQuestion() { }
        public string type { get; set; }
        public string[] options { get; set; }
        public string StringOptions { get; set; }
        public string[] answers { get; set; }
        public string StringAnswers { get; set; }
        public string[] inputedAnswers { get; set; }
        public bool correct { get; set; }
        public int points { get; set; }
        public string StringPoints { get; set; }

        public List<string[]> skillValueDistribution = new List<string[]>();

        public string Distribution { get; set; }

        public void correctInput()
        {
            if(type == "text")
            {
                if (inputedAnswers[0].Contains(answers[0]))
                {
                    correct = true;
                    return;
                }
            }

            if(answers.Length != inputedAnswers.Length)
            {
                correct = false;
                return;
            }

            foreach(string ans in answers)
            {
                if(!inputedAnswers.Contains(ans))
                {
                    correct = false;
                    return;
                }
            }
            correct = true;
        }

        public static List<AssignmentQuestion> loadQuestions(string name)
        {
            string FolderPath = Directory.GetCurrentDirectory() + @"\AssignmentFolder\";

            List<AssignmentQuestion> Questions = new List<AssignmentQuestion>();
            AssignmentQuestion question = null;
            bool QuestionSec = false;
            bool TypeSec = false;
            bool OptionSec = false;
            bool AnswerSec = false;
            bool points = false;
            bool Distribution = false;


            // Read a text file line by line.
            string[] lines = File.ReadAllLines(FolderPath + name);

            foreach (string line in lines)
            {
                if (line.Trim() == "questions|")
                {
                    QuestionSec = true;
                    TypeSec = false;
                    OptionSec = false;
                    AnswerSec = false;
                    points = false;
                    Distribution = false;
                    continue;
                }
                else if (line.Trim() == "type|")
                {
                    QuestionSec = false;
                    TypeSec = true;
                    OptionSec = false;
                    AnswerSec = false;
                    points = false;
                    Distribution = false;
                    continue;
                }
                else if (line.Trim() == "options|")
                {
                    QuestionSec = false;
                    TypeSec = false;
                    OptionSec = true;
                    AnswerSec = false;
                    points = false;
                    Distribution = false;
                    continue;
                }
                else if (line.Trim() == "answer|")
                {
                    QuestionSec = false;
                    TypeSec = false;
                    OptionSec = false;
                    AnswerSec = true;
                    points = false;
                    Distribution = false;
                    continue;
                }
                else if (line.Trim() == "Points|")
                {
                    QuestionSec = false;
                    TypeSec = false;
                    OptionSec = false;
                    AnswerSec = false;
                    points = true;
                    Distribution = false;
                    continue;
                }
                else if (line.Trim() == "DISTRIBUTION|")
                {
                    QuestionSec = false;
                    TypeSec = false;
                    OptionSec = false;
                    AnswerSec = false;
                    points = false;
                    Distribution = true;
                    continue;
                }
                else if (line.Trim() == "end|")
                {
                    QuestionSec = false;
                    TypeSec = false;
                    OptionSec = false;
                    AnswerSec = false;
                    points = false;
                    Distribution = false;
                    Questions.Add(question);
                    continue;
                }

                if (QuestionSec)
                {
                    question = new AssignmentQuestion(line);
                }
                else if (TypeSec)
                {
                    question.type = line;
                }
                else if (OptionSec)
                {
                    question.options = line.Split(';');
                }
                else if (AnswerSec)
                {
                    question.answers = line.Split(';');
                }
                else if (points)
                {
                    question.points = Int32.Parse(line);
                }
                else if (Distribution)
                {
                    question.skillValueDistribution.Add(line.Split(";"));
                }
            }
            return Questions;
        }
    }

}
