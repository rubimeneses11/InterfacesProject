using System;
namespace InterfacesProject
{   //rescue conforms to IBusiness
    public class Rescue : IBusiness
    {
        public Rescue() //constructor
        {
        }
        //properties specific to Rescue
        public int NumberOfBreeds { get; set; } = 10;

        public bool DogOnly { get; set; } = true;

        //needs implementation for these methods since we are conforming from IBusiness
        public string BusinessName { get; set; } = "Rubi's Rowdies";
        public string Location { get; set; } = "Alabama";

        public void Operations()
        {
            Console.WriteLine($"This rescue runs 24/7");
        }

        public void Rules()
        {
            Console.WriteLine($"No rules.");
        }
    }
}

