using UnityEngine;

namespace Data.Gateway
{
    public class PreferenceRepository : IRepository
    {
    
        public void SaveData(string dataToSave)
        {
            PlayerPrefs.SetString("user_data", dataToSave);
            PlayerPrefs.Save();
        }

        public string ReadData()
        {
            return PlayerPrefs.GetString("user_data");
        }
    }
}
