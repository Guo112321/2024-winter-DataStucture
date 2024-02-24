using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2
{
    public class Lab
    {
        public int LabId { get; set; }
        public int LabScore { get; set; }
        public int LabMaxScore { get; set; }

        public Lab(int LabId,  int LabScore, int LabMaxScore)
        {
            this.LabId = LabId;
            this.LabScore = LabScore;
            this.LabMaxScore = LabMaxScore;
        }
    }

}
