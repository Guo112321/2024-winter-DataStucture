using Microsoft.VisualBasic.Devices;

namespace Ass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Course[] CourseList = new Course[25];

        public int courseIndex = 0;

        Label labelShow = new Label
        {
            Location = new Point(300, 170),
            AutoEllipsis = true,
            AutoSize = false,
            Width = 200,
            Height = 300
        };


        public void addCourseList(Course course)
        {
            CourseList[courseIndex] = course;
            courseIndex++;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           if (courseIndex == 25) 
            {
                MessageBox.Show("Error", "Cannot Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void buttonSearchConfirm_Click(object sender, EventArgs e)
        {
            string courseSearch = txtSearch.Text;
            if (courseSearch.Equals(""))
            {
                MessageBox.Show("Error", "Enter CourseId or name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool found = false;

            foreach (var course in CourseList)
            {
                if (course != null)
                {
                    if (course.CourseId.ToString() == courseSearch ||
                        course.CourseTitle.Equals(courseSearch, StringComparison.OrdinalIgnoreCase))
                    {
                        this.Controls.Add(labelShow);
                        labelShow.Text = course.ToString();
                        found = true;
                        break;
                    }

                    

                }
                
            }
            if (!found)
            {

                MessageBox.Show("Error", "Cannot Find", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
