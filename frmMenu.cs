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
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?","Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes){ 
                Application.Exit(); // dong chuong trinh
            }
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
        private void btnplay_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmGame game = new frmGame())
            {
                game.ShowDialog();
            }
            this.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang phát triển!!! Chờ nhiều chút nha","Thông báo",
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
    }
}
