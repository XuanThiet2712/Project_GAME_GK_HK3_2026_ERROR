using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public static class MatchStorage
    {
        private const int MaxMatches = 5;

        // Thư mục dữ liệu riêng 
        private static readonly string Folder =
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "ChessGame");

        // Đường dẫn file lưu lịch sử
        private static readonly string FilePath =
            Path.Combine(Folder, "matches.xml");

        // Đọc danh sách trận đã lưu
        public static List<MatchRecord> Load()
        {
            if (!File.Exists(FilePath))
                return new List<MatchRecord>();

            // chuyển XML thành danh sách 
            XmlSerializer serializer =
                new XmlSerializer(typeof(List<MatchRecord>));

            // Mở file để đọc
            using (FileStream stream =
                new FileStream(FilePath, FileMode.Open, FileAccess.Read))
            {
                return (List<MatchRecord>)serializer.Deserialize(stream);
            }
        }

        // Lưu thêm một trận đấu mới
        public static void Save(MatchRecord match)
        {
            // Đọc danh sách
            List<MatchRecord> matches = Load();
            matches.Add(match);
            if (matches.Count > MaxMatches)
            {
                matches = matches
                    .Skip(matches.Count - MaxMatches)
                    .ToList();
            }

            Directory.CreateDirectory(Folder);

            // chuyển danh sách thành XML
            XmlSerializer serializer =
                new XmlSerializer(typeof(List<MatchRecord>));
            string tempFile = FilePath + ".tmp";

            using (FileStream stream =
                new FileStream(tempFile, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(stream, matches);
                // Ghi toàn bộ danh sách mới xuống file tạm
            }

            if (File.Exists(FilePath))
                File.Replace(tempFile, FilePath, null);
            else
                File.Move(tempFile, FilePath);
        }
    }
}