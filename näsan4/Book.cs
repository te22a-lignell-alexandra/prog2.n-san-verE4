class Book
{
    private string Name;
    private int Pages;
    private int CurrentPage = 0;
    public Book(string n, int p)
    {
        n = Name;
        p = Pages;
    }
    public string GetName()
    {
        return Name;
    }
    public int GetPages()
    {
        return Pages;
    }
    public void TurnPage()
    {
        CurrentPage++;
    }
    public int GetCurrentPage()
    {
        return CurrentPage;
    }
}