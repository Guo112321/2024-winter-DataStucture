using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2
{
    public class Test
    {
        public int Id { get; set; }
        public int ScoreObtained { get; set; }
        public int ScoreMax { get; set; }

        public Test(int id, int scoreObtained, int scoreMax)
        {
            Id = id;
            ScoreObtained = scoreObtained;
            ScoreMax = scoreMax;
        }
    }
}
