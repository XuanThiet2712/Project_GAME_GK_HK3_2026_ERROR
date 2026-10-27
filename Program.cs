using System;
using System.Windows.Forms;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                MatchStorage.EnsureFile(); // Tạo thanhtichs.txt ngay khi mở game
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tạo được file thành tích: " + ex.Message);
            }
            Application.Run(new frmMenu());
        }
    }
}
