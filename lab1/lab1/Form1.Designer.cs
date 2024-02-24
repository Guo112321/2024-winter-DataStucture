namespace lab1
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTestId = new TextBox();
            txtScoreObtained = new TextBox();
            txtMaxScore = new TextBox();
            button1 = new Button();
            txtAveScore = new Label();
            button2 = new Button();
            label4 = new Label();
            txtDeleteTest = new TextBox();
            button3 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Test ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 19);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 1;
            label2.Text = "Score Obtained:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 19);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Max Score:";
            // 
            // txtTestId
            // 
            txtTestId.Location = new Point(88, 16);
            txtTestId.Name = "txtTestId";
            txtTestId.Size = new Size(71, 27);
            txtTestId.TabIndex = 3;
            // 
            // txtScoreObtained
            // 
            txtScoreObtained.Location = new Point(335, 16);
            txtScoreObtained.Name = "txtScoreObtained";
            txtScoreObtained.Size = new Size(71, 27);
            txtScoreObtained.TabIndex = 4;
            // 
            // txtMaxScore
            // 
            txtMaxScore.Location = new Point(541, 16);
            txtMaxScore.Name = "txtMaxScore";
            txtMaxScore.Size = new Size(71, 27);
            txtMaxScore.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(680, 15);
            button1.Name = "button1";
            button1.Size = new Size(59, 29);
            button1.TabIndex = 6;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAveScore
            // 
            txtAveScore.AutoSize = true;
            txtAveScore.Location = new Point(479, 60);
            txtAveScore.Name = "txtAveScore";
            txtAveScore.Size = new Size(133, 20);
            txtAveScore.TabIndex = 7;
            txtAveScore.Text = "Average Score: 0";
            // 
            // button2
            // 
            button2.Location = new Point(660, 60);
            button2.Name = "button2";
            button2.Size = new Size(79, 29);
            button2.TabIndex = 8;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 60);
            label4.Name = "label4";
            label4.Size = new Size(211, 20);
            label4.TabIndex = 9;
            label4.Text = "Delete test based on testID:";
            // 
            // txtDeleteTest
            // 
            txtDeleteTest.Location = new Point(235, 60);
            txtDeleteTest.Name = "txtDeleteTest";
            txtDeleteTest.Size = new Size(47, 27);
            txtDeleteTest.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(288, 60);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Confirm";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(txtDeleteTest);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtAveScore);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtMaxScore);
            panel1.Controls.Add(txtScoreObtained);
            panel1.Controls.Add(txtTestId);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(24, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 106);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Test System";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private Button button3;
        private TextBox txtDeleteTest;
        private Label label4;
        private Button button2;
        private Label txtAveScore;
        private Button button1;
        private TextBox txtMaxScore;
        private TextBox txtScoreObtained;
        private TextBox txtTestId;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
