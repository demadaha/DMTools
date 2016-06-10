using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using System.IO;

namespace DMTools
{
    public partial class frmTown : Form
    {

        private List<Building> allBuildings = new List<Building>();
        private TownGenerator townGen;
        private Town curTown;

        public frmTown()
        {
            InitializeComponent();

            List<Building> allBuildings = getBuildingInfo("..\\..\\Buildings.xml");
            townGen = new TownGenerator(allBuildings);
            

            //Fill in the listbox of building names with the building list
            foreach (Building building in allBuildings)
            {
                lbxAddBuilding.Items.Add(building.getName());
            }
      
            //It should already be set to sort but make sure
            lbxAddBuilding.Sorted = true;

        }

        //Button that adds selected item to required buildings list box
        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            if (lbxAddBuilding.SelectedItem != null)
            {
                lbxReqBuilding.Items.Add(lbxAddBuilding.SelectedItem);
            }
        }

        //Button that removes selected item from required buildings list box
        private void btnRemoveBuilding_Click(object sender, EventArgs e)
        {
            if (lbxReqBuilding.SelectedItem != null)
            {
                lbxReqBuilding.Items.Remove(lbxReqBuilding.SelectedItem);
            }
        }

        //This creates a town based on the given paramaters
        private void generateTown()
        {


        }

        //Move this to the town generator... Maybe
        private List<Building> getBuildingInfo(string BuildingsPath)
        {
            XmlTextReader reader = new XmlTextReader(BuildingsPath);
            string buildingName = "";
            int buildingLength = 0;
            int buildingWidth = 0;

            //Move to the first building
            while (reader.Name != "BUILDING")
            {
                reader.Read();
            }

            //Read through the xml
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case ("NAME"):
                            reader.Read();
                            buildingName = reader.Value;
                            break;
                        case ("LENGTH"):
                            reader.Read();
                            buildingLength = int.Parse(reader.Value);
                            break;
                        case ("WIDTH"):
                            reader.Read();
                            buildingWidth = int.Parse(reader.Value);
                            break;
                    }
                }

                //If we've reached the end of a building element 
                if (reader.Name == "BUILDING" && !reader.IsStartElement())
                {
                    //Create our list of buildings that we'll refer to when generating the town
                    allBuildings.Add(new Building(buildingName, buildingLength, buildingWidth));
                }
            }

            return allBuildings;
        }

        private void btnCreateTown_Click(object sender, EventArgs e)
        {
            List<Building> requiredBuildings = new List<Building>();

            //Build the list of buildings that must be in the town
            //This is n^2 but it won't ever be long enough to be significant
            foreach(string buildingName in lbxReqBuilding.Items)
            {
                requiredBuildings.Add(allBuildings.Find(Building => Building.getName().Equals(buildingName)));
            }

            curTown = new Town(townGen, cmbSize.Text, requiredBuildings);

            rtbTownInfo.Text = curTown.information;
        }
    }
}
