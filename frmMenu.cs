using System;
using System.Windows.Forms;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // dong chuong trinh
            }
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (AssetManager.SoundEnabled)
            {
                AssetManager.GetSound("nhacnen")?.PlayLooping();
            }
        }
        private void btnplay_Click(object sender, EventArgs e)
        {
            using (frmTime f = new frmTime())
            {
                if (f.ShowDialog() != DialogResult.OK)
                    return;

                int minutes = f.SelectedMinutes;
                string player1 = f.Player1Name;
                string player2 = f.Player2Name;

                this.Hide();
                try
                {
                    using (frmGame game = new frmGame(minutes, player1, player2))
                    {
                        game.ShowDialog();
                    }
                }
                finally
                {
                    this.Show();
                }
            }
            //khi chơi thì tắt nhạc nền
            AssetManager.GetSound("nhacnen")?.Stop();
            this.Hide();
            using (frmGame game = new frmGame())
            {
                game.ShowDialog();
            }

            this.Show();

            // thoát ra thì bật lên lại
            if (AssetManager.SoundEnabled)
            {
                AssetManager.GetSound("nhacnen")?.PlayLooping();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang phát triển!!! Chờ nhiều chút nha", "Thông báo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            using (frmHelp helpForm = new frmHelp())
            {
                // Thiết lập để Form hướng dẫn hiện ra ở giữa màn hình cho đẹp
                helpForm.StartPosition = FormStartPosition.CenterParent;
                helpForm.ShowDialog();
            }

            //MessageBox.Show("Hướng Dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frmScores history = new frmScores()) // tao cua so tran dau
            {
                history.ShowDialog();
            }
        }
    }
}
