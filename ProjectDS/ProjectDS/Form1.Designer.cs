namespace ProjectDS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            RoomNum = new DataGridViewTextBoxColumn();
            roomType = new DataGridViewTextBoxColumn();
            bedCount = new DataGridViewTextBoxColumn();
            Booked = new DataGridViewTextBoxColumn();
            Breakfast = new DataGridViewTextBoxColumn();
            Parking = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            ckbParking = new CheckBox();
            ckbBreakfast = new CheckBox();
            btnBook = new Button();
            groupBox2 = new GroupBox();
            btnRelease = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(303, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(528, 50);
            label1.TabIndex = 0;
            label1.Text = "Hotel Management System";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RoomNum, roomType, bedCount, Booked, Breakfast, Parking, Cost });
            dataGridView1.Location = new Point(19, 93);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(770, 480);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RoomNum
            // 
            RoomNum.HeaderText = "Room Num";
            RoomNum.MinimumWidth = 6;
            RoomNum.Name = "RoomNum";
            RoomNum.ReadOnly = true;
            RoomNum.Width = 90;
            // 
            // roomType
            // 
            roomType.HeaderText = "Type";
            roomType.MinimumWidth = 6;
            roomType.Name = "roomType";
            roomType.ReadOnly = true;
            roomType.Width = 140;
            // 
            // bedCount
            // 
            bedCount.HeaderText = "Bed Count";
            bedCount.MinimumWidth = 6;
            bedCount.Name = "bedCount";
            bedCount.ReadOnly = true;
            bedCount.Width = 90;
            // 
            // Booked
            // 
            Booked.HeaderText = "Booked";
            Booked.MinimumWidth = 6;
            Booked.Name = "Booked";
            Booked.ReadOnly = true;
            Booked.Width = 90;
            // 
            // Breakfast
            // 
            Breakfast.HeaderText = "Breakfast";
            Breakfast.MinimumWidth = 6;
            Breakfast.Name = "Breakfast";
            Breakfast.ReadOnly = true;
            Breakfast.Width = 90;
            // 
            // Parking
            // 
            Parking.HeaderText = "Parking";
            Parking.MinimumWidth = 6;
            Parking.Name = "Parking";
            Parking.ReadOnly = true;
            Parking.Width = 90;
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            Cost.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckbParking);
            groupBox1.Controls.Add(ckbBreakfast);
            groupBox1.Controls.Add(btnBook);
            groupBox1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            groupBox1.Location = new Point(816, 93);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(238, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book";
            // 
            // ckbParking
            // 
            ckbParking.AutoSize = true;
            ckbParking.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ckbParking.Location = new Point(57, 112);
            ckbParking.Margin = new Padding(4);
            ckbParking.Name = "ckbParking";
            ckbParking.Size = new Size(106, 31);
            ckbParking.TabIndex = 4;
            ckbParking.Text = "Parking";
            ckbParking.UseVisualStyleBackColor = true;
            // 
            // ckbBreakfast
            // 
            ckbBreakfast.AutoSize = true;
            ckbBreakfast.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ckbBreakfast.Location = new Point(57, 65);
            ckbBreakfast.Margin = new Padding(4);
            ckbBreakfast.Name = "ckbBreakfast";
            ckbBreakfast.Size = new Size(122, 31);
            ckbBreakfast.TabIndex = 3;
            ckbBreakfast.Text = "Breakfast";
            ckbBreakfast.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBook.Location = new Point(63, 165);
            btnBook.Margin = new Padding(4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(96, 32);
            btnBook.TabIndex = 2;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRelease);
            groupBox2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            groupBox2.Location = new Point(816, 399);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(238, 99);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Release";
            // 
            // btnRelease
            // 
            btnRelease.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnRelease.Location = new Point(57, 38);
            btnRelease.Margin = new Padding(4);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(96, 39);
            btnRelease.TabIndex = 0;
            btnRelease.Text = "Perform";
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 595);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnBook;
        private GroupBox groupBox2;
        private Button btnRelease;
        private CheckBox ckbParking;
        private CheckBox ckbBreakfast;
        private DataGridViewTextBoxColumn RoomNum;
        private DataGridViewTextBoxColumn roomType;
        private DataGridViewTextBoxColumn bedCount;
        private DataGridViewTextBoxColumn Booked;
        private DataGridViewTextBoxColumn Breakfast;
        private DataGridViewTextBoxColumn Parking;
        private DataGridViewTextBoxColumn Cost;
    }
}
