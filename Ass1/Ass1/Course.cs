using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public double TotalScore { get; private set; }
        public double TotalMaxScore { get; private set; }
        public double OverallPercentage { get; private set; }
        public List<Test> AllTests { get; set; }

        public Course(int courseId, string courseTitle, List<Test> allTests)
        {
            CourseId = courseId;
            CourseTitle = courseTitle;
            AllTests = allTests;
             CalculateTotalScoreAndMaxScore();
            CalculateOverallPercentage();
        }

        private void CalculateTotalScoreAndMaxScore()
        {
            double totalScore = 0;
            double totalMaxScore = 0;

            foreach (Test test in AllTests)
            {
                totalScore += test.ScoreSecured;
                totalMaxScore += test.MaxScore;
            }

            TotalScore = totalScore;
            TotalMaxScore = totalMaxScore;
        }

        private void CalculateOverallPercentage()
        {
            if (TotalMaxScore == 0)
            {
                OverallPercentage = 0;
            }

            OverallPercentage = (TotalScore / TotalMaxScore) * 100;
        }

        public override string ToString()
        {
            string testsInfo = string.Join("\n", AllTests.Select(test => test.ToString()));
            return $"Course ID: {CourseId}\nCourse Title: {CourseTitle}\nTotal Score: {TotalScore}\nTotal Max Score: {TotalMaxScore}\nOverall Percentage: {OverallPercentage:F2}";
        }



    }
}
