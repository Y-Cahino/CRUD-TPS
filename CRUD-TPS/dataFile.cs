using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_TPS
{
    public class FileData
    {
        private string dataFile;
        private dynamic data;
        public FileData(string dataFile)
        {
            this.dataFile = dataFile;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string json = File.ReadAllText(dataFile);
                data = JsonConvert.DeserializeObject<dynamic>(json);
            }
            catch (FileNotFoundException)
            {
                data = new
                {
                    Users = new Dictionary<string, dynamic>
                {
                    { "user1", new { Password = "password1" } }
                }
                };
            }
        }
        public void SavePDF(string orderId)
        {
            Console.WriteLine($"PDF for order {orderId} saved");
            // Implementation for saving PDF
            SaveData();
        }
        private void SaveData()
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(dataFile, json);
        }
    }
}
