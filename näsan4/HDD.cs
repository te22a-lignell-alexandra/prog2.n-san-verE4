using System.Dynamic;

class HDD : Hardware
{
    private int storageMax;
    private int storageUsed;
    public HDD(string word, int money, int storageM, int storageU) : base(word, money) 
    {
        storageMax = storageM;
        storageUsed = storageU;
    }
    public int GetStorageMax()
    {
        return storageMax;
    }
    public int GetStorageUsed()
    {
        return storageUsed;
    }
}