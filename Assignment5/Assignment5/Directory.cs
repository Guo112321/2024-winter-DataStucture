using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Directory : FileComponent
    {
        private List<IFileComponent> children = new List<IFileComponent>();
        private string name;

        public Directory(string name)
        {
            this.name = name;
        }

        public override  void Display()
        {
            Console.WriteLine($"Directory: {name}");
            foreach (IFileComponent child in children)
            {
                child.Display();
            }
        }

        public override void Add(IFileComponent fileComponent)
        {
            children.Add(fileComponent);
        }

        public override void Remove(IFileComponent component)
        {
            children.Remove(component);
        }

        public override IFileComponent GetChild(int index)
        {
            return children[index];
        }
    }
}
