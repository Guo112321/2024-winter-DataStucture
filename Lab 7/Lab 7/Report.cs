using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public class Report : Document
    {
        public override Page CreatePage()
        {
            return new SkillsPage();
        }
    }
}
