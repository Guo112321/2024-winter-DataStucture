using System.Collections;
using static lab1.Form1;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class test
        {
            public int testId;
            public double scoreObtained;
            public double maxScore;

            //create a Test class to store test information
            public test(int testId, double scoreObtained, double maxScore)
            {
                this.testId = testId;
                this.scoreObtained = scoreObtained;
                this.maxScore = maxScore;
            }


        }

        //create a list to store Test object
        List<test> TestList = new List<test>();

        //create a class to store the text control(label, textbox)
        public class TextControl
        {
            public Label label1;
            public Label label2;
            public Label label3;
            public TextBox textBox2;
            public TextBox textBox3;
        }

        //create a list to store textControl
        List<TextControl> TextControls = new List<TextControl>();


        //create a function to reflesh display of test score

        private void RefreshList()
        {
            double sumScore = 0;
            foreach (var control in TextControls)
            {
                Controls.Remove(control.label1);
                Controls.Remove(control.label2);
                Controls.Remove(control.label3);
                Controls.Remove(control.textBox2);
                Controls.Remove(control.textBox3);
            }

            int textControlLocation = 150;

            foreach (var test in TestList)
            {
                TextControl currentTextControl = new TextControl();

                currentTextControl.label1 = new Label();
                currentTextControl.label1.Text = $"Test ID: {test.testId}";
                currentTextControl.label1.Location = new System.Drawing.Point(57, textControlLocation);
                currentTextControl.label1.Size = new System.Drawing.Size(90, 20);
                Controls.Add(currentTextControl.label1);

                currentTextControl.label2 = new Label();
                currentTextControl.label2.Text = "Score Obtained:";
                currentTextControl.label2.Location = new System.Drawing.Point(245, textControlLocation);
                currentTextControl.label2.Size = new System.Drawing.Size(127, 20);
                Controls.Add(currentTextControl.label2);

                currentTextControl.textBox2 = new TextBox();
                currentTextControl.textBox2.Text = $"{test.scoreObtained}";
                currentTextControl.textBox2.Location = new System.Drawing.Point(374, textControlLocation);
                currentTextControl.textBox2.Size = new System.Drawing.Size(71, 27);
                Controls.Add(currentTextControl.textBox2);

                currentTextControl.label3 = new Label();
                currentTextControl.label3.Text = "Max Score:";
                currentTextControl.label3.Location = new System.Drawing.Point(488, textControlLocation);
                currentTextControl.label3.Size = new System.Drawing.Size(90, 20);
                Controls.Add(currentTextControl.label3);

                currentTextControl.textBox3 = new TextBox();
                currentTextControl.textBox3.Text = $"{test.maxScore}";
                currentTextControl.textBox3.Location = new System.Drawing.Point(580, textControlLocation);
                currentTextControl.textBox3.Size = new System.Drawing.Size(71, 27);
                Controls.Add(currentTextControl.textBox3);

                TextControls.Add(currentTextControl);

                textControlLocation += 40;

                sumScore += test.scoreObtained;

            }

            txtAveScore.Text = $"Average Score: {sumScore / TestList.Count:F2}";
        }

        private void UpdateTestListFromTextBoxes()
        {
            foreach (var control in TextControls)
            {
                int testId = int.Parse(control.label1.Text.Split(':')[1].Trim());

                // Find the corresponding Test object in TestList
                test currentTest = TestList.Find(t => t.testId == testId);

                if (currentTest != null)
                {
                    // Update scoreObtained and maxScore from TextBoxes
                    currentTest.scoreObtained = double.Parse(control.textBox2.Text);
                    currentTest.maxScore = double.Parse(control.textBox3.Text);
                }
            }
        }

        private void DeleteTestById(int testId)
        {
            test testToDelete = TestList.Find(t => t.testId == testId);

            if (testToDelete != null)
            {
                // Remove the test from the TestList
                TestList.Remove(testToDelete);
            }
        }



        //create a function to add new test when click button1
        private void button1_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txtTestId.Text) ||
                string.IsNullOrEmpty(txtScoreObtained.Text) ||
                string.IsNullOrEmpty(txtMaxScore.Text) ||
                !int.TryParse(txtTestId.Text, out int testID) ||
                !double.TryParse(txtScoreObtained.Text, out double scoreObtained) ||
                !double.TryParse(txtMaxScore.Text, out double maxScore)
                )
            {
                return;
            }

            
            test test1 = new test(testID, scoreObtained, maxScore);

            //find right place to insert
            if (TestList.Count == 0)
            {
                TestList.Add(test1);
            }
            else if (TestList.Count != 0)
            {
                bool insertSucceed = false;
                for (int i = 0; i < TestList.Count; i++)
                {
                    if (test1.testId < (TestList[i]).testId)
                    {
                        TestList.Insert(i, test1);
                        insertSucceed = true;
                        break;
                    }
                    else if (test1.testId == (TestList[i]).testId)
                    {
                        TestList[i] = test1;
                        insertSucceed = true;
                        break;
                    }
                }
                if (!insertSucceed)
                {
                    TestList.Insert(TestList.Count, test1);
                }
            }

            RefreshList();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateTestListFromTextBoxes();
            RefreshList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int deleteId = int.Parse(txtDeleteTest.Text);
            DeleteTestById(deleteId);
            RefreshList();
        }
    }
}
