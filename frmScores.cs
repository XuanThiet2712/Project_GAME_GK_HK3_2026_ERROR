using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmScores : Form
    {
        public frmScores()
        {
            InitializeComponent();
            LoadMatches();
        }

        private void LoadMatches()
        {
            dgvMatches.Rows.Clear();
            try
            {
                List<MatchRecord> list = MatchStorage.Load();
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    MatchRecord m = list[i];
                    TimeSpan t = TimeSpan.FromSeconds(m.Seconds);
                    string duration = string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
                    dgvMatches.Rows.Add(m.Date, m.Player1, m.Player2, m.Winner, m.Reason, duration);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đọc được lịch sử: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmScores_Load(object sender, EventArgs e)
        {

        }
    }
}
