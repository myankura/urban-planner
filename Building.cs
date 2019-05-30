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
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        //CONSTRUCTOR
        public Building(string address)
        {
            _address = address;
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