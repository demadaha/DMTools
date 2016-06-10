using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace DMTools
{
    class TownGenerator
    {
        List<Building> allBuildings;
        List<String> namePrefixes = new List<string>();
        List<String> nameSuffixes = new List<string>();
        Random rndNumber = new Random();

        public TownGenerator(List<Building> lstAllBuildings)
        {
            allBuildings = lstAllBuildings;
            loadNameData();
        }

        //Loads the prefixes and suffixes for town names.
        private void loadNameData()
        {
            StreamReader reader = new StreamReader("..//..//prefixes.txt");

            while (!reader.EndOfStream)
            {
                namePrefixes.Add(reader.ReadLine());
            }

            reader.Close();

            reader = new StreamReader("..//..//suffixes.txt");

            while (!reader.EndOfStream)
            {
                nameSuffixes.Add(reader.ReadLine());
            }

            reader.Close();
        }

        //this will eventually return an image that is a map of the town.
        public void createMap(List<Building> lstAllBuildings, List<String> requiredBuildings, string size)
        {
            allBuildings = lstAllBuildings;
        }

        //Make a name by slapping a prefix and a suffix together
        public string generateName()
        {
            string prefix = namePrefixes[Convert.ToInt32(rndNumber.NextDouble() * (namePrefixes.Count() - 1))];
            string suffix = nameSuffixes[Convert.ToInt32(rndNumber.NextDouble() * (nameSuffixes.Count() - 1))];

            return prefix + suffix;
        }

        //The total number of people that inhabit the town.
        public int generatePopulation(string size)
        {
            switch (size)
            {
                //Farms have between 2 and 21
                case ("Farm"):
                    return Convert.ToInt32(rndNumber.NextDouble() * 19 + 2);
                //Hamlets have between 10 and 100
                case ("Hamlet"):
                    return Convert.ToInt32(rndNumber.NextDouble() * 90 + 10);
                //Villages have between 100 and 1,000
                case ("Village"):
                    return Convert.ToInt32(rndNumber.NextDouble() * 900 + 100);
                //Towns have between 1,000 and 10,000
                case ("Town"):
                    return Convert.ToInt32(rndNumber.NextDouble() * 9000 + 100);
                //Cities have between 10,000 and 15,000
                case ("City"):
                    return Convert.ToInt32(rndNumber.NextDouble() * 5000 + 10000);
                default:
                    return 0;
            }
        }
    }
}
