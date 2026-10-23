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
        public int SelectedMinutes { get; private set; } = 10; // lưu số phút
        public frmTime()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void bt20_Click(object sender, EventArgs e)
        {
            numMinutes.Value = 20;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTime_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void bt10_Click(object sender, EventArgs e)
        {
            numMinutes.Value = 10;
        }

        private void bt15_Click(object sender, EventArgs e)
        {
            numMinutes.Value = 15;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SelectedMinutes = (int)numMinutes.Value; // lưu

            this.DialogResult = DialogResult.OK; // xác nhận
            this.Close();
        }
    }
}
