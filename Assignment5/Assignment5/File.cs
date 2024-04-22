using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class File : FileComponent
    {
        private string name;
        private StorageProvider storageProvider;

        public File(string name, StorageProvider storageProvider)
        {
            this.name = name;
            this.storageProvider = storageProvider;
        }

        public override void Display()
        {
            Console.WriteLine($"File: {name}");
        }

        public void SaveData(string data)
        {
            storageProvider.Save(data);
        }

        public string LoadData()
        {
            return storageProvider.Load();
        }
    }
}
