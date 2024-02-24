namespace Ass2
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
            button1 = new Button();
            StudentListBox = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 43);
            label1.Name = "label1";
            label1.Size = new Size(269, 26);
            label1.TabIndex = 0;
            label1.Text = "Student Course System";
            // 
            // button1
            // 
            button1.Location = new Point(592, 171);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 1;
            button1.Text = "Add Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StudentListBox
            // 
            StudentListBox.FormattingEnabled = true;
            StudentListBox.Location = new Point(30, 105);
            StudentListBox.Name = "StudentListBox";
            StudentListBox.Size = new Size(502, 264);
            StudentListBox.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(592, 274);
            button2.Name = "button2";
            button2.Size = new Size(152, 29);
            button2.TabIndex = 3;
            button2.Text = "Delete Student";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(StudentListBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ListBox StudentListBox;
        private Button button2;
    }
}
