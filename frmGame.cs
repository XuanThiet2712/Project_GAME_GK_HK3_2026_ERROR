using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmGame : Form
    {
        PictureBox[,] cells = new PictureBox[8, 8];   //khai bao mang 2 chieu 64 ô
        Piece[,] board = new Piece[8, 8]; // khai bao quan co 
        Dictionary<string, Image> images = new Dictionary<string, Image>();   // khai bao anh co

        public frmGame()
        {
            InitializeComponent();
            CreateCells();
            ColorBoard();
            SetUpBoard();
            ShowPieces(); // hiện quân
        }

        private void ShowPieces()
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    Piece piece = board[r, c];
                    if (piece == null)
                    {
                        cells[r, c].Image = null;

                    }
                    else
                    {
                        cells[r, c].Image = GetImage(piece);
                    }
                }
            }
        }

        private Image GetImage(Piece piece)
        {
            string name = piece.Color.ToString().ToUpper() + piece.Type.ToString().ToUpper();
            if (!images.ContainsKey(name))
            {
                //string path = Path.Combine(Application.StartupPath, "Images", name + ".png");
                try
                {
                    images[name] = Image.FromFile(@"../../images/" + name + ".png");
                }

                catch (FileNotFoundException)
                {
                    MessageBox.Show("Image file not found: " + name + ".png");
                    return null;
                }
            }
            return images[name];
        }

        // tajo 64 oo vuong
        private void CreateCells()
        {
            int size = pnlBoard.Width / 8; // kích thước ô vuông
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    PictureBox cell = new PictureBox();
                    cell.Size = new Size(size, size);
                    cell.Location = new Point(c * size, r * size);
                    cell.SizeMode = PictureBoxSizeMode.Zoom;
                    pnlBoard.Controls.Add(cell);
                    cells[r, c] = cell;
                }
            }
        }

        // Tô màu so le bàn cờ 
        private void ColorBoard()
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    if ((r + c) % 2 == 0)
                    {
                        cells[r, c].BackColor = Color.White;
                    }
                    else
                    {
                        cells[r, c].BackColor = Color.Gray;
                    }
                }
            }
        }
        private void frmGame_Load(object sender, EventArgs e)
        {

        }

        //set up ban co
        private void SetUpBoard()
        {
            PieceType[] backRank = new PieceType[]
            {
                PieceType.Rook, PieceType.Knight, PieceType.Bishop, PieceType.Queen,
                PieceType.King, PieceType.Bishop, PieceType.Knight, PieceType.Rook
            };

            for(int c = 0; c < 8; c++)
            {
        
                board[0, c] = new Piece(backRank[c], PieceColor.White); // hafng sau quan trang
                board[1, c] = new Piece(PieceType.Pawn, PieceColor.White); // hang dau quan trang
   
                board[7, c] = new Piece(backRank[c], PieceColor.Black);  // hang sau quan den
                board[6, c] = new Piece(PieceType.Pawn, PieceColor.Black);// hang dau quan den
            }
        }
    }
}