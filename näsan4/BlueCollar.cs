class BlueCollar : Worker
{
    public BlueCollar(string word, int number) : base(word, number){}
    public void Build()
    {
        System.Console.WriteLine("klonk klonk! *hammer noises*");
    }
    public void Repair()
    {
        System.Console.WriteLine("klink klonk. *repair hammer noies*");
    }
    public void Destroy()
    {
        System.Console.WriteLine("smash");
    }
}