namespace Data.Gateway
{
    public interface IRepository
    {
        void SaveData(string dataToSave);
        string ReadData();
    }
}
