using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create several buildings.
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            Building SixOneFiveBroad = new Building("615 Broadway");
            Building NineOneTwoSecond = new Building("912 2nd Avenue");

            //Set the properties for 512 8th Ave
            FiveOneTwoEigth.Width = 500;
            FiveOneTwoEigth.Depth = 400;
            FiveOneTwoEigth.Stories = 15;

            //Set the properties for 615 Broadway
            SixOneFiveBroad.Width = 800;
            SixOneFiveBroad.Depth = 500;
            SixOneFiveBroad.Stories = 21;

            //Set the properties for 912 2nd Ave
            NineOneTwoSecond.Width = 600;
            NineOneTwoSecond.Depth = 450;
            NineOneTwoSecond.Stories = 17;

            //Construct each building
            FiveOneTwoEigth.Construct();
            SixOneFiveBroad.Construct();
            NineOneTwoSecond.Construct();

            //Add owners to each building.
            FiveOneTwoEigth.Purchase("Michael Yankura");
            SixOneFiveBroad.Purchase("Billy Mays");
            NineOneTwoSecond.Purchase("Ken M");

            // List<Building> structures = new List<Building>()
            // {
            //     FiveOneTwoEigth, SixOneFiveBroad, NineOneTwoSecond
            // };

           List<Building> structures = new List<Building>() {
               FiveOneTwoEigth, SixOneFiveBroad, NineOneTwoSecond
           };

            foreach (Building building in structures)
            {
                building.DisplayDetails();
            };
        }
    }
}
