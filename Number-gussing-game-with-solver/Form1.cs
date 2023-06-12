using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Number_gussing_game_with_solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rnd;
        int count = 1;
        int n = 10;
        int a = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            rnd = r.Next(100, 999);
            label3.Text = "Answer is : " + rnd.ToString();
            label2.Text = "Round: " + count.ToString();
            label1.Text = "you have " + n.ToString() + " guesses !";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBox1.Text);
                textBox1.Text = "";
                if (x < 100 || x > 999)
                {
                    MessageBox.Show("Your number is not in range !!! Guess a number between 100 and 999 .");
                    return;
                }
                count++;
                int num = 11;
                num = num - count;
                label2.Text = "Round: " + count.ToString();
                label1.Text = "you have " + num.ToString() + " guesses !";
                if (count > 11)
                {
                    MessageBox.Show("Game Over !");
                    label2.Text = "Game Over !";
                    button1.Enabled = false;
                    return;
                }
                listBox1.Items.Add(a + ". " + x);
                a++;
                if (x < rnd)
                {
                    MessageBox.Show("Your Guess < this Number");
                }
                else if (x > rnd)
                {
                    MessageBox.Show("Your Guess > this Number");
                }
                else
                {
                    MessageBox.Show("WIN");
                    label1.Text = "You have Won ";
                    label2.Text += " - You WIN";
                    button1.Enabled = false;
                }

            }
            catch { }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int test = (999 - 100) / 2;
            int max = 999;
            int min = 100;
            int c = 1;
            listBox2.Items.Add(c + ". " + test);
            if (test == rnd)
            {
                MessageBox.Show("the answer is: " + test + " and the number of tries: " + c);
            }
            else
            {
                while (test != rnd)
                {
                    if (test > rnd)
                    {
                        max = test;
                        test = test - ((test - min) / 2);
                        c++;
                        listBox2.Items.Add(c + ". " + test);

                    }
                    else
                    {
                        min = test;
                        test = ((max - test) / 2) + test;
                        c++;
                        listBox2.Items.Add(c + ". " + test);
                    }

                }
                MessageBox.Show("the answer is: " + test + " and the number of tries: " + c);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Random r = new Random();
            rnd = r.Next(100, 999);
            count = 1;
            n = 10;
            a = 1;
            label3.Text = "Answer is : " + rnd.ToString();
            label2.Text = "Round: " + count.ToString();
            label1.Text = "you have " + n.ToString() + " guesses !";
            listBox1.Items.Clear();
            listBox2.Items.Clear();

        }
    }
}