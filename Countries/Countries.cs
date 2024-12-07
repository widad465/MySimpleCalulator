List<Country> countries = new List<Country>();

Console.WriteLine($"List capacity {countries.Capacity} List Count {countries.Count}");

countries.Add (new Country("NGA", 234, "Nigeria"));

Console.WriteLine($"List capacity {countries.Capacity} List Count {countries.Count}");

countries.Add(new Country("IND", 91, "India"));

Console.WriteLine($"List capacity {countries.Capacity} List Count {countries.Count}");

countries.Add(new Country("USA", 1, "United State Of America"));

Console.WriteLine($"List capacity {countries.Capacity} List Count {countries.Count}");

countries.Add(new Country("SR", 774, "Srilanka"));

Console.WriteLine($"List capacity {countries.Capacity} List Count {countries.Count}");

countries.Add(new Country("AUS", 61, "Australia"));

Console.WriteLine($"List capacity {countries.Capacity} List Count {countries.Count}");

countries.Add(new Country("JPY", 21, "Japan"));
countries.Add(new Country("TG", 222, "Togo"));
countries.Add(new Country("KN", 212, "Kenya"));
countries.Add(new Country("MRT", 200, "Mauritius"));

Console.WriteLine($"List capacity {countries.Capacity} List Count {countries.Count}");

countries.Add(new Country("SEN", 222, "Senegal"));
countries.Add(new Country("GUY", 212, "Guyana"));
countries.Add(new Country("ARG", 200, "Argentina"));

Console.WriteLine($"List capacity {countries.Capacity} List Count {countries.Count}");

countries.Add(new Country("AFG", 001, "Afghanistan"));
countries.Add(new Country("BRA", 911, "Brazil"));
countries.Add(new Country("CUB", 419, "Cuba"));
countries.Add(new Country("DK", 244, "Denmark"));


Console.WriteLine($"List capacity {countries.Capacity} List Count {countries.Count}");

Console.WriteLine("Total countries {0}", countries.Count);


Console.WriteLine("===Welcome to my Guess Game===");
Console.WriteLine("Enter the secret number");
int userChoice = int.Parse(Console.ReadLine()!);

Random pickRandomly = new();
int secretNUmber = pickRandomly.Next(2, 33);

string result = userChoice != secretNUmber ? "Damn! You guess wrong!" : "You guess right";
Console.WriteLine(result);

Console.WriteLine($"The secret number is : {secretNUmber}");
