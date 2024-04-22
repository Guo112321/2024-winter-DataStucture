namespace ProjectDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplicationDB.InitializeRooms();
            dataGridView1.Columns[3].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            initialiseDataGridView();
        }

        public void initialiseDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (IRoom r in ApplicationDB.roomsDatabase.Values)
            {
                List<string> details = ApplicationDB.GetRoomDetails(r);
                dataGridView1.Rows.Add(details.ToArray());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string roomNum = dataGridView1.Rows[index].Cells[0].Value.ToString();
            IRoom room = ApplicationDB.GetRoom(roomNum);
            bool isbooked = room.IsBooked;

            if (isbooked)
            {
                btnBook.Enabled = false;
                btnRelease.Enabled = true;
            }
            else
            {
                btnBook.Enabled = true;
                btnRelease.Enabled = false;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            bool breakfast = ckbBreakfast.Checked;
            bool parking = ckbParking.Checked;

            int index = dataGridView1.CurrentRow.Index;
            string roomNum = dataGridView1.Rows[index].Cells[0].Value.ToString();
            ApplicationDB.BookRoom(roomNum, breakfast, parking);
            initialiseDataGridView();
            dataGridView1.ClearSelection();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string roomNum = dataGridView1.Rows[index].Cells[0].Value.ToString();
            ApplicationDB.ReleaseRoom(roomNum);
            initialiseDataGridView();
            dataGridView1.ClearSelection();
        }
    }
}
