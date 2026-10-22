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
    public partial class frmPromotion: Form
    {
        public PieceType Selected = PieceType.Queen;
        public frmPromotion()
        {
            InitializeComponent();
        }

        private void btnQueen_Click(object sender, EventArgs e)
        {
            Selected = PieceType.Queen;
            Close();
        }

        private void btnKnight_Click(object sender, EventArgs e)
        {
            Selected = PieceType.Knight;
            Close();
        }

        private void btnBishop_Click(object sender, EventArgs e)
        {
            Selected = PieceType.Bishop;
            Close();
        }

        private void btnRook_Click(object sender, EventArgs e)
        {
            Selected = PieceType.Rook;
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPromotion_Load(object sender, EventArgs e)
        {
            // check con tot den hay trang
            
            //picQueen.Image = Image.FromFile(@"../../images/WHITEQUEEN.png");
            picQueen.Image = Manager.GetImage(PieceType.Queen, PieceColor.White);
            picQueen.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
