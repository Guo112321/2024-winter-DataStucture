using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public interface StorageProvider
    {
        void Save(string data);
        string Load();
    }
}
