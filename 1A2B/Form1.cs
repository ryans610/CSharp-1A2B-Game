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
        private int[] ans = new int[4];
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        //Initialize
        private void Initialize()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < 4; i++)
            {
                ans[i] = rnd.Next(0, 9);
                for (int j = 0; j < i; j++)
                {
                    if (ans[j] == ans[i])
                    {
                        i--;
                        break;
                    }
                }
            }
            AnswerLabel.Text = "";
            ClearGuess();
            count = 0;
            ShowBox.Items.Clear();
            GuessNumber.Focus();
        }

        private void NewNumber_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void ClearGuess()
        {
            GuessNumber.Text = string.Empty;
        }

        //answer
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            AnswerLabel.Text = "答案為：" + ans[0] + ans[1] + ans[2] + ans[3];
        }

        //guess
        private void GuessButton_Click(object sender, EventArgs e)
        {
            int guess;
            if (!int.TryParse(GuessNumber.Text.Trim(), out guess))
            {
                Error();
                return;
            }
            if (guess > 9999)
            {
                Error();
                return;
            }
            int[] guessArray = new int[4];
            for (int i = 3; i >= 0; i--)
            {
                guessArray[i] = guess % 10;
                guess /= 10;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i != j && guessArray[i] == guessArray[j])
                    {
                        Error();
                        return;
                    }
                }
            }
            int A = 0, B = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (ans[i] == guessArray[j])
                    {
                        if (i == j)
                        {
                            A++;
                            break;
                        }
                        else
                        {
                            B++;
                            break;
                        }
                    }
                }
            }
            count++;
            ShowBox.Items.Add(count + "：" + guessArray[0] + guessArray[1] + guessArray[2] + guessArray[3] + "，" + A + "A" + B + "B");
            if (A == 4)
            {
                MessageBox.Show("你贏了!");
            }
            ClearGuess();
            GuessNumber.Focus();
        }

        private void Error()
        {
            MessageBox.Show("請輸入四位不重複的整數!");
            ClearGuess();
            GuessNumber.Focus();
        }
    }
}
