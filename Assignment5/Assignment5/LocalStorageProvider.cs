using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class LocalStorageProvider : StorageProvider
    {
        public void Save(string data)
        {
            Console.WriteLine("Saving data to local storage");
        }
        public string Load()
        {
            return "Data loaded from local storage.";
        }
    }
}
