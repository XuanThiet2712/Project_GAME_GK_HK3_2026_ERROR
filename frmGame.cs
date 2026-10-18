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

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmGame : Form
    {
        PictureBox[,] cells = new PictureBox[8, 8];   //khai bao mang 2 chieu 64 ô

        public frmGame()
        {
            InitializeComponent();
            CreateCells();
            ColorBoard();
        }

        // Tạo 64 PictureBox và đặt vào pnlBoard
        private void CreateCells()
        {
            int size = pnlBoard.ClientSize.Width / 8;  // cạnh ô cờ

            for (int r = 0; r < 8; r++)                 // r = hàng
            {
                for (int c = 0; c < 8; c++)             // c = cột
                {
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(size, size);
                    pb.Location = new Point(c * size, r * size);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;

                    pnlBoard.Controls.Add(pb);
                    cells[r, c] = pb;
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
                        //mốt thêm ảnh
                        cells[r, c].BackColor = Color.FromArgb(240, 217, 181);   // ô sáng
                    else
                        //mot them anh
                        cells[r, c].BackColor = Color.FromArgb(181, 136, 99);    // ô tối
                }
            }
        }
        private void frmGame_Load(object sender, EventArgs e)
        {
        }
    }
}