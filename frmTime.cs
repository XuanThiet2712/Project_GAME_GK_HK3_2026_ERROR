using System;
using System.Windows.Forms;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmTime : Form
    {
        public frmTime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numMinutes.Value = 10;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            numMinutes.Value = 15;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            numMinutes.Value = 20;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string player1 = txtPlayer1.Text.Trim(); 
            string player2 = txtPlayer2.Text.Trim(); 

            bool valid = true;
            if (string.IsNullOrWhiteSpace(player1))
            {
                errorProvider1.SetError(txtPlayer1, "Vui lòng nhập tên Player 1");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(player2))
            {
                errorProvider1.SetError(txtPlayer2, "Vui lòng nhập tên Player 2");
                valid = false;
            }
            if (!valid) return;

            int minutes = (int)numMinutes.Value;

            AssetManager.GetSound("nhacnen")?.Stop();
            this.Hide();
            using (frmGame game = new frmGame(minutes, player1, player2))
            {
                game.ShowDialog();
            }

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void frmTime_Load(object sender, EventArgs e)
        {

        }
    }
}
