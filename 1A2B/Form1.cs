using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1A2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] ans = new int[4];
        int count = 0;
        private void NewNumber_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int i = 0;
            while (i < 4)
            {
                ans[i] = rnd.Next(0, 9);
                int j = 0;
                while (j < i)
                {
                    if (ans[j] == ans[i])
                    {
                        i = i - 1;
                        break;
                    }
                    j = j + 1;
                }
                i = i + 1;
            }
            AnswerLabel.Text = "";
            count = 0;
            GuessNumber.Text = "";
            ShowBox.Items.Clear();
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            AnswerLabel.Text = "答案為：" + ans[0] + ans[1] + ans[2] + ans[3];
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            int A = 0, B = 0;
            int guess = int.Parse(GuessNumber.Text);
            int[] guessArray = new int[4];
            int i = 3;
            while (i >= 0)
            {
                guessArray[i] = guess % 10;
                i = i - 1;
                guess = guess / 10;
            }
            i = 0;
            while (i < 4)
            {
                int j = 0;
                while (j < 4)
                {
                    if (ans[i] == guessArray[j])
                    {
                        if (i == j)
                        {
                            A = A + 1;
                            break;
                        }
                        else
                        {
                            B = B + 1;
                            break;
                        }
                    }
                    j = j + 1;
                }
                i = i + 1;
            }
            count = count + 1;
            ShowBox.Items.Add("第" + count + "次：" + GuessNumber.Text + "，" + A + "A" + B + "B");
            if (A == 4)
            {
                MessageBox.Show("你贏了!");
            }
        }
    }
}
