namespace BlazorApp1.Objects
{
    public class AssignmentQuestion
    {
        public string question;

        public AssignmentQuestion(string question)
        {
            this.question = question;
        }
        public string type { get; set; }
        public string[] options { get; set; }
        public string[] answers { get; set; }
        public string[] inputedAnswers { get; set; }
        public bool correct { get; set; }

        public void correctInput()
        {
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
    }
}
