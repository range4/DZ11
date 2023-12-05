using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU11
{
    internal class Creator
    {
        private static Dictionary<uint, Building> buildingDictionary = new Dictionary<uint, Building>();

        private Creator()
        {
        }

        public static Building CreateBuild(uint buildingNumber, uint height, uint floors, uint apartments, uint entrances)
        {
            Building building = new Building(buildingNumber, height, floors, apartments, entrances);
            buildingDictionary.Add(buildingNumber, building);
            return building;
        }

        public static void RemoveBuilding(uint buildingNumber)
        {
            buildingDictionary.Remove(buildingNumber);
        }
    }
}