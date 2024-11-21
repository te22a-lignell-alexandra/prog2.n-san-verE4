using System.Runtime.InteropServices;

// List<Rock> Rocks = new();

// // Worker man = new("Steve", 56);
// // BlueCollar guy = new("Fred", 60);
// // WhiteCollar dude = new("Dan", 34);

// // System.Console.WriteLine(man.GetName());
// // System.Console.WriteLine(guy.GetAge());
// // dude.SetWage(500000000);
// // System.Console.WriteLine(dude.GetWage());

// bool valid; //rocks?
// int number = 0;
// do 
// {
//     System.Console.WriteLine("rocks?");
//     string ans = Console.ReadLine();
//     valid = int.TryParse(ans, out number);
// } while (valid == false);

// for (int i = 0; i < number; i++)
// {
//     int weightnumber = 0;
//     do 
//     {
//         System.Console.WriteLine("weigh how much?");
//         string weight = Console.ReadLine();
//         valid = int.TryParse(weight, out weightnumber);
        
//     } while  (valid == false);

//     Rock rock = new(weightnumber);
//     Rocks.Add(rock);
// }

// foreach (Rock rock in Rocks)
// {
//     System.Console.WriteLine(rock.GetWeight());
// }
// Console.ReadLine();

List<Hardware> hardwares = new();

System.Console.WriteLine("hardware? which one?");
bool yes = false;
int numAns = 0;
do
{
    System.Console.WriteLine("1. HDD, 2. CPU, 3. GPU");
    string ans = Console.ReadLine();
    yes = int.TryParse(ans, out numAns);
} while (!yes || numAns > 3 || numAns < 1);

if (numAns == 1) MakeAThing("HDD");
if (numAns == 2) MakeAThing("CPU");
if (numAns == 3) MakeAThing("GPU");


System.Console.WriteLine("\n" + hardwares[0].GetName() + "\t" + hardwares[0]);


Console.ReadLine();


// metoder

void MakeAThing(string hardware)
{
    System.Console.WriteLine("Name?");
    string name = Console.ReadLine();

    int price = 0;
    bool good = false;
    do
    {
        System.Console.WriteLine("Price?");
        string sPrice = Console.ReadLine();
        good = int.TryParse(sPrice, out price);
    } while (!good);

    int other = 0;
    if (hardware == "HDD") System.Console.WriteLine("Max storage?");
    else if (hardware == "CPU") System.Console.WriteLine("Cores?");
    else if (hardware == "GPU") System.Console.WriteLine("Fps?");
    good = false;
    do
    {
        string thing = Console.ReadLine();
        good = int.TryParse(thing, out other);
    } while (!good);

    if (hardware == "HDD")
    {
        HDD hdd = new(name, price, other);
        hardwares.Add(hdd);
    }
    else if (hardware == "CPU")
    {
        CPU cpu = new(name, price, other);
        hardwares.Add(cpu);
    }
    else if (hardware == "GPU")
    {
        GPU gpu = new(name, price, other);
        hardwares.Add(gpu);
    }
}