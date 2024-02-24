using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2
{
    public class Student
    {
        public string Name { get; set; }
        public Queue<Test> TestList { get; set; }
        public Stack<Lab> LabList { get; set; }

        public Student(string name, Queue<Test> testList, Stack<Lab> labList)
        {
            Name = name;
            TestList = testList;
            LabList = labList;
        }

        public int totalTestScoreObtained
        {
            get { return CalculateTotalTestScoreObtained(); }
        }

        public int totalTestScoreMax
        {
            get { return CalculateTotalTestScoreMax(); }
        }

        public int totalLabScoreObtained
        {
            get { return CalculateTotalLabScoreObtained(); }
        }

        public int totalLabScoreMax
        {
            get { return CalculateTotalLabScoreMax(); }
        }

        private int CalculateTotalTestScoreObtained()
        {
            return TestList.Sum(test => test.ScoreObtained);
        }

        private int CalculateTotalTestScoreMax()
        {
            return TestList.Sum(test => test.ScoreMax);
        }

        private int CalculateTotalLabScoreObtained()
        {
            return LabList.Sum(lab => lab.LabScore);
        }

        private int CalculateTotalLabScoreMax()
        {
            return LabList.Sum(lab => lab.LabMaxScore);
        }

        public override string ToString()
        {
            return $"Student Name: {Name}  Test: {totalTestScoreObtained}/{totalTestScoreMax}  Lab: {totalLabScoreObtained}/{totalLabScoreMax}";
        }
    }

}
