namespace Ass2
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
            label1 = new Label();
            txtStudentName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtScoreObtained = new TextBox();
            txtMaxScore = new TextBox();
            panel1 = new Panel();
            rdbSubmit = new RadioButton();
            rdbPresent = new RadioButton();
            rdbRemove = new RadioButton();
            rdbEdit = new RadioButton();
            rdbAddLab = new RadioButton();
            rdbAddtest = new RadioButton();
            InformationLabel = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 19);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(406, 12);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(84, 27);
            txtStudentName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 56);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "ID/Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 56);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 3;
            label3.Text = "Score Obtained:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(607, 56);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 4;
            label4.Text = "Max Score:";
            // 
            // txtId
            // 
            txtId.Location = new Point(144, 53);
            txtId.Name = "txtId";
            txtId.Size = new Size(76, 27);
            txtId.TabIndex = 5;
            // 
            // txtScoreObtained
            // 
            txtScoreObtained.Location = new Point(406, 53);
            txtScoreObtained.Name = "txtScoreObtained";
            txtScoreObtained.Size = new Size(76, 27);
            txtScoreObtained.TabIndex = 6;
            // 
            // txtMaxScore
            // 
            txtMaxScore.Location = new Point(703, 53);
            txtMaxScore.Name = "txtMaxScore";
            txtMaxScore.Size = new Size(76, 27);
            txtMaxScore.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(rdbSubmit);
            panel1.Controls.Add(rdbPresent);
            panel1.Controls.Add(rdbRemove);
            panel1.Controls.Add(rdbEdit);
            panel1.Controls.Add(rdbAddLab);
            panel1.Controls.Add(rdbAddtest);
            panel1.Location = new Point(24, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 204);
            panel1.TabIndex = 8;
            // 
            // rdbSubmit
            // 
            rdbSubmit.AutoSize = true;
            rdbSubmit.Location = new Point(7, 164);
            rdbSubmit.Name = "rdbSubmit";
            rdbSubmit.Size = new Size(82, 24);
            rdbSubmit.TabIndex = 6;
            rdbSubmit.TabStop = true;
            rdbSubmit.Text = "Submit";
            rdbSubmit.UseVisualStyleBackColor = true;
            // 
            // rdbPresent
            // 
            rdbPresent.AutoSize = true;
            rdbPresent.Location = new Point(7, 134);
            rdbPresent.Name = "rdbPresent";
            rdbPresent.Size = new Size(131, 24);
            rdbPresent.TabIndex = 5;
            rdbPresent.TabStop = true;
            rdbPresent.Text = "Present all lab";
            rdbPresent.UseVisualStyleBackColor = true;
            // 
            // rdbRemove
            // 
            rdbRemove.AutoSize = true;
            rdbRemove.Location = new Point(7, 104);
            rdbRemove.Name = "rdbRemove";
            rdbRemove.Size = new Size(162, 24);
            rdbRemove.TabIndex = 3;
            rdbRemove.TabStop = true;
            rdbRemove.Text = "Remove test by Id";
            rdbRemove.UseVisualStyleBackColor = true;
            // 
            // rdbEdit
            // 
            rdbEdit.AutoSize = true;
            rdbEdit.Location = new Point(7, 74);
            rdbEdit.Name = "rdbEdit";
            rdbEdit.Size = new Size(130, 24);
            rdbEdit.TabIndex = 2;
            rdbEdit.TabStop = true;
            rdbEdit.Text = "Edit test by Id";
            rdbEdit.UseVisualStyleBackColor = true;
            // 
            // rdbAddLab
            // 
            rdbAddLab.AutoSize = true;
            rdbAddLab.Location = new Point(7, 44);
            rdbAddLab.Name = "rdbAddLab";
            rdbAddLab.Size = new Size(121, 24);
            rdbAddLab.TabIndex = 1;
            rdbAddLab.TabStop = true;
            rdbAddLab.Text = "Add new lab";
            rdbAddLab.UseVisualStyleBackColor = true;
            // 
            // rdbAddtest
            // 
            rdbAddtest.AutoSize = true;
            rdbAddtest.Location = new Point(7, 14);
            rdbAddtest.Name = "rdbAddtest";
            rdbAddtest.Size = new Size(127, 24);
            rdbAddtest.TabIndex = 0;
            rdbAddtest.TabStop = true;
            rdbAddtest.Text = "Add new test";
            rdbAddtest.UseVisualStyleBackColor = true;
            // 
            // InformationLabel
            // 
            InformationLabel.AutoEllipsis = true;
            InformationLabel.Location = new Point(273, 121);
            InformationLabel.Name = "InformationLabel";
            InformationLabel.Size = new Size(506, 310);
            InformationLabel.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(58, 349);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Perform";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(InformationLabel);
            Controls.Add(panel1);
            Controls.Add(txtMaxScore);
            Controls.Add(txtScoreObtained);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtStudentName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtScoreObtained;
        private TextBox txtMaxScore;
        private Panel panel1;
        private RadioButton rdbRemove;
        private RadioButton rdbEdit;
        private RadioButton rdbAddLab;
        private RadioButton rdbAddtest;
        private Label InformationLabel;
        private RadioButton rdbSubmit;
        private RadioButton rdbPresent;
        private Button button1;
    }
}