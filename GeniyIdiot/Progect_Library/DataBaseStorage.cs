using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Progect_Library
{
    public class DataStorageJson<T>
    {
        private string filePathToSaveData;
        public DataStorageJson(string pathfile)
        {
            filePathToSaveData = pathfile;
        }

        public List<T> ReadAllFromStorage()
        {
            if (File.Exists(filePathToSaveData) == false)
            {
                var file = File.Create(filePathToSaveData);
                file.Close();
            }

            string date = File.ReadAllText(filePathToSaveData);
            List<T> data = JsonConvert.DeserializeObject<List<T>>(date);
            return data ?? new List<T>();

        }
        public void SaveItemToStorage(T newData)
        {

            List<T> dataFromStorage = ReadAllFromStorage();
            dataFromStorage.Add(newData);
            string serializedData = JsonConvert.SerializeObject(dataFromStorage, Formatting.Indented);
            File.WriteAllText(filePathToSaveData, serializedData);

        }

        public void RemovefromStorage(int numberDataToDelete) 
        {
            List<T> dataFromStorage = ReadAllFromStorage();
            dataFromStorage.Remove(dataFromStorage[numberDataToDelete]);
            string serializedData = JsonConvert.SerializeObject(dataFromStorage, Formatting.Indented);
            File.WriteAllText(filePathToSaveData, serializedData);
        }

        
       







    }

}
