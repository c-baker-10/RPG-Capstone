namespace BlazorApp1.Objects
{
    public class Node
    {
        public string name;

        public List<Node> NodeConnections = new List<Node>();

        public Node(string name)
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

        public bool startingNode = false;
        public bool userAt = false;


    }
}
