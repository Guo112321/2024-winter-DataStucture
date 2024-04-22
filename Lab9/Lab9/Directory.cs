using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Directory : IFileSystemComponent
    {
        private string _name;
        private List<IFileSystemComponent> _components = new List<IFileSystemComponent>();

        public Directory(string name)
        {
            _name = name;
        }

        public void Add(IFileSystemComponent component)
        {
            _components.Add(component);
        }

        public void Display(int depth)
        {
            Console.WriteLine($"-{depth} Directory: {_name}");
            foreach (IFileSystemComponent component in _components)
            {
                component.Display(depth + 2);
            }
        }

        public void Remove(IFileSystemComponent component)
        {
            _components.Remove(component);
        }
    }
}
