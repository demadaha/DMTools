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
        //Later there will be a map of the town.

        public Town(TownGenerator townGen, string strSize, List<Building> lstReqBuildings)
        {
            name = townGen.generateName();
            population = townGen.generatePopulation(strSize);
            buildings = new List<Building>(lstReqBuildings);
            information = townInfo();
        }

        //Builds a nicely formatted string of the towns information
        private string townInfo()
        {
            StringBuilder infoBuilder = new StringBuilder();

            infoBuilder.Append("Name: " + name + "\n\n");
            infoBuilder.Append("Population: " + population.ToString() + "\n\n");
            infoBuilder.Append("Buildings: \n");

            foreach(Building structure in buildings)
            {
                infoBuilder.Append(structure.getName() + "\n");
            }

            return infoBuilder.ToString();

        }

    }
}
