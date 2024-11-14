List<Rock> Rocks = new();

Worker man = new("Steve", 56);

bool valid;
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