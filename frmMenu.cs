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
            if (AssetManager.NhacmenuEnabled)
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

                // Mở trận đấu với thời gian và tên người chơi đã chọn

                AssetManager.GetSound("nhacnen")?.Stop();
                this.Hide();
                try
                {
                    using (frmGame game = new frmGame(f.SelectedMinutes, f.Player1Name, f.Player2Name))
                    {
                        game.ShowDialog();
                    }
                }
                finally
                {
                    this.Show();
                    if (AssetManager.NhacmenuEnabled)
                        AssetManager.GetSound("nhacnen")?.PlayLooping();
                }
            }

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (frmSettings settings = new frmSettings())
            {
                settings.StartPosition = FormStartPosition.CenterParent;
                settings.ShowDialog();
            }
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
