using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class EncryptionDecorator : FileComponent
    {
        private FileComponent wrappedComponent;
        public EncryptionDecorator(FileComponent wrappedComponent)
        {
            this.wrappedComponent = wrappedComponent;
        }

        public override void Display()
        {
            wrappedComponent.Display();
            Console.WriteLine("The file is encrypted.");
        }
    }
}
