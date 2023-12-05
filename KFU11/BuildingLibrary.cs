using System;
namespace KFU11
{
    internal class BuildingLibrary
    {
        private Building[] buildings = new Building[10];

        public BuildingLibrary()
        {
            for (int i = 0; i < buildings.Length; i++)
            {
                buildings[i] = new Building();
            }
        }

        public Building this[int index]
        {
            get
            {
                if (index < 0 || index >= buildings.Length)
                {
                    throw new ArgumentOutOfRangeException("индекс выходит за пределы диапазона");
                }

                return buildings[index];
            }
        }
    }
}

