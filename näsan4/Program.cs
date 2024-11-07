List<Rock> Rocks = new();

System.Console.WriteLine("How many rocks?");
string ans = Console.ReadLine();
int number = 0;
bool valid = int.TryParse(ans, out number);

while (valid == false)
{
    System.Console.WriteLine("no");
    ans = Console.ReadLine();
    valid = int.TryParse(ans, out number);
}

for (int i = 0; i < number; i++)
{
    string weight = Console.ReadLine();
    int weightnumber = 0;
    valid = int.TryParse(ans, out number);

    while (valid == false)
    {
        System.Console.WriteLine("no");
        ans = Console.ReadLine();
        valid = int.TryParse(ans, out number);
    }
    Rock rock = new(weightnumber);
    Rocks.Add(rock);
}

foreach (Rock rock in Rocks)
{
    System.Console.WriteLine(rock.GetWeight());
}
Console.ReadLine();