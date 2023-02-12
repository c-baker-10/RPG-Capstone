namespace BlazorApp1.Objects
{
    public class User
    {

        public static string UserName { get; set; }
        public string Password { get; set; }

        public string General { get; set; }
        public string Badges { get; set; }
        public string Items { get; set; }
        public string Stuff { get; set; }

        public string[] Grades { get; set; }

        public List<string[]> skillDistribution = new List<string[]>();
        public string Level { get; set; }


        public User buildUser()
        {
            string FolderPath = Directory.GetCurrentDirectory() + @"\UserRecords\";
            string FileName = User.UserName + ".txt";
            string[] lines;
            try
            {
                lines = File.ReadAllLines(FolderPath + FileName);
            }
            catch(FileNotFoundException e)
            {
                lines = File.ReadAllLines(FolderPath + "testUser.txt");
            }
     
            User user = new User();

            bool UserName = false;
            bool General = false;
            bool Badges = false;
            bool Items = false;
            bool Stuff = false;
            bool Level = false;
            bool Distribution = false;

            foreach (string line in lines)
            {
                if (line == "NAME|")
                {
                    UserName = true;
                    General = false; Badges = false; Items = false; Stuff = false; Level = false; Distribution = false;
                    continue;
                }
                if (line == "GENERAL|")
                {
                    UserName = false;
                    General = true;
                    Badges = false; Items = false; Stuff = false; Level = false; Distribution = false;
                    continue;
                }
                if (line == "BADGES|")
                {
                    UserName = false;
                    General = false;
                    Badges = true;
                    Items = false; Stuff = false; Level = false; Distribution = false;
                    continue;
                }
                if (line == "ITEMS|")
                {
                    UserName = false;
                    General = false;
                    Badges = false;
                    Items = true;
                    Stuff = false; Level = false; Distribution = false;
                    continue;
                }
                if (line == "STUFF|")
                {
                    UserName = false;
                    General = false;
                    Badges = false;
                    Items = false;
                    Stuff = true;
                    Level = false; Distribution = false;
                    continue;
                }
                if (line == "LEVEL|")
                {
                    UserName = false;
                    General = false;
                    Badges = false;
                    Items = false;
                    Stuff = false;
                    Level = true;
                    Distribution = false;
                    continue;
                }
                if (line == "DISTRIBUTION|")
                {
                    UserName = false;
                    General = false;
                    Badges = false;
                    Items = false;
                    Stuff = false;
                    Level = false;
                    Distribution = true;
                    continue;
                }

                if (UserName)
                {
                    User.UserName = line;
                }
                else if (General)
                {
                    user.General = line;
                }
                else if (Badges)
                {
                    user.Badges = line;
                }
                else if (Items)
                {
                    user.Items = line;
                }
                else if (Stuff)
                {
                    user.Stuff = line;
                }
                else if (Level)
                {
                    user.Level = line;
                }
                else if (Distribution)
                {
                    user.skillDistribution.Add(line.Split(";"));
                }

            }

            return user;
        }

    }
}
