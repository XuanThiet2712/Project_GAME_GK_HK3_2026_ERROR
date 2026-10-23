using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmPromotion : Form
    {
        public PieceType Selected = PieceType.Queen;
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
            this.currentColor = color;
        }
        //khi click chon
        private void btnQueen_Click(object sender, EventArgs e)
        {
            Selected = PieceType.Queen;
            this.Close();
        }

        private void btnKnight_Click(object sender, EventArgs e)
        {
            Selected = PieceType.Knight;
            this.Close();
        }

        private void btnBishop_Click(object sender, EventArgs e)
        {
            Selected = PieceType.Bishop;
            this.Close();
        }

        private void btnRook_Click(object sender, EventArgs e)
        {
            Selected = PieceType.Rook;
            this.Close();
        }
        // doi anh o picturebox khi re chuot qua
        private void btnQueen_MouseEnter(object sender, EventArgs e)
        {
            picQueen.Image = AssetManager.GetImage(PieceType.Queen, currentColor);
        }

        private void btnKnight_MouseEnter(object sender, EventArgs e)
        {
            picQueen.Image = AssetManager.GetImage(PieceType.Knight, currentColor);
        }

        private void btnBishop_MouseEnter(object sender, EventArgs e)
        {
            picQueen.Image = AssetManager.GetImage(PieceType.Bishop, currentColor);
        }

        private void btnRook_MouseEnter(object sender, EventArgs e)
        {
            picQueen.Image = AssetManager.GetImage(PieceType.Rook, currentColor);
        }
        private void frmPromotion_Load(object sender, EventArgs e)
        {
             // mac dinh ban dau chon la Hau
            Selected = PieceType.Queen;
            // lay anh goc
            Image imgQueen = AssetManager.GetImage(PieceType.Queen, currentColor);
            Image imgKnight = AssetManager.GetImage(PieceType.Knight, currentColor);
            Image imgBishop = AssetManager.GetImage(PieceType.Bishop, currentColor);
            Image imgRook = AssetManager.GetImage(PieceType.Rook, currentColor);
            // thu nho anh
            btnQueen.Image = new Bitmap(imgQueen, new Size(32, 32));
            btnKnight.Image = new Bitmap(imgKnight, new Size(32, 32));
            btnBishop.Image = new Bitmap(imgBishop, new Size(32, 32));
            btnRook.Image = new Bitmap(imgRook, new Size(32, 32));
            //hieu chinh picture mac dinh hien thi la Hau
            picQueen.Image = AssetManager.GetImage(PieceType.Queen, currentColor);
            picQueen.SizeMode = PictureBoxSizeMode.Zoom; // zoom de anh khong bi meo
        }
    }
}
