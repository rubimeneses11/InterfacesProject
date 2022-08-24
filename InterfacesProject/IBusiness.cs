using System;
namespace InterfacesProject
{
    public interface IBusiness
    {
        //properties specific to this interface
        public string BusinessName { get; set; }

        public string Location { get; set; }

        //methods specific to this interface
        public void Operations();

        public void Rules();
    }
}

