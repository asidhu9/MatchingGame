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
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scoreDbDataSet.HighScore' table. You can move, or remove it, as needed.
            this.highScoreTableAdapter.Fill(this.scoreDbDataSet.HighScore);

        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            StartForm openForm = new StartForm();
            openForm.Show();
        }
    }
}
