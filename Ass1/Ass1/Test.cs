using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    public class Test
    {
        public int TestId { get; set; }
        public double ScoreSecured { get; set; }
        public double MaxScore { get; set; }

        public Test(int testId, double scoreSecured, double maxScore)
        {
            TestId = testId;
            ScoreSecured = scoreSecured;
            MaxScore = maxScore;
        }

        public override string ToString()
        {
            return $"Test ID: {TestId}, Score Obtained: {ScoreSecured}, Maximum Score: {MaxScore}";
        }
    }
}
