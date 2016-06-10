using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMTools
{
    class TownGenerator
    {
        List<Building> allBuildings;

        public void createTown(List<Building> lstAllBuildings, List<String> requiredBuildings, string size)
        {
            allBuildings = lstAllBuildings;

        }

        public string generateName()
        {

        }

        public int generatePopulation(string size)
        {
            return 100;
        }

    }
}
