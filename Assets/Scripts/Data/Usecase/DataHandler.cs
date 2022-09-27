using Data.Gateway;
using Domain;

namespace Data.Usecase
{
    public class DataHandler : IDataHandler
    {
        private string cachedData;
        private readonly IProcessor processor;
        private readonly IRepository repository;

        public DataHandler()
        {
            processor = new CalculatorProcessor();
            repository = new PreferenceRepository();
        }
    
        public void UpdateRawData(string input)
        {
            cachedData = input;
            SaveData();
        }

        private void SaveData()
        {
            repository.SaveData(cachedData);
        }

        public string GetRawData()
        {
            if (cachedData == null)
            {
                cachedData = repository.ReadData();
            }
            return cachedData;
        }

        public string GetResultData()
        {
            return processor.ProcessData(cachedData);
        }
    }
}
