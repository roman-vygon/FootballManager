using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FootballManager
{
    class Utility
    {
        public static int LevenshteinDistance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }

        public static Team getTeam(string teamName)
        {
            List<Player> players = new List<Player>();
            Player goalkeeper = null;
            string logoURL = "";
            using (var reader = new StreamReader(@"players.csv"))
            {               
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if (values[10].Contains(teamName))
                    {
                        int age = 0, overall = 0, potential = 0;
                        string name = "", photoURL = "", nationality = "", flagURL = "", foot = "", height = "", weight = "";
                        double stamina = 0;

                        String playerNumber = values[2];
                        String teamNumber = values[11].Split('/')[6].Split('.')[0];
                        while (playerNumber.Length != 6)
                            playerNumber = '0' + playerNumber;
                            

                        logoURL = String.Format("https://cdn.sofifa.com/teams/{0}/light_120.png", teamNumber);
                        name = values[3];
                    
                        age = Convert.ToInt32(values[4]);
                        photoURL = String.Format("https://cdn.sofifa.com/players/{0}/{1}/20_120.png", playerNumber[0].ToString() + playerNumber[1].ToString() + playerNumber[2].ToString(), playerNumber[3].ToString() + playerNumber[4].ToString() + playerNumber[5].ToString()); ;
                        nationality = values[6];
                        flagURL = values[7];
                        overall = Convert.ToInt32(values[8]);
                        potential = Convert.ToInt32(values[9]);
                        foot = values[15];
                        height = values[27];
                        weight = values[28];
                        stamina = double.Parse(values[73], System.Globalization.CultureInfo.InvariantCulture);
                        photoURL = photoURL.Replace("/4/", "/10/");
                        
                        players.Add(new Player(name, age, photoURL, nationality, flagURL, overall, potential, foot, height, weight, stamina));
                        if (values[22] == "GK" && goalkeeper == null)
                            goalkeeper = players[players.Count - 1];
                    }
                }                
            }
            return (new Team(teamName, logoURL, players, goalkeeper));
        }
        public static Player getPlayer(string name)
        {
            using (var reader = new StreamReader(@"players.csv"))
            {
                int minDist = 2147483647;
                int age = 0, overall = 0, potential = 0;
                string trueName = "", photoURL = "", nationality = "", flagURL = "", foot = "", height = "", weight = "";
                double stamina = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');                    
                    if (values[2] == "ID")
                        continue;
                    trueName = values[3];
                    int distance = LevenshteinDistance(name, trueName);
                    if (distance > minDist && !trueName.Contains(name))
                        continue;
                    minDist = distance;
                    age = Convert.ToInt32(values[4]);
                    photoURL = values[5];
                    nationality = values[6];
                    flagURL = values[7];
                    overall = Convert.ToInt32(values[8]);
                    potential = Convert.ToInt32(values[9]);
                    foot = values[15];
                    height = values[28];
                    weight = values[29];
                    stamina = double.Parse(values[73], System.Globalization.CultureInfo.InvariantCulture);
                    if (trueName.Contains(name))
                        break;
                }
                photoURL.Replace("/4/", "/10/");
                return (new Player(trueName, age, photoURL, nationality, flagURL, overall, potential, foot, height, weight, stamina));
            }
        }

        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
