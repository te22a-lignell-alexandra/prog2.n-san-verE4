class Book
{
    private string name;
    private int pages;
    private int currentPage = 0;
    public Book(string n, int p)
    {
        name = n;
        pages = p;
    }
    public string GetName()
    {
        return name;
    }
    public int GetPages()
    {
        return pages;
    }
    public void TurnPage()
    {
        currentPage++;
    }
    public int GetCurrentPage()
    {
        return currentPage;
    }
}