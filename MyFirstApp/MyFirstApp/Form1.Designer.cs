namespace MyFirstApp
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
            option1RadioButton = new RadioButton();
            option2RadioButton = new RadioButton();
            option3RadioButton = new RadioButton();
            option4RadioButton = new RadioButton();
            nextbutton = new Button();
            previousbutton = new Button();
            submitbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 39);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // option1RadioButton
            // 
            option1RadioButton.AutoSize = true;
            option1RadioButton.Location = new Point(22, 106);
            option1RadioButton.Name = "option1RadioButton";
            option1RadioButton.Size = new Size(88, 24);
            option1RadioButton.TabIndex = 1;
            option1RadioButton.TabStop = true;
            option1RadioButton.Text = "option1";
            option1RadioButton.UseVisualStyleBackColor = true;
            // 
            // option2RadioButton
            // 
            option2RadioButton.AutoSize = true;
            option2RadioButton.Location = new Point(22, 158);
            option2RadioButton.Name = "option2RadioButton";
            option2RadioButton.Size = new Size(88, 24);
            option2RadioButton.TabIndex = 2;
            option2RadioButton.TabStop = true;
            option2RadioButton.Text = "option2";
            option2RadioButton.UseVisualStyleBackColor = true;
            // 
            // option3RadioButton
            // 
            option3RadioButton.AutoSize = true;
            option3RadioButton.Location = new Point(22, 216);
            option3RadioButton.Name = "option3RadioButton";
            option3RadioButton.Size = new Size(88, 24);
            option3RadioButton.TabIndex = 3;
            option3RadioButton.TabStop = true;
            option3RadioButton.Text = "option3";
            option3RadioButton.UseVisualStyleBackColor = true;
            // 
            // option4RadioButton
            // 
            option4RadioButton.AutoSize = true;
            option4RadioButton.Location = new Point(22, 271);
            option4RadioButton.Name = "option4RadioButton";
            option4RadioButton.Size = new Size(88, 24);
            option4RadioButton.TabIndex = 4;
            option4RadioButton.TabStop = true;
            option4RadioButton.Text = "option4";
            option4RadioButton.UseVisualStyleBackColor = true;
            // 
            // nextbutton
            // 
            nextbutton.Location = new Point(256, 366);
            nextbutton.Name = "nextbutton";
            nextbutton.Size = new Size(94, 29);
            nextbutton.TabIndex = 5;
            nextbutton.Text = "Next";
            nextbutton.UseVisualStyleBackColor = true;
            // 
            // previousbutton
            // 
            previousbutton.Location = new Point(443, 370);
            previousbutton.Name = "previousbutton";
            previousbutton.Size = new Size(94, 29);
            previousbutton.TabIndex = 6;
            previousbutton.Text = "Previous";
            previousbutton.UseVisualStyleBackColor = true;
            // 
            // submitbutton
            // 
            submitbutton.Location = new Point(634, 376);
            submitbutton.Name = "submitbutton";
            submitbutton.Size = new Size(94, 29);
            submitbutton.TabIndex = 7;
            submitbutton.Text = "Submit";
            submitbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitbutton);
            Controls.Add(previousbutton);
            Controls.Add(nextbutton);
            Controls.Add(option4RadioButton);
            Controls.Add(option3RadioButton);
            Controls.Add(option2RadioButton);
            Controls.Add(option1RadioButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton option1RadioButton;
        private RadioButton option2RadioButton;
        private RadioButton option3RadioButton;
        private RadioButton option4RadioButton;
        private Button nextbutton;
        private Button previousbutton;
        private Button submitbutton;
    }
}
