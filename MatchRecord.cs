using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    // Class chứa thông tin của một trận đấu
    public class MatchRecord
    {
        public DateTime PlayedAt { get; set; }
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public string Winner { get; set; }
        public string Reason { get; set; }
        public int DurationSeconds { get; set; }
        public string FinalBoard { get; set; }
        // Chuỗi 64 ký tự biểu diễn bàn cờ cuối trận
    }
}