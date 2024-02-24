using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ass1
{
    public partial class Form2 : Form
    {
        
        private Form1 form1; 

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1; 
        }

        //create a list to store Test object
        List<Test> TestList = new List<Test>();
        

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

        //if score obtained is higher than max score, there will be error
        private bool CheckScoreValid(double scoreObtained, double maxScore)
        {
            if (scoreObtained <= maxScore)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


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

            int textControlLocation = 170;

            foreach (var Test in TestList)
            {
                TextControl currentTextControl = new();

                currentTextControl.label1 = new Label();
                currentTextControl.label1.Text = $"Test ID: {Test.TestId}";
                currentTextControl.label1.Location = new System.Drawing.Point(57, textControlLocation);
                currentTextControl.label1.Size = new System.Drawing.Size(90, 20);
                Controls.Add(currentTextControl.label1);

                currentTextControl.label2 = new Label();
                currentTextControl.label2.Text = "Score Obtained:";
                currentTextControl.label2.Location = new System.Drawing.Point(245, textControlLocation);
                currentTextControl.label2.Size = new System.Drawing.Size(127, 20);
                Controls.Add(currentTextControl.label2);

                currentTextControl.textBox2 = new TextBox();
                currentTextControl.textBox2.Text = $"{Test.ScoreSecured}";
                currentTextControl.textBox2.Location = new System.Drawing.Point(374, textControlLocation);
                currentTextControl.textBox2.Size = new System.Drawing.Size(71, 27);
                Controls.Add(currentTextControl.textBox2);

                currentTextControl.label3 = new Label();
                currentTextControl.label3.Text = "Max Score:";
                currentTextControl.label3.Location = new System.Drawing.Point(488, textControlLocation);
                currentTextControl.label3.Size = new System.Drawing.Size(90, 20);
                Controls.Add(currentTextControl.label3);

                currentTextControl.textBox3 = new TextBox();
                currentTextControl.textBox3.Text = $"{Test.MaxScore}";
                currentTextControl.textBox3.Location = new System.Drawing.Point(580, textControlLocation);
                currentTextControl.textBox3.Size = new System.Drawing.Size(71, 27);
                Controls.Add(currentTextControl.textBox3);

                TextControls.Add(currentTextControl);

                textControlLocation += 40;

                sumScore += Test.ScoreSecured;

            }

            txtAveScore.Text = $"Average Score: {sumScore / TestList.Count:F2}";
        }

        private void UpdateTestListFromTextBoxes()
        {
            foreach (var control in TextControls)
            {
                int testId = int.Parse(control.label1.Text.Split(':')[1].Trim());

                // Find the corresponding Test object in TestList
                Test currentTest = TestList.Find(t => t.TestId == testId);

                if (currentTest != null)
                {
                    // Update scoreObtained and maxScore from TextBoxes
                    currentTest.ScoreSecured = double.Parse(control.textBox2.Text);
                    currentTest.MaxScore = double.Parse(control.textBox3.Text);
                }
            }
        }

        private void DeleteTestById(int testId)
        {
            Test testToDelete = TestList.Find(t => t.TestId == testId);

            if (testToDelete != null)
            {
                // Remove the test from the TestList
                TestList.Remove(testToDelete);
            }
        }



        private void buttonAddTest_Click(object sender, EventArgs e)
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
                MessageBox.Show("Error", "Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Test test1 = new Test(testID, scoreObtained, maxScore);

            if (!CheckScoreValid(scoreObtained, maxScore))
            {
                MessageBox.Show("Error", "Score Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                    if (test1.TestId < (TestList[i]).TestId)
                    {
                        TestList.Insert(i, test1);
                        insertSucceed = true;
                        break;
                    }
                    else if (test1.TestId == (TestList[i]).TestId)
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateTestListFromTextBoxes();
            RefreshList();
        }

        private void buttonConfirmDelete_Click(object sender, EventArgs e)
        {
            int deleteId = int.Parse(txtDeleteTest.Text);
            DeleteTestById(deleteId);
            RefreshList();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(TestList.Count == 0)
            {
                MessageBox.Show("Error", "Sumbit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            else
            {
                if(string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtCourseName.Text))
                {
                    MessageBox.Show("Error", "Course Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Course course = new(int.Parse(txtId.Text), txtCourseName.Text, TestList);
                form1.addCourseList(course);
                Close();

            }
        }
    }
}
