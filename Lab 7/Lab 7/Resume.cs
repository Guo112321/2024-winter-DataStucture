using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_7
{
    class Resume : Document
    {
        public override Page CreatePage()
        {
            return new EducationPage();
        }
    }
}
