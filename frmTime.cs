using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmTime : Form
    {
        public frmTime()
        {
            InitializeComponent();
        }
        public int SelectedMinutes { get; private set; } = 10;
        public string Player1Name { get; private set; } = ""; // tên đen

        public string Player2Name { get; private set; } = ""; // tên trắng
        private void Button3_Click(object sender, EventArgs e)
        {
            numMinutes.Value = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numMinutes.Value = 10;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            numMinutes.Value = 15;
        }

        private void numMinutes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            // Lấy tên người chơi
            string player1 = txtPlayer1.Text.Trim();
            string player2 = txtPlayer2.Text.Trim();
            //ktra lỗi nhập tên
            bool check = false ; 
            if (string.IsNullOrWhiteSpace(player1))
            {
                errorProvider1.SetError(txtPlayer1, "Ten khong duoc de trong");
                //MessageBox.Show(
                //    "Vui lòng nhập tên đầy đủ của cả hai người chơi!",
                //    "Thiếu thông tin",
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Warning
                //);
                check = true; 
            }
            if (string.IsNullOrWhiteSpace(player2))
            {
                errorProvider1.SetError(txtPlayer2, "Ten không được để trống");
                check = true;
            }

            if (check) return;
            // Lưu lại tên
            Player1Name = player1;
            Player2Name = player2;

            // Lấy thời gian
            SelectedMinutes = (int)numMinutes.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmTime_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlayer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void txtPlayer1_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblPlayer2_Click(object sender, EventArgs e)
        {

        }
    }
}
