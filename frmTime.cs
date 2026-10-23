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
            SelectedMinutes = (int)numMinutes.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
