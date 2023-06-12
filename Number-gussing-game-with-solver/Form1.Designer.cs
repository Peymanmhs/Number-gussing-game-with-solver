namespace Number_gussing_game_with_solver
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox2 = new ListBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 38);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 144);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(455, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(147, 284);
            listBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(163, 266);
            button1.Name = "button1";
            button1.Size = new Size(116, 40);
            button1.TabIndex = 3;
            button1.Text = "Cheak";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(256, 312);
            button2.Name = "button2";
            button2.Size = new Size(149, 45);
            button2.TabIndex = 4;
            button2.Text = "Auto Solver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(34, 312);
            button3.Name = "button3";
            button3.Size = new Size(150, 45);
            button3.TabIndex = 5;
            button3.Text = "Reset the game";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(620, 73);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(147, 284);
            listBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 144);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 236);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 9;
            label4.Text = "Guess your number :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(471, 38);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 10;
            label5.Text = "Your guesses :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(634, 38);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 11;
            label6.Text = "Solver guesses :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 73);
            label7.Name = "label7";
            label7.Size = new Size(267, 20);
            label7.TabIndex = 12;
            label7.Text = "Guess a number between 100 and 999 .";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}