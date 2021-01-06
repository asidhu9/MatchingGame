using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class HardGame : Form
    {
        Label firstClicked = null;
        Label secondClicked = null;

        Random random = new Random();

        int Score = 0;

        int timeleft = 80;
        int scoretime = 0;

        // for easy, medium, hard
        int timemultiplier = 75;


        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k", "b", "b", "v", "v", "w", "w", "z", "z","o", "o", "r", "r", "p", "p", "g", "g"
        };

        public HardGame()
        {
            InitializeComponent();

            AssignIconsToSquares();

            countdownTimer.Start();


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }


        private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    Score = Score + 100;
                    ScoreLabel.Text = "Score: " + Score.ToString();
                    return;
                }

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            scoreCalc();
            EndForm frm = new EndForm(Score);
            frm.Show();
            Close();
        }

        private void scoreCalc()
        {
            countdownTimer.Stop();
            scoretime = (timemultiplier * timeleft);
            Score = Score + scoretime;
        }

        public HardGame(string title, string txt)
        {
            InitializeComponent();
            ScoreLabel.Text = title;
            label1.Text = txt;
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft--;
                TimerLabel.Text = "Time: " + timeleft + " s";
            }
            else
            {
                countdownTimer.Stop();
                TimerLabel.Text = "0 s";
                Visible = false;


                scoreCalc();

                scoretime = (timemultiplier * timeleft);
                Score = Score + scoretime;


                ScoreLabel.Text = "Score: " + Score.ToString();
                EndForm frm = new EndForm(Score);
                frm.Show();
            }

        }
    }
}
