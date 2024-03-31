using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public abstract class Document
    {
        public abstract Page CreatePage();

        public void DisplayPage()
        {
            Page page = CreatePage();
            page.Display();
        }
    }
}
