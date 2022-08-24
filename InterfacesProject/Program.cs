//create objects of your 3 classes . Display and organize their values.

using InterfacesProject;

var myZoo = new Zoo();
var myRescue = new Rescue();
var myGreenhouse = new PartyVenue();

var myBusinesses = new List<IBusiness>() { myZoo, myRescue, myGreenhouse };

Console.WriteLine($"My Businesses:");
foreach (var business in myBusinesses)
{
    Console.WriteLine($"Business Name- {business.BusinessName} Location- {business.Location}");
    business.Operations();
    business.Rules();
    Console.WriteLine();
}