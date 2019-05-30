using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new instance of a City
            City Verboseville = new City("Verboseville","Mark Methods", 2019);

            //Create several buildings.
            Building FiveOneTwoEigth = new Building("512 8th Avenue", 5, 500, 400);
            Building SixOneFiveBroad = new Building("615 Broadway", 7, 800, 500);
            Building NineOneTwoSecond = new Building("912 2nd Avenue", 6, 600, 450);

            //Construct each building
            FiveOneTwoEigth.Construct();
            SixOneFiveBroad.Construct();
            NineOneTwoSecond.Construct();

            //Add owners to each building.
            FiveOneTwoEigth.Purchase("Michael Yankura");
            SixOneFiveBroad.Purchase("Billy Mays");
            NineOneTwoSecond.Purchase("Ken M");

            //Add buildings to the list collection that lives in City.cs
            Verboseville.NewBuilding(FiveOneTwoEigth);
            Verboseville.NewBuilding(SixOneFiveBroad);
            Verboseville.NewBuilding(NineOneTwoSecond);

            //iterate through the collection of buildings in Verboseville
            foreach(Building bldgs in Verboseville.BuildingList) {
                bldgs.DisplayDetails();
            }

            Console.WriteLine("----------------------");
            //Display City Info
            Verboseville.DisplayCityInfo();
        }
    }
}
