using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab14;

namespace KFU11
{
    [DeveloperInfo("Vladislav N", "05.12.20023")]
    public class Building
    {
        private uint BuildingNumber;
        public uint Height;
        private uint Floors;
        private uint Apartments;
        private uint Entrances;

        public Building(uint buildingNumber, uint height, uint floors, uint apartments, uint entrances)
        {
            Height = height;
            Floors = floors;
            Apartments = apartments;
            Entrances = entrances;
            BuildingNumber = buildingNumber;
        }

        public Building()
        {
            Height = 20;
            Floors = 5;
            Apartments = 30;
            Entrances = 2;
            BuildingNumber = GetNextBuildingNumber();

        }


        private static uint nextBuildingNumber = 1;

        public uint _BuildingNumber
        {
            get { return BuildingNumber; }
        }

        public uint _Height
        {
            get { return Height; }
            set { Height = value; }
        }

        public uint _Floors
        {
            get { return Floors; }
            set { Floors = value; }
        }

        public uint _Apartments
        {
            get { return Apartments; }
            set { Apartments = value; }
        }

        public uint _Entrances
        {
            get { return Entrances; }
            set { Entrances = value; }
        }

        public uint ApartmentsOnFloor
        {
            get { return Apartments / Floors; }
        }

        public uint ApartmentsInEntrance
        {
            get { return Apartments / Entrances; }
        }

        public uint FloorHeight
        {
            get { return Height / Floors; }
        }

        private static uint GetNextBuildingNumber()
        {
            uint buildingNumber = nextBuildingNumber;
            nextBuildingNumber++;
            return buildingNumber;
        }

        public override string ToString()
        {
            return $"Номер здания: {BuildingNumber}, высота: {Height}, этажность: {Floors}, количество квартир: {Apartments}, количество подъездов: {Entrances}";
        }


    }
}