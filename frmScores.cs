using System;                     
using System.Collections.Generic; 
using System.Drawing;            
using System.Linq;                
using System.Windows.Forms;       


namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmScores : Form
    {
        public frmScores()
        {
            InitializeComponent();
            CreateReplayBoard();
            LoadMatches();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmScores_Load(object sender, System.EventArgs e)
        {

        }

        private void pnlReplayBoard_Paint(object sender, PaintEventArgs e)
        {

        }
        private List<MatchRecord> matches = new List<MatchRecord>(); // Danh sách trận

        private PictureBox[,] replayCells = new PictureBox[8, 8]; // 64 ô
        private void CreateReplayBoard()
        { 
            int size = Math.Min(
                pnlReplayBoard.Width,
                pnlReplayBoard.Height
            ) / 8;

            // Duyệt 8 hàng
            for (int r = 0; r < 8; r++)
            {
                // Duyệt 8 cột
                for (int c = 0; c < 8; c++)
                {
                    PictureBox cell = new PictureBox(); // Tạo ô cờ

                    cell.Size = new Size(size, size); // Kích thước ô

                    cell.Location = new Point(
                        c * size,
                        r * size
                    ); // Vị trí ô

                    cell.BackColor = (r + c) % 2 == 0
                        ? Color.White
                        : Color.Gray;

                    cell.SizeMode = PictureBoxSizeMode.Zoom;
                    cell.Enabled = false;
                    pnlReplayBoard.Controls.Add(cell);
                    replayCells[r, c] = cell;
                    // Lưu ô vào mảng
                }
            }
        }
        private void LoadMatches()
        {
            dgvMatches.Columns.Clear(); 
            dgvMatches.Rows.Clear(); 
            // Thêm lịch sử
            dgvMatches.Columns.Add("Date", "Ngày giờ");
            dgvMatches.Columns.Add("Player1", "Player 1 (Đen)");
            dgvMatches.Columns.Add("Player2", "Player 2 (Trắng)");
            dgvMatches.Columns.Add("Winner", "Người thắng");
            dgvMatches.Columns.Add("Reason", "Kết quả");

            try
            {
                matches = MatchStorage.Load(); // dữ liệu file XML
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đọc được lịch sử: " + ex.Message);
                return;
            }

            // Đảo thứ tự trận
            matches.Reverse();

            foreach (MatchRecord match in matches)
            {
                int index = dgvMatches.Rows.Add(
                    match.PlayedAt.ToString("dd/MM/yyyy HH:mm"),
                    match.Player1,
                    match.Player2,
                    match.Winner,
                    match.Reason
                );

                dgvMatches.Rows[index].Tag = match;
            }

            // Hiển thị trận mới nhất
            if (dgvMatches.Rows.Count > 0)
            {
                dgvMatches.ClearSelection();
                dgvMatches.Rows[0].Selected = true;

                ShowSelectedMatch();
            }
            else
            {
                lblMatchInfo.Text = "Chưa có trận đấu nào.";
            }
        }
        private void ShowFinalBoard(string savedBoard)
        {
            if (string.IsNullOrEmpty(savedBoard) ||
                savedBoard.Length != 64)
                return;

            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    // Lấy ký tự đại diện
                    char symbol = savedBoard[r * 8 + c];

                    // ô trống
                    if (symbol == '.')
                    {
                        replayCells[r, c].Image = null;
                        continue;
                    }
                    PieceColor color = char.IsUpper(symbol)
                        ? PieceColor.White
                        : PieceColor.Black;

                    PieceType type; // Loại quân

                    // Xác định quân cờ từ ký tự
                    switch (char.ToUpperInvariant(symbol))
                    {
                        case 'P': type = PieceType.Pawn; break;
                        case 'R': type = PieceType.Rook; break;
                        case 'N': type = PieceType.Knight; break;
                        case 'B': type = PieceType.Bishop; break;
                        case 'Q': type = PieceType.Queen; break;
                        case 'K': type = PieceType.King; break;

                        default:
                            replayCells[r, c].Image = null;
                            continue;
                    }

                    replayCells[r, c].Image =
                        AssetManager.GetImage(type, color);
                }
            }
        }
        private void ShowSelectedMatch()
        {
            if (dgvMatches.SelectedRows.Count == 0)
                return;

            // Lấy thông tin trận
            MatchRecord match =
                dgvMatches.SelectedRows[0].Tag as MatchRecord;

            if (match == null)
                return;

            // Thông tin kết quả
            lblMatchInfo.Text =
                 $"Đen (Player 1): {match.Player1}\n" +
                 $"Trắng (Player 2): {match.Player2}\n" +
                 $"Người thắng: {match.Winner}\n" +
                 $"Kết quả: {match.Reason}\n" +
                 $"Thời gian: {TimeSpan.FromSeconds(match.DurationSeconds):hh\\:mm\\:ss}";

            // Dựng lại thế cờ 
            ShowFinalBoard(match.FinalBoard);
        }

        private void dgvMatches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvMatches_SelectionChanged(object sender, EventArgs e)
        {
            ShowSelectedMatch();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMatchInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
