using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IronXL;

namespace BlazorApp1.Objects
{
    public class User
    {
        public static User user { get; set; }
        public static string UserName { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string General { get; set; }
        public string Badges { get; set; }
        public string Items { get; set; }
        public string Stuff { get; set; }

        public string[] Grades { get; set; }

        public List<string[]> skillDistribution = new List<string[]>();
        public string Level { get; set; }


        public void buildUser()
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

            bool UserName = false;
            bool Password = false;
            bool Type = false;
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
                    Password = false; Type = false; General = false; Badges = false; Items = false; Stuff = false; Level = false; Distribution = false;
                    continue;
                }
                if (line == "PASSWORD|")
                {
                    UserName = false;
                    Password = true;
                    Type = false; General = false; Badges = false; Items = false; Stuff = false; Level = false; Distribution = false;
                    continue;
                }
                if (line == "TYPE|")
                {
                    UserName = false;
                    Password = false;
                    Type = true; 
                    General = false; Badges = false; Items = false; Stuff = false; Level = false; Distribution = false;
                    continue;
                }
                if (line == "GENERAL|")
                {
                    UserName = false;
                    Password = false;
                    Type = false;
                    General = true;
                    Badges = false; Items = false; Stuff = false; Level = false; Distribution = false;
                    continue;
                }
                if (line == "BADGES|")
                {
                    UserName = false;
                    Password = false;
                    Type = false;
                    General = false;
                    Badges = true;
                    Items = false; Stuff = false; Level = false; Distribution = false;
                    continue;
                }
                if (line == "ITEMS|")
                {
                    UserName = false;
                    Password = false;
                    Type = false;
                    General = false;
                    Badges = false;
                    Items = true;
                    Stuff = false; Level = false; Distribution = false;
                    continue;
                }
                if (line == "STUFF|")
                {
                    UserName = false;
                    Password = false;
                    Type = false;
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
                    Password = false;
                    Type = false;
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
                    Password = false;
                    Type = false;
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
                else if (Password)
                {
                    this.Password = line;
                }
                else if (Type)
                {
                    this.Type = line;
                }
                else if (General)
                {
                    this.General = line;
                }
                else if (Badges)
                {
                    this.Badges = line;
                }
                else if (Items)
                {
                    this.Items = line;
                }
                else if (Stuff)
                {
                    this.Stuff = line;
                }
                else if (Level)
                {
                    this.Level = line;
                }
                else if (Distribution)
                {
                    this.skillDistribution.Add(line.Split(";"));
                }
            }
        }
        public void saveData()
        {
            string FolderPath = Directory.GetCurrentDirectory() + @"\UserRecords\";
            string FileName = User.UserName + ".txt";
            string accountInfo = "";

            File.Delete(FolderPath+FileName);

            FileStream FileWrite = new FileStream(FolderPath + FileName, FileMode.Create, FileAccess.Write, FileShare.None);

            accountInfo += "NAME|\n" + User.UserName + "\n";

            accountInfo += "PASSWORD|\n" + this.Password + "\n";

            accountInfo += "TYPE|\n" + this.Type + "\n";

            accountInfo += "GENERAL|\n" + this.General + "\n";

            accountInfo += "BADGES|\n" + this.Badges + "\n";

            accountInfo += "ITEMS|\n" + this.Items + "\n";

            accountInfo += "STUFF|\n" + this.Stuff + "\n";

            accountInfo += "LEVEL|\n" + this.Level + "\n";

            accountInfo += "DISTRIBUTION|\n";
            if (skillDistribution != null)
            {
                foreach (string[] skill in this.skillDistribution)
                {
                    accountInfo += skill[0] + ";" + skill[1] + ";\n";
                }
            }

            // Store the text in a byte array with. UTF8 encoding (8-bit Unicode. Transformation Format)
            byte[] writeArr = Encoding.UTF8.GetBytes(accountInfo);

            // Using the Write method write the encoded byte array to the textfile
            FileWrite.Write(writeArr, 0, accountInfo.Length);

            // Closee the FileStream object
            FileWrite.Close();
        }
    }
}
