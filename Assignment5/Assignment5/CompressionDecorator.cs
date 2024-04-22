using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class CompressionDecorator : FileComponent
    {
        private FileComponent wrappedComponnent;
        public CompressionDecorator(FileComponent wrappedComponnent)
        {
            this.wrappedComponnent = wrappedComponnent;
        }

        public override void Display()
        {
            wrappedComponnent.Display();
            Console.WriteLine("The file is compressed.");
        }
    }
}
