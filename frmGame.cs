using Project_GAME_GK_HK3_2026_ERROR.Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmGame : Form
    {
        private Timer gameTimer = new Timer();
        private string player1Name = "";
        private string player2Name = "";
        private Stopwatch stopwatch = new Stopwatch();
        PictureBox[,] cells = new PictureBox[8, 8];   //khai bao mang 2 chieu 64 ô
        Piece[,] board = new Piece[8, 8]; // khai bao quan co 

        //Dictionary<string, Image> images = new Dictionary<string, Image>();   // khai bao anh co

        Point? selected = null;   // x hang , y cot, null ch chon o nao
        PieceColor turn = PieceColor.White;
        int moveNumber = 1; // so nuoc dang di
        bool gameOver = false; // kiem tra game ket thuc
        TimeSpan timeLimit;  // Thời gian tối đa của mỗi bên

        // đo thời gian đã dùng
        Stopwatch whiteWatch = new Stopwatch();
        Stopwatch blackWatch = new Stopwatch();

        // Timer cập nhật
        System.Windows.Forms.Timer chessTimer = new System.Windows.Forms.Timer();
        public frmGame() : this(10) { } // Giữ khả năng mở bằng Designer và mặc định 10 phút

        public frmGame(int minutes)
        {
            InitializeComponent();
            CreateCells();
            ColorBoard();
            SetUpBoard();
            ShowPieces(); // hiện quân
            UpdateTitle();
            timeLimit = TimeSpan.FromMinutes(minutes);   // Thời gian được chọn từ frmTime

            // Cập nhật timer
            chessTimer.Interval = 100;
            chessTimer.Tick += ChessTimer_Tick;
            whiteWatch.Start();
            chessTimer.Start();
            UpdateClockDisplay();
            this.FormClosed += (sender, e) => { gameTimer.Dispose(); chessTimer.Dispose(); };
        }
        public frmGame(int minutes, string player1, string player2)
           : this(minutes) // khoi tao constructor cu
        {
            player1Name = player1; 
            player2Name = player2; 
            lblPlayerBlack.Text = player1Name; 
            lblPlayerWhite.Text = player2Name;
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
        private string CaptureFinalBoard()
        {
            // Sử dụng StringBuilder để ghép các ký tự
            System.Text.StringBuilder result =
                new System.Text.StringBuilder();

            // Duyệt hàng
            for (int r = 0; r < 8; r++)
            {
                // Duyệt từng cột
                for (int c = 0; c < 8; c++)
                {
                    Piece piece = board[r, c]; // Lấy quân cờ tại ô

                    if (piece == null)
                    {
                        result.Append('.'); // Ô trống
                        continue;
                    }

                    char symbol = '.'; // Ký tự mặc định

                    // Chuyển quân thành ký tự
                    switch (piece.Type)
                    {
                        case PieceType.Pawn: symbol = 'P'; break;
                        case PieceType.Rook: symbol = 'R'; break;
                        case PieceType.Knight: symbol = 'N'; break;
                        case PieceType.Bishop: symbol = 'B'; break;
                        case PieceType.Queen: symbol = 'Q'; break;
                        case PieceType.King: symbol = 'K'; break;
                    }

                    // quân đen la chữ thường
                    if (piece.Color == PieceColor.Black)
                        symbol = char.ToLowerInvariant(symbol);

                    result.Append(symbol); 
                }
            }

            return result.ToString();
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
                AssetManager.GetSound("chienthang")?.Play();
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
            if (CheckTimeout())
                return;

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

            //lich su nuoc di 
            string pieceIcon = GetPieceIcon(movingPiece.Type, movingPiece.Color);

            if (isCastle)
            {
                moveText = "O-O"; // =nhap thanh
            }
            else
            {
                if (targetPiece != null)
                {
                    string targetIcon = GetPieceIcon(targetPiece.Type, targetPiece.Color); // Icon quân bị ăn
                    //nuoc di co an quan: icon quan di + o hien tai + x + o den + icon quan an
                    moveText = pieceIcon + SquareName(fromRow, fromCol) + "x" + SquareName(ToRow, ToCol) + targetIcon + promoText;
                }
                else
                {
                    //nuoc di khong an quan
                    moveText = pieceIcon + SquareName(fromRow, fromCol) + "-" + SquareName(ToRow, ToCol) + promoText;
                }
            }

            //ghi nuoc di vao dgv
            if (turn == PieceColor.White)
            {
                dgvHistory.Rows.Add(moveText, ""); //luot trang di tao hang moi
            }
            else
            {
                if (dgvHistory.Rows.Count > 0)
                {
                    int lastRow = dgvHistory.Rows.Count - 1;
                    dgvHistory.Rows[lastRow].Cells[1].Value = moveText; //luot den di dien vao cot 2
                }
            }

            //cuon danh sach xuong
            if (dgvHistory.Rows.Count > 0)
            {
                dgvHistory.FirstDisplayedScrollingRowIndex = dgvHistory.Rows.Count - 1;
            }

            //am thanh
            AssetManager.GetSound("Move")?.Play();
            // dung dong ho
            whiteWatch.Stop();
            blackWatch.Stop();


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

            // bat dau dong ho ben kia
            if (turn == PieceColor.White)
                whiteWatch.Start();
            else
                blackWatch.Start();

            //check trang thai game
            CheckGameState();

            // cap nhat giao dien
            UpdateClockDisplay();
            
        }
        private string GetPieceIcon(PieceType type, PieceColor color)
        {
            if (color == PieceColor.White)
            {
                switch (type)
                {
                    case PieceType.Pawn: return "♙";
                    case PieceType.Knight: return "♘";
                    case PieceType.Bishop: return "♗";
                    case PieceType.Rook: return "♖";
                    case PieceType.Queen: return "♕";
                    case PieceType.King: return "♔";
                    default: return "";
                }
            }
            else
            {
                switch (type)
                {
                    case PieceType.Pawn: return "♟";
                    case PieceType.Knight: return "♞";
                    case PieceType.Bishop: return "♝";
                    case PieceType.Rook: return "♜";
                    case PieceType.Queen: return "♛";
                    case PieceType.King: return "♚";
                    default: return "";
                }
            }

        }
        private void CheckGameState()
        {
            GameStatus status = GameRules.GetStatus(board, turn);
            if (status != GameStatus.Checkmate && status != GameStatus.Stalemate)
                return; // Chưa kết thúc ván

            gameOver = true;
            selected = null;
            StopClocks(); // Dừng cả hai đồng hồ cờ và đồng hồ tổng trận
            ColorBoard();
            ShowPieces(); // Giữ nước đi cuối cùng trên bàn cờ

            string message;
            if (status == GameStatus.Checkmate)
            {
                string winner = turn == PieceColor.White ? "Đen" : "Trắng";
                string winnerName = turn == PieceColor.White ? player1Name : player2Name;
                SaveFinishedMatch(winnerName, "Chiếu hết");
                AssetManager.GetSound("chienthang")?.Play();
                message = $"Chiếu hết! Bên {winner} thắng.";
            }
            else
            {
                SaveFinishedMatch("Hòa", "Hòa cờ");
                message = "Hòa cờ! Bên tới lượt không còn nước đi hợp lệ.";
            }

            if (MessageBox.Show(message + "\n\nBạn có muốn chơi lại không?",
                "Kết Thúc Ván Đấu", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
                RestartGame();
            else
                this.Close();
        }

        private void RestartGame()
        {
           
            board = new Piece[8, 8];
            selected = null;
            turn = PieceColor.White;
            moveNumber = 1;
            gameOver = false;
            dgvHistory.Rows.Clear();           //xoa lich su nuoc di
            if (picSelectedPiece != null)        //xoa anh quan co dang hien thi
                picSelectedPiece.Image = null;

            SetUpBoard();
            ColorBoard();
            ShowPieces();
            UpdateTitle();
            // Reset thời gian về ban đầu
            whiteWatch.Reset();
            blackWatch.Reset();
            whiteWatch.Start();
            chessTimer.Start();

            UpdateClockDisplay();
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

        private void pnlBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBlackTime_Click(object sender, EventArgs e)
        {

        }
        private TimeSpan GetRemainingTime(Stopwatch watch) // time con lai
        {
            TimeSpan remaining = timeLimit - watch.Elapsed;

            if (remaining < TimeSpan.Zero)
                return TimeSpan.Zero;

            return remaining;
        }
        private string FormatTime(TimeSpan time) // phut -> giay
        {
            int totalSeconds =
                (int)Math.Ceiling(time.TotalSeconds);

            return string.Format(
                "{0:00}:{1:00}",
                totalSeconds / 60,
                totalSeconds % 60
            );
        }
        private void UpdateClockDisplay() // mau
        {
            lblWhiteTime.Text = FormatTime(
                GetRemainingTime(whiteWatch)
            );

            lblBlackTime.Text = FormatTime(
                GetRemainingTime(blackWatch)
            );

            lblWhiteTime.ForeColor =
                turn == PieceColor.White
                ? Color.Green
                : Color.Black;

            lblBlackTime.ForeColor =
                turn == PieceColor.Black
                ? Color.Green
                : Color.Black;
        }
        private void StopClocks()
        {
            whiteWatch.Stop();
            blackWatch.Stop();
            chessTimer.Stop();
            stopwatch.Stop(); // Dừng thời gian trận khi kết thúc
            gameTimer.Stop();
        }
        private void EndGameByTime(string winner) // het gio = thua
        {
            if (gameOver)
                return;

            gameOver = true;
            StopClocks();
            string winnerName = winner == "Trắng" ? player1Name : player2Name;

            selected = null;
            picSelectedPiece.Image = null;

            UpdateClockDisplay();
            ColorBoard();

            DialogResult result = MessageBox.Show(
                $"Hết giờ! Bên {winner} thắng.\n\nBạn có muốn chơi lại không?",
                "Kết thúc ván đấu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.Yes)
                RestartGame();
            else
                this.Close();
        }
        private bool CheckTimeout() // ktra time
        {
            if (gameOver)
                return true;

            if (turn == PieceColor.White &&
                GetRemainingTime(whiteWatch) == TimeSpan.Zero)
            {
                EndGameByTime("Đen");
                return true;
            }

            if (turn == PieceColor.Black &&
                GetRemainingTime(blackWatch) == TimeSpan.Zero)
            {
                EndGameByTime("Trắng");
                return true;
            }

            return false;
        }
        private void ChessTimer_Tick(object sender, EventArgs e) // timer tick
        {
            if (gameOver)
                return;

            UpdateClockDisplay();
            CheckTimeout();
        }
        // thông tin dữ liệu
        private void SaveFinishedMatch(string winner, string reason)
        {
            MatchRecord match = new MatchRecord
            {
                PlayedAt = DateTime.Now,       
                Player1 = player1Name,       
                Player2 = player2Name,        
                Winner = winner,               
                Reason = reason,
                DurationSeconds = (int)(
                    whiteWatch.Elapsed.TotalSeconds + // Thời gian Trắng đã dùng
                    blackWatch.Elapsed.TotalSeconds   // Thời gian Đen đã dùng
                ),
                FinalBoard = CaptureFinalBoard() 
            };

            try
            {
                MatchStorage.Save(match); // Lưu vào file XML
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể lưu lịch sử: " + ex.Message,
                    "Lỗi lưu dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
