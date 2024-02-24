namespace Ass2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeStudentListBox();
        }

        public LinkedList<Student> Studentlist = new LinkedList<Student>();

        public void InitializeStudentListBox()
        {
            StudentListBox.Items.Clear();
            String studentInfo;
            if (Studentlist.Count > 0)
            {
                foreach (var student in Studentlist)
                {
                    studentInfo = student.ToString();
                    StudentListBox.Items.Add(studentInfo);
                }
            }
        }

        public void AddStudentInLinkedList(Student student)
        {
            if (Studentlist.Count > 0)
            {
                var Node = Studentlist.First;

                while (Node != null && StringComparer.OrdinalIgnoreCase.Compare(Node.Value.Name, student.Name) <= 0)
                {
                    Node = Node.Next;
                }

                if (Node == null)
                {
                    Studentlist.AddLast(student);
                }
                else
                {
                    Studentlist.AddBefore(Node, student);
                    return;
                }

            }
            else { Studentlist.AddFirst(student); }
        }

        public void DeleteSelectedStudent(Student student)
        {
            var node = Studentlist.Find(student);

            if (node != null)
            {
                Studentlist.Remove(node);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = StudentListBox.SelectedIndex;
            Student studentSelected = Studentlist.ElementAt(selectedIndex);
            DeleteSelectedStudent(studentSelected);
            InitializeStudentListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();


        }
    }
}
