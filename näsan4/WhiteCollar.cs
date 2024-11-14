class WhiteCollar : Worker
{
    public WhiteCollar(string word, int number) : base(word, number){}

    public void DrinkCoffee()
    {
        System.Console.WriteLine("*slurping noises*");
    }
    public void AttendMeeting()
    {
        System.Console.WriteLine("zzzzzzz");
    }
    public void DoSpreadsheets()
    {
        System.Console.WriteLine("taptaptaptap *keyboard noises*");
    }
}