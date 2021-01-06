using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MatchingGame
{
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void EndForm_Load(object sender, EventArgs e)
        {

        }

        public EndForm(int Value)
        {
            InitializeComponent();
            scoreLabel.Text = Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::MatchingGame.Properties.Settings.Default.ScoreDbConnectionString);
            try {
                string sql = "INSERT INTO HighScore(Initials, Score) values('"+ NameEntry.Text +"', '"+ scoreLabel.Text.ToString()+"');";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();

                MessageBox.Show("Initial and Score Added! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (Exception ex) { MessageBox.Show(ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { cn.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            StartForm f2 = new StartForm();
            f2.Show();
        }
    }
}
