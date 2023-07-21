using FileStorageContex;
using Newtonsoft.Json;

namespace FileStorageContext
{
    public class FileStorage
    {
        public readonly ICollection<Pallet> palletsData=new List<Pallet>();
        private const string filePath= "DbContext/pallets.json";
        private readonly int NumberOfPallets = 20;

        public FileStorage()
        {
            GenerateDataToFile();
            WriteToFile();
            palletsData=JsonConvert.DeserializeObject<ICollection<Pallet>>(File.ReadAllText(filePath)) ?? new List<Pallet>();
        }

        public void WriteToFile()
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(palletsData));
        }
        
        private void GenerateDataToFile()
        {
            for (int i = 0; i < NumberOfPallets; i++)
            {
                Pallet pallet = DataGeneration.GeneratePallet();
                palletsData.Add(pallet);
            }
        }
    }
}