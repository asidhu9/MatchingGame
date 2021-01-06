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

    public partial class StartForm : Form
    {

        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                EasyGame openForm = new EasyGame();
                openForm.Show();
            }
            
            else if (radioButton2.Checked == true)
            {
                NormalGame openForm = new NormalGame();
                openForm.Show();
            }
            else
            {
                HardGame openForm = new HardGame();
                openForm.Show();
            }

            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScoreForm openForm = new ScoreForm();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EndForm openForm = new EndForm();
            openForm.Show();
        }
    }
}
