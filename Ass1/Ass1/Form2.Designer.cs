namespace Ass1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelCourseName = new Label();
            label1 = new Label();
            txtTestId = new TextBox();
            label2 = new Label();
            txtScoreObtained = new TextBox();
            label3 = new Label();
            buttonAddTest = new Button();
            label4 = new Label();
            txtDeleteTest = new TextBox();
            buttonConfirmDelete = new Button();
            txtAveScore = new Label();
            buttonUpdate = new Button();
            txtMaxScore = new TextBox();
            panel1 = new Panel();
            txtCourseName = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            buttonSubmit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCourseName
            // 
            labelCourseName.AutoSize = true;
            labelCourseName.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCourseName.Location = new Point(121, 9);
            labelCourseName.Name = "labelCourseName";
            labelCourseName.Size = new Size(185, 30);
            labelCourseName.TabIndex = 0;
            labelCourseName.Text = "Course Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 8);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Test Id:";
            // 
            // txtTestId
            // 
            txtTestId.Location = new Point(74, 5);
            txtTestId.Name = "txtTestId";
            txtTestId.Size = new Size(52, 27);
            txtTestId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 8);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 3;
            label2.Text = "Score Obtained:";
            // 
            // txtScoreObtained
            // 
            txtScoreObtained.Location = new Point(300, 5);
            txtScoreObtained.Name = "txtScoreObtained";
            txtScoreObtained.Size = new Size(65, 27);
            txtScoreObtained.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 8);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Max Score:";
            // 
            // buttonAddTest
            // 
            buttonAddTest.Location = new Point(655, 4);
            buttonAddTest.Name = "buttonAddTest";
            buttonAddTest.Size = new Size(94, 29);
            buttonAddTest.TabIndex = 6;
            buttonAddTest.Text = "ADD";
            buttonAddTest.UseVisualStyleBackColor = true;
            buttonAddTest.Click += buttonAddTest_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 63);
            label4.Name = "label4";
            label4.Size = new Size(211, 20);
            label4.TabIndex = 7;
            label4.Text = "Delete test based on testID:";
            // 
            // txtDeleteTest
            // 
            txtDeleteTest.Location = new Point(244, 60);
            txtDeleteTest.Name = "txtDeleteTest";
            txtDeleteTest.Size = new Size(62, 27);
            txtDeleteTest.TabIndex = 8;
            // 
            // buttonConfirmDelete
            // 
            buttonConfirmDelete.Location = new Point(353, 58);
            buttonConfirmDelete.Name = "buttonConfirmDelete";
            buttonConfirmDelete.Size = new Size(94, 29);
            buttonConfirmDelete.TabIndex = 9;
            buttonConfirmDelete.Text = "Confirm";
            buttonConfirmDelete.UseVisualStyleBackColor = true;
            buttonConfirmDelete.Click += buttonConfirmDelete_Click;
            // 
            // txtAveScore
            // 
            txtAveScore.AutoSize = true;
            txtAveScore.Location = new Point(480, 63);
            txtAveScore.Name = "txtAveScore";
            txtAveScore.Size = new Size(133, 20);
            txtAveScore.TabIndex = 10;
            txtAveScore.Text = "Average Score: 0";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(655, 58);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // txtMaxScore
            // 
            txtMaxScore.Location = new Point(521, 5);
            txtMaxScore.Name = "txtMaxScore";
            txtMaxScore.Size = new Size(69, 27);
            txtMaxScore.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(txtMaxScore);
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(txtAveScore);
            panel1.Controls.Add(buttonConfirmDelete);
            panel1.Controls.Add(txtDeleteTest);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonAddTest);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtScoreObtained);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTestId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 94);
            panel1.TabIndex = 13;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(312, 13);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(84, 27);
            txtCourseName.TabIndex = 14;
            // 
            // txtId
            // 
            txtId.Location = new Point(520, 13);
            txtId.Name = "txtId";
            txtId.Size = new Size(54, 27);
            txtId.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(461, 9);
            label5.Name = "label5";
            label5.Size = new Size(53, 30);
            label5.TabIndex = 16;
            label5.Text = "ID:";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(365, 409);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(74, 29);
            buttonSubmit.TabIndex = 17;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSubmit);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(txtCourseName);
            Controls.Add(panel1);
            Controls.Add(labelCourseName);
            Name = "Form2";
            Text = "Course Info";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCourseName;
        private Label label1;
        private TextBox txtTestId;
        private Label label2;
        private TextBox txtScoreObtained;
        private Label label3;
        private Button buttonAddTest;
        private Label label4;
        private TextBox txtDeleteTest;
        private Button buttonConfirmDelete;
        private Label txtAveScore;
        private Button buttonUpdate;
        private TextBox txtMaxScore;
        private Panel panel1;
        private TextBox txtCourseName;
        private TextBox txtId;
        private Label label5;
        private Button buttonSubmit;
        private Label label6;
    }
}