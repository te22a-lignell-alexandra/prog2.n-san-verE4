class GPU : Hardware
{
    private int fps;
    public GPU(string word, int money, int number) : base(word, money) 
    {
        fps = number;
    }
    public int GetFps()
    {
        return fps;
    }

}