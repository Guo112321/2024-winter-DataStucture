using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public interface IFileSystemComponent
    {
        void Add(IFileSystemComponent component);
        void Remove(IFileSystemComponent component);
        void Display(int depth);
    }
}
