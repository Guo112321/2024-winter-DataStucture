using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public abstract class FileComponent : IFileComponent
    {
        public abstract void Display();
        public virtual void Add(IFileComponent fileComponent)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(IFileComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual IFileComponent GetChild(int index)
        {
            throw new NotImplementedException();
        }
    }
}
