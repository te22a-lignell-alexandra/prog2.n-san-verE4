class CPU : Hardware
{
    private int cores;
    public CPU(string word, int money, int number) : base(word, money) 
    {
        cores = number;
    }
    public int GetCores()
    {
        return cores;
    }
    
}