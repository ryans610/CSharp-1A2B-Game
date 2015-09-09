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
        //properties
        private int[] ans = new int[4];
        private int count = 0;
        private string language = "cht";
        private Dictionary<string, string> languageList = new Dictionary<string, string>(){
            {"English","eng"},
            {"繁體中文","cht"}
        };
        private Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>(){
            {"eng",new Dictionary<string,string>(){
                {"answeris","Answer is"},
                {"win","You Win"},
                {"error","Please input four digits integer that does not repeat"},
                {"guess","Guess"},
                {"restart","reStart"},
                {"answer","Answer"}
            }},
            {"cht",new Dictionary<string,string>(){
                {"answeris","答案是"},
                {"win","你贏了"},
                {"error","請輸入四位不重複的整數"},
                {"guess","猜數字"},
                {"restart","重新開始"},
                {"answer","公布答案"}
            }}
        };

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

        //language change
        private void LanguageChange_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (KeyValuePair<string, string> kv in languageList)
            {
                if (found)
                {
                    LanguageChange.Text = kv.Key;
                    found = false;
                    break;
                }
                else
                {
                    if (kv.Key == LanguageChange.Text)
                    {
                        language = kv.Value;
                        found = true;
                    }
                }
            }
            if (found)
            {
                LanguageChange.Text = languageList.ElementAt(0).Key;
            }
            NewNumber.Text = dictionary[language]["restart"];
            AnswerButton.Text = dictionary[language]["answer"];
            GuessButton.Text = dictionary[language]["guess"];
        }

        //answer
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            AnswerLabel.Text = dictionary[language]["answeris"] + "：" + ans[0] + ans[1] + ans[2] + ans[3];
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
                MessageBox.Show(dictionary[language]["win"] + "!\n" + dictionary[language]["answeris"] + "：" + ans[0] + ans[1] + ans[2] + ans[3]);
            }
            ClearGuess();
            GuessNumber.Focus();
        }

        private void Error()
        {
            MessageBox.Show(dictionary[language]["error"] + "!");
            ClearGuess();
            GuessNumber.Focus();
        }
    }
}
