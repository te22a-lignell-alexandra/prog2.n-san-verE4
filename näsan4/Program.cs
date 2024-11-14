using System.Runtime.InteropServices;

List<Rock> Rocks = new();

// Worker man = new("Steve", 56);
// BlueCollar guy = new("Fred", 60);
// WhiteCollar dude = new("Dan", 34);

// System.Console.WriteLine(man.GetName());
// System.Console.WriteLine(guy.GetAge());
// dude.SetWage(500000000);
// System.Console.WriteLine(dude.GetWage());

bool valid; //rocks?
int number = 0;
do 
{
    System.Console.WriteLine("rocks?");
    string ans = Console.ReadLine();
    valid = int.TryParse(ans, out number);
} while (valid == false);

for (int i = 0; i < number; i++)
{
    int weightnumber = 0;
    do 
    {
        System.Console.WriteLine("weigh how much?");
        string weight = Console.ReadLine();
        valid = int.TryParse(weight, out weightnumber);
        
    } while  (valid == false);

    Rock rock = new(weightnumber);
    Rocks.Add(rock);
}

foreach (Rock rock in Rocks)
{
    System.Console.WriteLine(rock.GetWeight());
}
Console.ReadLine();