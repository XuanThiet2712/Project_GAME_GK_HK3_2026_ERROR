using System;
using System.Windows.Forms;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmPromotion : Form
    {
        // luu quan co duoc chon
        public static PieceType Selected = PieceType.Queen;
        // luu mau quan tot
        private PieceColor currentColor;
        public frmPromotion()
        {
            InitializeComponent();
        }
        // nhan mau quan co tu ban co chinh
        public frmPromotion(PieceColor color)
        {
            InitializeComponent();
            currentColor = color;
        }
        private void frmPromotion_Load(object sender, EventArgs e)
        {
            // mac dinh ban dau chon la Hau
            Selected = PieceType.Queen;
            // gan anh vao 4 btn
            btnQueen.Image = AssetManager.GetImage(PieceType.Queen, currentColor);
            btnKnight.Image = AssetManager.GetImage(PieceType.Knight, currentColor);
            btnBishop.Image = AssetManager.GetImage(PieceType.Bishop, currentColor);
            btnRook.Image = AssetManager.GetImage(PieceType.Rook, currentColor);

            //hieu chinh picture mac dinh hien thi la Hau
            picQueen.Image = AssetManager.GetImage(PieceType.Queen, currentColor);
            picQueen.SizeMode = PictureBoxSizeMode.Zoom; // zoom de anh khong bi meo

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

        private void btnQueen_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnKnight_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnBishop_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnRook_MouseEnter(object sender, EventArgs e)
        {

        }

        /*private void frmPromotion_Load(object sender, EventArgs e)
        {
            // check con tot den hay trang

            //picQueen.Image = Image.FromFile(@"../../images/WHITEQUEEN.png");
            picQueen.Image = AssetManager.GetImage(PieceType.Queen, PieceColor.White);
            picQueen.SizeMode = PictureBoxSizeMode.Zoom;
        }*/
    }
}
