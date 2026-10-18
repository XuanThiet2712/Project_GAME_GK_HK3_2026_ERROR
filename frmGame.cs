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

        Point? selected = null;   // x hang , y cot, null ch chon o nao
        PieceColor turn = PieceColor.White;

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
                    cell.Tag = new Point(r, c); // lưu trữ vị trí ô trong Tag
                    cell.Click += Cell_Click;
                    cell.SizeMode = PictureBoxSizeMode.Zoom;
                    pnlBoard.Controls.Add(cell);
                    cells[r, c] = cell;
                }
            }
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            PictureBox cell = (PictureBox)sender;
            Point position = (Point)cell.Tag;
            int row = position.X;
            int col = position.Y;
            if (selected == null)
            {
                if (board[row, col] != null && board[row, col].Color == turn)
                {
                    selected = new Point(row, col);
                }

            }
            else
            {
                Point from = selected.Value;
                Piece movingPiece = board[from.X, from.Y];
                Piece target = board[row, col];
                if (target != null && target.Color == movingPiece.Color)
                {
                    selected = new Point(row, col);
                }
                else
                {
                    if (from.X != row || from.Y != col)
                    {
                        board[row, col] = movingPiece;
                        board[from.X, from.Y] = null;

                        if(turn == PieceColor.White)
                        {
                            turn = PieceColor.Black;
                        }
                        else
                        {
                            turn = PieceColor.White;
                        }
                    }
                    selected = null;

                }
            }

                ColorBoard();
                ShowPieces();
            
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
            if (selected.HasValue)
            {
                int r = selected.Value.X;
                int c = selected.Value.Y;
                cells[r, c].BackColor = Color.Yellow; // tô màu ô được chọn
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
        
                board[7, c] = new Piece(backRank[c], PieceColor.White); // hafng sau quan trang
                board[6, c] = new Piece(PieceType.Pawn, PieceColor.White); // hang dau quan trang
   
                board[0, c] = new Piece(backRank[c], PieceColor.Black);  // hang sau quan den
                board[1, c] = new Piece(PieceType.Pawn, PieceColor.Black);// hang dau quan den
            }
        }
    }
}