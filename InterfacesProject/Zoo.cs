using System;
namespace InterfacesProject
{
    public class Zoo : IBusiness
    {
        public Zoo() //constructor for zoo class
        {
        }
        //properties specific to Zoo
        public int HorseCount { get; set; } = 5;

        public int ChickenCount { get; set; } = 6;

        //members of interface we want to use need implementation below
        public string BusinessName { get; set; } = "Horses And More";
        public string Location { get; set; } = "Washington";

        public void Operations()
        {
            Console.WriteLine($"This business is open to the public from 10-3.");
        }
        
        public void Rules()
        {
            Console.WriteLine($"No rules.");
        }
    }
}

