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

namespace Ass2
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        Queue<Test> TestList = new Queue<Test>();
        Stack<Lab> LabList = new Stack<Lab>();

        public void AddNewTest()
        {
            bool testExists = false;
            int id;
            int score;
            int max;

            if (!(
                int.TryParse(txtId.Text, out id) &&
                int.TryParse(txtScoreObtained.Text, out score) &&
                int.TryParse(txtMaxScore.Text, out max)
                ))
            {
                MessageBox.Show("Formatting error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Test test = new Test(id, score, max);

            if(TestList != null )
            {
                foreach (var existingTest in TestList)
                {
                    if (existingTest.Id == id)
                    {
                        testExists = true;
                        break;
                    }
                }
            }

            if (!testExists)
            {
                TestList.Enqueue(test);
            }
            else
            {
                MessageBox.Show("same ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddNewLab()
        {
            bool labExists = false;
            int id;
            int score;
            int max;

            if (!(
                int.TryParse(txtId.Text, out id) &&
                int.TryParse(txtScoreObtained.Text, out score) &&
                int.TryParse(txtMaxScore.Text, out max)
                ))
            {
                MessageBox.Show("Formatting error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Lab lab = new Lab(id, score, max);

            if(LabList != null)
            {
                foreach (var existingLab in LabList)
                {
                    if (existingLab.LabId == id)
                    {
                        labExists = true;
                        break;
                    }
                }
            }

            if (!labExists)
            {
                LabList.Push(lab);
            }
            else
            {
                MessageBox.Show("same ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateTestScore()
        {
            int id;
            int score;
            int max;

            if (!(
                int.TryParse(txtId.Text, out id) &&
                int.TryParse(txtScoreObtained.Text, out score) &&
                int.TryParse(txtMaxScore.Text, out max)
                ))
            {
                MessageBox.Show("Formatting error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Test testToUpdate = null;

            if(LabList != null)
            {
                foreach (var test in TestList)
                {
                    if (test.Id == id)
                    {
                        testToUpdate = test;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (testToUpdate != null)
            {
                testToUpdate.ScoreObtained = score;
                testToUpdate.ScoreMax = max;
            }
            else
            {
                MessageBox.Show("ID invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        public void RemoveTestById()
        {
            int id;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Test testToRemove = TestList.FirstOrDefault(test => test.Id == id);

            if (testToRemove != null)
            {
                TestList = new Queue<Test>(TestList.Where(test => test.Id != id));
                MessageBox.Show("Test removed successfully.");
            }
            else
            {
                MessageBox.Show("Test not found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void PresentAllLabInformation()
        {
            if (LabList.Count > 0)
            {
                StringBuilder message = new StringBuilder("Lab Information:\n");

                foreach (var lab in LabList)
                {
                    message.AppendLine($"Lab ID: {lab.LabId}, Score Obtained: {lab.LabScore}, Max Score: {lab.LabMaxScore}");
                }

                InformationLabel.Text = message.ToString();
            }
            else
            {
                InformationLabel.Text = "No labs available.";
            }
        }

        public void Submit()
        {
            string studentName = txtStudentName.Text;

            if (form1.Studentlist.Any(student => student.Name == studentName))
            {
                MessageBox.Show("This student has already been created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student student = new Student(studentName, TestList, LabList);

            form1.AddStudentInLinkedList(student);
            form1.InitializeStudentListBox();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rdbAddtest.Checked)
            {
                AddNewTest();
            }
            else if(rdbAddLab.Checked)
            {
                AddNewLab();
            }
            else if (rdbEdit.Checked)
            {
                UpdateTestScore();
            }
            else if (rdbRemove.Checked)
            {
                RemoveTestById();
            }
            else if (rdbPresent.Checked)
            {
                PresentAllLabInformation();
            }
            else if (rdbSubmit.Checked)
            {
                Submit();
            }
        }
    }
}
