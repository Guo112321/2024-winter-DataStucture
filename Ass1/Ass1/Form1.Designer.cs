namespace Ass1
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
            panel1 = new Panel();
            buttonAdd = new Button();
            buttonSearchConfirm = new Button();
            txtSearch = new TextBox();
            labelSearch = new Label();
            labelTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(buttonSearchConfirm);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(labelSearch);
            panel1.Controls.Add(labelTitle);
            panel1.Location = new Point(24, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 120);
            panel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(575, 70);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(148, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "New Course Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSearchConfirm
            // 
            buttonSearchConfirm.Location = new Point(316, 74);
            buttonSearchConfirm.Name = "buttonSearchConfirm";
            buttonSearchConfirm.Size = new Size(75, 29);
            buttonSearchConfirm.TabIndex = 3;
            buttonSearchConfirm.Text = "Confirm";
            buttonSearchConfirm.UseVisualStyleBackColor = true;
            buttonSearchConfirm.Click += buttonSearchConfirm_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(211, 76);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(83, 27);
            txtSearch.TabIndex = 2;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(44, 79);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(161, 20);
            labelSearch.TabIndex = 1;
            labelSearch.Text = "Search Course by Id: ";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Mongolian Baiti", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(187, 13);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(373, 40);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Course Grades System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonAdd;
        private Button buttonSearchConfirm;
        private TextBox txtSearch;
        private Label labelSearch;
        private Label labelTitle;
    }
}
