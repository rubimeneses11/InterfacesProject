using System;
namespace InterfacesProject
{
    public class PartyVenue : IBusiness
    {
        public PartyVenue() //constructor
        {
        }
        //properties specific to Party Venue
        public int GuestCount { get; set; } = 200;

        public string ClosingTime { get; set; } = "midnight";

        //needs implementation for these members of the interface we are using
        public string BusinessName { get; set; } = "Greenhouse Magic";
        public string Location { get; set; } = "Washington";

        public void Operations()
        {
            Console.WriteLine($"This business operates by reservation only.");
        }

        public void Purpose()
        {
            Console.WriteLine($"The purpose is to share the beauty of the greenhouse.");
        }

        public void Rules()
        {
            Console.WriteLine($"Gues Count: {GuestCount}");
            Console.WriteLine($"Closing Time: {ClosingTime}");
        }
    }
}

