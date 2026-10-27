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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            //đồng bộ âm thanh
            chkNhacmenu.Checked = AssetManager.NhacmenuEnabled;
            chkNhacco.Checked = AssetManager.NhaccoEnabled;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void frmSettings_Load(object sender, EventArgs e)
        {
            
        }

        private void chkNhacmenu_CheckedChanged(object sender, EventArgs e)
        {
            AssetManager.NhacmenuEnabled = chkNhacmenu.Checked;
            if (AssetManager.NhacmenuEnabled)
            {
                AssetManager.GetSound("nhacnen")?.PlayLooping();
            }
            else
            {
                AssetManager.GetSound("nhacnen")?.Stop();
            }
        }

        private void chkNhacco_CheckedChanged(object sender, EventArgs e)
        {
            AssetManager.NhaccoEnabled = chkNhacco.Checked;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSettings_Load_1(object sender, EventArgs e)
        {

        }
    }
}
