namespace PracticePRactice
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
            label2 = new Label();
            textBox1 = new TextBox();
            lblGrade = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 59);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 132);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 1;
            label2.Text = "Grade:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 29);
            textBox1.TabIndex = 2;
            // 
            // lblGrade
            // 
            lblGrade.BorderStyle = BorderStyle.FixedSingle;
            lblGrade.Location = new Point(185, 131);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(152, 39);
            lblGrade.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(133, 257);
            button1.Name = "button1";
            button1.Size = new Size(172, 53);
            button1.TabIndex = 4;
            button1.Text = "Search Grade";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 386);
            Controls.Add(button1);
            Controls.Add(lblGrade);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label lblGrade;
        private Button button1;
    }
}
