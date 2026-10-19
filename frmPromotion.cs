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
    }
}
