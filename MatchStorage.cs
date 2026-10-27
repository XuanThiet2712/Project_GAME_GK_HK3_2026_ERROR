using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public static class MatchStorage
    {
        public static string FilePath = GetFilePath();

        private static string GetFilePath()
        {
            DirectoryInfo folder = new DirectoryInfo(Application.StartupPath);
            while (folder != null)
            {
                if (File.Exists(Path.Combine(folder.FullName,
                    "Project_GAME_GK_HK3_2026_ERROR.csproj")))
                {
                    return Path.Combine(folder.FullName, "thanhtichs.txt");
                }
                folder = folder.Parent;
            }
            return Path.Combine(Application.StartupPath, "thanhtichs.txt");
        }

        public static void EnsureFile()
        {
            if (!File.Exists(FilePath))
                File.WriteAllText(FilePath, "");
        }

        public static List<MatchRecord> Load()
        {
            List<MatchRecord> list = new List<MatchRecord>();
            EnsureFile();

            foreach (string line in File.ReadAllLines(FilePath))
            {
                string[] a = line.Split('|');
                if (a.Length != 6) continue; 

                int seconds;
                if (!int.TryParse(a[5], out seconds)) continue;

                list.Add(new MatchRecord
                {
                    Date = a[0], Player1 = a[1], Player2 = a[2],
                    Winner = a[3], Reason = a[4], Seconds = seconds
                });
            }
            return list;
        }

        public static void Save(MatchRecord match)
        {
            List<MatchRecord> list = Load(); 
            list.Add(match);                  

            List<string> lines = new List<string>();
            foreach (MatchRecord m in list)
            {
                string date = Clean(m.Date);
                string p1 = Clean(m.Player1);
                string p2 = Clean(m.Player2);
                string winner = Clean(m.Winner);
                string reason = Clean(m.Reason);
                lines.Add(date + "|" + p1 + "|" + p2 + "|" + winner + "|" + reason + "|" + m.Seconds);
            }
            File.WriteAllLines(FilePath, lines); 
        }

        private static string Clean(string text)
        {
            if (text == null)
                return "";

            text = text.Replace("|", " ");
            text = text.Replace("\r", " ");
            text = text.Replace("\n", " ");

            return text;
        }
    }
}
