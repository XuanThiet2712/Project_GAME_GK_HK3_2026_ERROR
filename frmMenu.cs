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
            using (frmTime timeForm = new frmTime())
            {
                if (timeForm.ShowDialog() == DialogResult.OK) // mở form thời gian
                {
                    int minutes = timeForm.SelectedMinutes; // lấy số phút
                    this.Hide(); // an menu chuyen vao game
                    using (frmGame game = new frmGame(minutes))
                    {
                        game.ShowDialog(); //khi game dung lai
                    }
                    this.Show();
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang phát triển!!! Chờ nhiều chút nha","Thông báo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            string guide = "HƯỚNG DẪN CHƠI CỜ VUA:\n\n" + 
                           "1. Lượt chơi: Quân Trắng đi trước, Đen đi sau. Và người kia đi xong mới tới lượt mình và ngược lại\n" +
                           "2. Cách đi: Bấm vào quân cờ của bạn, các ô màu xanh gợi ý các nước đi của từng quân, ô đỏ ăn quân của đối thủ\n" +
                           "3. Nhập thành: Chọn Vua và di chuyển 2 ô về phía quân Xe.\n" +
                           "4. Phong Tốt: Đưa quân Tốt chạm tới hàng cuối cùng của đối thủ để phong cấp con Tốt.\n"+
                           "5. Hãy xem thật kĩ các nước đi của quân cờ rồi ra quyết định thật kĩ càng nhé!!!!";

            MessageBox.Show(guide, "Hướng Dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
