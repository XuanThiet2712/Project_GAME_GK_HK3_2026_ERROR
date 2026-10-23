using Project_GAME_GK_HK3_2026_ERROR.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics; // bodemtime

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmGame : Form
    {
        PictureBox[,] cells = new PictureBox[8, 8];   //khai bao mang 2 chieu 64 ô
        Piece[,] board = new Piece[8, 8]; // khai bao quan co 

        //Dictionary<string, Image> images = new Dictionary<string, Image>();   // khai bao anh co

        Point? selected = null;   // x hang , y cot, null ch chon o nao
        PieceColor turn = PieceColor.White;
        int moveNumber = 1; // so nuoc dang di
        bool gameOver = false; // kiem tra game ket thuc
        Stopwatch stopwatch = new Stopwatch(); // đo thoi gian
        Timer gameTimer = new Timer(); // cap nhat label

        public frmGame()
        {
            InitializeComponent();
            CreateCells();
            ColorBoard();
            SetUpBoard();
            ShowPieces(); // hiện quân
            UpdateTitle();
            StartGameTimer();
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
                    cell.BorderStyle = BorderStyle.FixedSingle;
                    cell.Click += Cell_Click;
                    cell.SizeMode = PictureBoxSizeMode.Zoom;
                    pnlBoard.Controls.Add(cell);
                    cells[r, c] = cell;
                }
            }
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                MessageBox.Show("Game over! Ban co muon lam game moi ko");
                return;
            }
            PictureBox cell = (PictureBox)sender;
            Point position = (Point)cell.Tag;
            int row = position.X;
            int col = position.Y;
            if (selected == null)
            {
                if (board[row, col] != null && board[row, col].Color == turn)
                {
                    selected = new Point(row, col);
                    // hien thi quan co đang chon 
                    Piece p = board[row, col];
                    picSelectedPiece.Image = AssetManager.GetImage(p.Type, p.Color);

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
                    //hinh anh quan co
                    picSelectedPiece.Image = AssetManager.GetImage(target.Type, target.Color);
                }
                else
                {
                    if (from.X != row || from.Y != col)
                    {
                        if (GameRules.IsLegalMove(board, from.X, from.Y, row, col))
                        {
                            //MessageBox.Show(from.X + " " + from.Y + " " + row + " " + col);
                            DoMove(from.X, from.Y, row, col);
                        }
                        selected = null;
                        picSelectedPiece.Image = null;
                    }
                }
            }

            ColorBoard();
            ShowPieces();

        }
        // thuc hien nuoc di hop le 
        private void DoMove(int fromRow, int fromCol, int ToRow, int ToCol)
        {

            Piece movingPiece = board[fromRow, fromCol]; // quan se di 
            Piece targetPiece = board[ToRow, ToCol]; // quan bi an
            string moveText = "";
            if (GameRules.LeavesKingInCheck(board, fromRow, fromCol, ToRow, ToCol))
            {
                MessageBox.Show("Nước đi này sẽ khiến vị Vua của bạn bị tiêu diệt, vui lòng chọn nước khác !");
                return;
            }
            // nhap thanh
            bool isCastle = GameRules.CanCastle(board, fromRow, fromCol, ToCol);
            if (isCastle)
            {
                //vi tri con xe 
                int rookFromCol = (ToCol > fromCol) ? 7 : 0;
                int rookToCol = (ToCol > fromCol) ? 5 : 3;

                Piece rook = board[fromRow, rookFromCol];
                board[fromRow, rookFromCol] = null;
                rook.HasMoved = true;
                board[fromRow, rookToCol] = rook;

                moveText = (ToCol > fromCol) ? "O-O" : "O-O-O";
                MessageBox.Show("Nhập thành!");
            }

            // thuc hien nuoc di
            movingPiece.HasMoved = true;
            board[ToRow, ToCol] = movingPiece;
            board[fromRow, fromCol] = null;

            //phong quan tot
            string promoText = "";
            if (movingPiece.Type == PieceType.Pawn && (ToRow == 0 || ToRow == 7))
            {
                ShowPieces();
                frmPromotion f = new frmPromotion(movingPiece.Color);
                f.ShowDialog();
                board[ToRow, ToCol] = new Piece(f.Selected, movingPiece.Color);
                promoText = "=" + f.Selected.ToString().ToUpper();
            }
            //ghi lich su
            string pieceIcon = ""; //chen icon theo PieceType
            if (movingPiece.Color == PieceColor.White)
            {
                switch (movingPiece.Type)
                {
                    case PieceType.Pawn: pieceIcon = "♙"; break;
                    case PieceType.Knight: pieceIcon = "♘"; break;
                    case PieceType.Bishop: pieceIcon = "♗"; break;
                    case PieceType.Rook: pieceIcon = "♖"; break;
                    case PieceType.Queen: pieceIcon = "♕"; break;
                    case PieceType.King: pieceIcon = "♔"; break;
                }
            }
            else
            {
                switch (movingPiece.Type)
                {
                    case PieceType.Pawn: pieceIcon = "♟"; break;
                    case PieceType.Knight: pieceIcon = "♞"; break;
                    case PieceType.Bishop: pieceIcon = "♝"; break;
                    case PieceType.Rook: pieceIcon = "♜"; break;
                    case PieceType.Queen: pieceIcon = "♛"; break;
                    case PieceType.King: pieceIcon = "♚"; break;
                }
            }
            if (isCastle)
            {
                moveText = "O-O"; //nhap thanh
            }
            else
            {
                string sep = (targetPiece != null) ? "x" : "-";
                moveText = pieceIcon + SquareName(fromRow, fromCol) + sep + SquareName(ToRow, ToCol) + promoText;
            }
            // ghi nuoc di vao dvgHistory
            if (turn == PieceColor.White)
            {
                dgvHistory.Rows.Add(moveText, ""); //luot trang di, tao hang moi dien vao cot trang
            }
            else
            {
                //luot den di
                if (dgvHistory.Rows.Count > 0)
                {
                    int lastRow = dgvHistory.Rows.Count - 1;
                    dgvHistory.Rows[lastRow].Cells[1].Value = moveText;
                }
            }

            //Tu dong cuon xuong nuoc di moi nhat duoi cung
            if (dgvHistory.Rows.Count > 0)
            {
                dgvHistory.FirstDisplayedScrollingRowIndex = dgvHistory.Rows.Count - 1;
            }
            //am thanh

            AssetManager.GetSound("Move")?.Play();


            // doi luot
            if (turn == PieceColor.White)
            {
                turn = PieceColor.Black;
            }
            else
            {
                turn = PieceColor.White;
                moveNumber++;
            }
            //check trang thai game
            CheckGameState();
        }

        private void CheckGameState()
        {
            GameStatus status = GameRules.GetStatus(board, turn);
            if (status == GameStatus.Checkmate || status == GameStatus.Stalemate)
            {
                gameOver = true;
                selected = null;
                ColorBoard();
                ShowPieces();       // vẽ trước để thấy nước đi cuối cùng
                stopwatch.Stop();
                gameTimer.Stop();
                if (status == GameStatus.Checkmate)
                {
                    string winner = (turn == PieceColor.White) ? "Đen" : "Trắng";
                    MessageBox.Show("Chiếu hết! " + winner + " thắng.");
                }
                else
                {
                    MessageBox.Show("Hòa cờ! Bên đi không còn nước hợp lệ.");
                }
            }
        }

        private string SquareName(int row, int col)
        {
            return ((char)('a' + col)).ToString() + (8 - row);
        }

        private void UpdateTitle()
        {
            string name = (turn == PieceColor.White) ? "Trắng" : "Đen";
            Text = "Cờ vua - Lượt: " + name;
            if (GameRules.IsInCheck(board, turn))
                Text = Text + " - CHIẾU!";
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
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (GameRules.IsLegalMove(board, r, c, i, j))
                        {
                            if (board[i, j] == null)
                            {
                                cells[i, j].BackColor = Color.LightGreen; // tô màu ô có thể đi
                            }
                            else
                            {
                                cells[i, j].BackColor = Color.Red; // tô màu ô có thể ăn
                            }
                        }
                    }
                }
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

            for (int c = 0; c < 8; c++)
            {

                board[7, c] = new Piece(backRank[c], PieceColor.White); // hafng sau quan trang
                board[6, c] = new Piece(PieceType.Pawn, PieceColor.White); // hang dau quan trang

                board[0, c] = new Piece(backRank[c], PieceColor.Black);  // hang sau quan den
                board[1, c] = new Piece(PieceType.Pawn, PieceColor.Black);// hang dau quan den
            }
        }

        // bắt đầu đếm giờ
        private void StartGameTimer()
        {
            stopwatch.Start();

            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }
        // chạy mỗi giây
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan time = stopwatch.Elapsed; // tong thoi gian

            lblTime.Text = string.Format(
                "Thời gian: {0:00}:{1:00}:{2:00}",
                (int)time.TotalHours,
                time.Minutes,
                time.Seconds
            );
        }

        private void pnlBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}