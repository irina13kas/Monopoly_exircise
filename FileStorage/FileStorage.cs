using FileStorageContext;
using Newtonsoft.Json;

namespace FileStorageContext
{
    public class FileStorage
    {
        public readonly ICollection<Pallet> palletsData=DataGeneration.GeneratePallets();
        private const string filePath= "DbContext/pallets.json";

        public FileStorage()
        {
            WriteToFile();
            palletsData=JsonConvert.DeserializeObject<ICollection<Pallet>>(File.ReadAllText(filePath)) ?? new List<Pallet>();
        }

        public void WriteToFile()
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(palletsData));
        }       
    }
}