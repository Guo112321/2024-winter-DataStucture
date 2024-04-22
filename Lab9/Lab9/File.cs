using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class File : IFileSystemComponent
    {
        private string _name;
        private long _size;

        public File(string name, long size)
        {
            _name = name;
            _size = size;
        }

        public void Add(IFileSystemComponent component)
        {
            throw new NotImplementedException("Cann't add to file.");
        }

        public void Display(int depth)
        {
            Console.WriteLine($"-{depth} File: {_name} Size: {_size}");
        }

        public void Remove(IFileSystemComponent component)
        {
            throw new NotImplementedException("Can't remove from file.");
        }
    }
}
