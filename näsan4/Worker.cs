class Worker
{
    private string name;
    private int age;
    private int wage = 0;

    public Worker(string word, int number)
    {
        name = word;
        age = number;
    }

    public void SetWage(int num)
    {
        wage = num;
    }
    public string GetName()
    {
        return name;
    }
    public int GetAge()
    {
        return age;
    }
    public int GetWage()
    {
        return wage;
    }
}