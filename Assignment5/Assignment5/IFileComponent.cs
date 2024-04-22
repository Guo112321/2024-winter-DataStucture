using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public interface IFileComponent
    {
        void Display();
        void Add(IFileComponent component);
        void Remove(IFileComponent component);
        IFileComponent GetChild(int index);
    }
}
