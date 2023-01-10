namespace BlazorApp1.Objects
{
    public class Connectors
    {
        public string name;

        public Connectors(string name)
        {
            this.name = name;
        }

        public string xPosistion { get; set; }
        public string yPosistion { get; set; }
        public string width { get; set; }
        public string height { get; set; }
    }
}
