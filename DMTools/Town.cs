using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMTools
{
    class Town
    {
        public string name;
        public int population;
        public List<Building> buildings;
        public string information;

        public Town()
        {

        }

        private void createTown(List<Building> lstAllBuildings, List<String> requiredBuildings, string size)
        {
            population = generatePopulation(size);
            name = generateName();
        }

        private string generateName()
        {
            return "Springfield";
        }

        private int generatePopulation(string size)
        {
            Random rndNumber = new Random();

            switch(size)
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
                    return Convert.ToInt32(rndNumber.NextDouble() * 500 + 10000);
            }

            return 100;
        }

    }
}
