namespace BlazorApp1.Objects
{
    public class Branch
    {
        public string name;

        public List<Branch> NodeConnections = new List<Branch>();

        public Branch(string name)
        {
            this.name = name;
        }

        public string description { get; set; }
        public string links { get; set; }
        public string xPosistion { get; set; }
        public string yPosistion { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string EducationType { get; set; }
        public string entryScore { get; set; }

        public bool startingNode = false;
        public bool userAt = false;


    }
}
