class Hardware
{
    private string name;
    private int price;
    public Hardware(string word, int money)
    {
        name = word;
        price = money;
    }
    public string GetName()
    {
        return name;
    }
    public int GetPrice()
    {
        return price;
    }
}