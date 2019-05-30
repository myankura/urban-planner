using System;

namespace Planner
{

    //Define class
    class Building
    {
        //Private Properties
        private string _designer = "Michael Yankura";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        //Public Properties
        public int Stories { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        //CONSTRUCTOR
        public Building(string address, int stories, int width, int depth)
        {
            _address = address;
            Stories = stories;
            Width = width;
            Depth = depth;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public DateTime Constructed()
        {
            return _dateConstructed;
        }
        public void Purchase(string owner)
        {
            _owner = owner;
        }

        public void DisplayDetails()
        {
            Console.WriteLine(_address);
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
            Console.WriteLine("======================================");
        }
    }
}