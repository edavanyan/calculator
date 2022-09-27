
namespace Data.Usecase
{
    public interface IDataHandler
    {
        void UpdateRawData(string input);
        string GetRawData();
        string GetResultData();
    }
}
