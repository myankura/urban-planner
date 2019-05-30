using System;
using System.Collections.Generic;

namespace Planner
{
    //Define City class
    class City
    {
        //CONSTRUCTOR
        public City(string cityName)
        {
            CityName = cityName;
        }

        public string CityName { get; set; }

        public string Mayor { get; set; }

        public int YearEstablished { get; set; }

        //Create a list for holding buildings
        public List<Building> BuildingList = new List<Building>();

        //Create a method for adding new buildings to the list
        public void NewBuilding(Building newBuilding)
        {
            BuildingList.Add(newBuilding);
        }

        //Create a method for displaying the city's info
        public void DisplayCityInfo()
        {
            Console.WriteLine("======================");
            Console.WriteLine($"City name: {CityName}");
            Console.WriteLine($"Mayor of city: {Mayor}");
            Console.WriteLine($"Year established: {YearEstablished}");
            Console.WriteLine();
        }
    }
}