using System.Dynamic;

class HDD : Hardware
{
    private int storageMax;
    public HDD(string word, int money, int storageM) : base(word, money) 
    {
        storageMax = storageM;
    }
    public int GetStorageMax()
    {
        return storageMax;
    }
}