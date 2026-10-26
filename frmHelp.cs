using Project_GAME_GK_HK3_2026_ERROR.Logic;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmHelp : Form
    {
        PictureBox[,] cells = new PictureBox[8, 8];   //khai bao mang 2 chieu 64 ô
        Piece[,] board = new Piece[8, 8]; // khai bao quan co 
        Point? selected = null;   // x hang , y cot, null ch chon o nao

        int step = 0;
        int tongsteps = 6;

        public frmHelp()
        {
            InitializeComponent();
            CreateCells();
            ShowStep();


        }

        private void lblHuongDan_Click(object sender, EventArgs e)
        {

        }



        private void ShowStep()
        {
            board = new Piece[8, 8];
            string text = "";
            int r = 0, c = 0;             // ô của quân đang được giới thiệu

            switch (step)
            {
                case 0:
                    text = "TỐT: đi thẳng 1 ô (nước đầu được đi 2 ô), ăn quân chéo phía trước.";
                    r = 6; c = 4;
                    Put(r, c, PieceType.Pawn, PieceColor.White);
                    Put(5, 5, PieceType.Pawn, PieceColor.Black);       // quân để thấy ăn chéo
                    break;
                case 1:
                    text = "XE: đi thẳng theo hàng ngang hoặc cột dọc, không nhảy qua quân khác.";
                    r = 4; c = 4;
                    Put(r, c, PieceType.Rook, PieceColor.White);
                    Put(4, 7, PieceType.Pawn, PieceColor.White);       // quân mình chắn đường
                    Put(2, 4, PieceType.Pawn, PieceColor.Black);       // quân địch ăn được
                    break;
                case 2:
                    text = "MÃ: đi hình chữ L quanh nó và là quân duy nhất nhảy qua được quân khác.";
                    r = 7; c = 1;
                    Put(r, c, PieceType.Knight, PieceColor.White);
                    Put(6, 1, PieceType.Pawn, PieceColor.White);
                    Put(6, 2, PieceType.Pawn, PieceColor.White);
                    break;
                case 3:
                    text = "TƯỢNG: đi chéo bao nhiêu ô cũng được, không nhảy qua quân khác.";
                    r = 4; c = 4;
                    Put(r, c, PieceType.Bishop, PieceColor.White);
                    Put(2, 6, PieceType.Pawn, PieceColor.Black);
                    break;
                case 4:
                    text = "HẬU: mạnh nhất, đi như Xe cộng Tượng (thẳng và chéo).";
                    r = 4; c = 3;
                    Put(r, c, PieceType.Queen, PieceColor.White);
                    break;
                case 5:
                    text = "VUA: đi 1 ô ở mọi hướng xung quanh. Vua bị chiếu hết thì thua ván cờ.";
                    r = 4; c = 4;
                    Put(r, c, PieceType.King, PieceColor.White);
                    break;
            }

            ColorBoard(r, c);
            ShowPieces();
            lblHuongDan.Text = text;
            btnBack.Enabled = (step > 0);
            btnNext.Text = ((step == tongsteps - 1)) ? "Đóng" : "Tiếp";
        }

        private void Put(int row, int col, PieceType type, PieceColor color)
        {
            board[row, col] = new Piece(type, color);
        }

        private void frmHelp_Load(object sender, System.EventArgs e)
        {
           
        }
        private void CreateCells()
        {
            int size = pnlBoard.Width / 8;
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    PictureBox cell = new PictureBox();
                    cell.Size = new Size(size, size);
                    cell.Location = new Point(c * size, r * size);
                    cell.Tag = new Point(r, c);
                    cell.BorderStyle = BorderStyle.FixedSingle;

                    cell.SizeMode = PictureBoxSizeMode.Zoom;
                    pnlBoard.Controls.Add(cell);
                    cells[r, c] = cell;
                }
            }
        }





        private void ColorBoard(int pr, int pc)
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {

                    if ((r + c) % 2 == 0)
                        cells[r, c].BackColor = Color.White;
                    else
                        cells[r, c].BackColor = Color.Gray;


                    if (MoveRules.IsValidMove(board, pr, pc, r, c))
                    {
                        if (board[r, c] == null)
                            cells[r, c].BackColor = Color.LightGreen;
                        else
                            cells[r, c].BackColor = Color.Red;
                    }
                }
            }

            cells[pr, pc].BackColor = Color.Yellow;
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
                        cells[r, c].Image = AssetManager.GetImage(piece.Type, piece.Color);
                    }
                }
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (step < tongsteps - 1)
            {
                step++;
                ShowStep();
            }
            else
            {
                Close();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (step > 0)
            {
                step--;
                ShowStep();
            }
        }

        private void lblNhom_Click(object sender, EventArgs e)
        {

        }
    }
}
