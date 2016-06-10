using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMTools
{
    //Holds information about a building that can be in a town
    class Building
    {
        private string name;
        private int length;
        private int width;

        public Building(string strName, int intLength, int intWidth)
        {
            name = strName;
            length = intLength;
            width = intWidth;
        }

        public int getLength()
        {
            return length;
        }

        public int getWidth()
        {
            return width;
        }

        public string getName()
        {
            return name;
        }
    }
}
