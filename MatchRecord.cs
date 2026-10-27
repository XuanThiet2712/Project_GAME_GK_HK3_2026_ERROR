using System;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public class MatchRecord
    {
        public string Date { get; set; }      // Ngày giờ kết thúc
        public string Player1 { get; set; }   // Người chơi Đen
        public string Player2 { get; set; }   // Người chơi Trắng
        public string Winner { get; set; }    // Tên người thắng hoặc Hòa
        public string Reason { get; set; }    // Chiếu hết / Hết giờ / Hòa
        public int Seconds { get; set; }      // Thời lượng trận
    }
}
