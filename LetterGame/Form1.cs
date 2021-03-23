using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLetterGame
{
    public partial class Form1 : Form
    {
        GenerateWord generator = new GenerateWord();
        public string word;
        public int i = 0;
        public int welcomeTextCounter = 0;
        public int wordTimeCounter = 0;
        public int rightLetters = 0;
        public int tourCount = 0;
        public int textLength = 0;
        public string txt;
        public Form1()
        {
            InitializeComponent();
        }
        public void start()
        {
            word_screen.Text = generator.generateWord();
        }
        private void start_button_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer_minute_label.Text = 00.ToString();
                timer_second_label.Text = 00.ToString();
                words_txtbox.Text = "";
                finish_label.Text = "";
                score_label.Text = 0.ToString();
                timer1.Start();
                word_timer.Start();

                start();
            }

        }

        private void finish_button_Click(object sender, EventArgs e)
        {
            finish();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == word_screen.Text.ToUpper())
            {
                start();
                score_label.Text = (Convert.ToInt32(score_label.Text) + 1).ToString();
                rightLetters++;
                if (rightLetters == 5)
                {
                    rightLetters = 0;
                    tourCount++;
                }
                wordTimeCounter = 0;

            }
            else
            {
                finish();
            }
        }

        private void finish()
        {
            word_screen.Text = "";
            finish_label.Text = $"Game over. \nYour score: {score_label.Text}";
            timer1.Stop();
            word_timer.Stop();
            tourCount = 0;
            wordTimeCounter = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 10)
            {
                timer_second_label.Text = (Convert.ToInt32(timer_second_label.Text) + 1).ToString();
                i = 0;
            }
            if (timer_second_label.Text == 60.ToString())
            {
                timer_minute_label.Text = (Convert.ToInt32(timer_minute_label.Text) + 1).ToString();
                timer_second_label.Text = 00.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_second_label.Text = "00";
            timer_minute_label.Text = "00";
            txt = welcome_label.Text;
            textLength = txt.Length;
            welcome_label.Text = "";
            timer2.Start();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            welcomeTextCounter++;
            if (welcomeTextCounter > textLength)
            {
                welcomeTextCounter = 0;
                welcome_label.Text = "";
            }
            else
            {
                welcome_label.Text = txt.Substring(0, welcomeTextCounter);
                if (welcome_label.ForeColor == Color.Black)
                {
                    welcome_label.ForeColor = Color.Red;
                }
                else if (welcome_label.ForeColor == Color.Red)
                {
                    welcome_label.ForeColor = Color.Yellow;
                }
                else if (welcome_label.ForeColor == Color.Yellow)
                {
                    welcome_label.ForeColor = Color.Purple;
                }
                else if (welcome_label.ForeColor == Color.Purple)
                {
                    welcome_label.ForeColor = Color.Green;
                }
                else if (welcome_label.ForeColor == Color.Green)
                {
                    welcome_label.ForeColor = Color.Gray;
                }
                else if (welcome_label.ForeColor == Color.Gray)
                {
                    welcome_label.ForeColor = Color.Blue;
                }
                else
                {
                    welcome_label.ForeColor = Color.Black;
                }
            }
        }

        private void word_timer_Tick(object sender, EventArgs e)
        {
            wordTimeCounter++;
            Console.WriteLine(wordTimeCounter);
            if (wordTimeCounter > 100)
            {
                finish();

            }
            else
            {
                if (tourCount > 0)
                {
                    if (wordTimeCounter > 50)
                    {
                        finish();
                    }
                    else
                    {
                        if (tourCount > 1)
                        {
                            if (wordTimeCounter > 25)
                            {
                                finish();
                            }
                            else
                            {
                                if (tourCount > 2)
                                {
                                    if (wordTimeCounter > 10)
                                    {
                                        finish();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    public class GenerateWord
    {
        Random random = new Random();
        Dictionary<Int32, String> words = new Dictionary<int, string>();
        public GenerateWord()
        {
            words.Add(1, "A");
            words.Add(2, "B");
            words.Add(3, "C");
            words.Add(4, "D");
            words.Add(5, "E");
            words.Add(6, "F");
            words.Add(7, "G");
            words.Add(8, "H");
            words.Add(9, "I");
            words.Add(10, "J");
            words.Add(11, "K");
            words.Add(12, "L");
            words.Add(13, "M");
            words.Add(14, "N");
            words.Add(15, "O");
            words.Add(16, "P");
            words.Add(17, "Q");
            words.Add(18, "R");
            words.Add(19, "S");
            words.Add(20, "T");
            words.Add(21, "U");
            words.Add(22, "V");
            words.Add(23, "W");
            words.Add(24, "X");
            words.Add(25, "Y");
            words.Add(26, "Z");
        }
        public string generateWord()
        {
            var a = words[random.Next(1, 26)].ToString();
            return a;
        }
    }
}
