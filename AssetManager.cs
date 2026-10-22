using Project_GAME_GK_HK3_2026_ERROR.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public static class AssetManager
    {
        private static Dictionary<string, Image> images = new Dictionary<string, Image>();
        private static SoundPlayer soundMove = new SoundPlayer(Resources.Move);

        public static string ImageFolder { get; set; } = Path.Combine(Application.StartupPath, "images");

        public static Image GetImage(PieceType ptype, PieceColor pcolor)
        {
            string name = pcolor.ToString().ToUpper() + ptype.ToString().ToUpper();

            if (!images.ContainsKey(name))
            {
                string fileName = name + ".png";
                string primaryPath = Path.Combine(ImageFolder, fileName);
                string fallbackPath = Path.Combine(Application.StartupPath, @"../../images/", fileName);

                string finalPath = File.Exists(primaryPath) ? primaryPath : (File.Exists(fallbackPath) ? fallbackPath : null);

                if (finalPath != null)
                {
                    try
                    {
                        images[name] = Image.FromFile(finalPath);
                    }
                    catch
                    {
                        images[name] = null;
                    }
                }
                else
                {
                    MessageBox.Show("Khong tim thấy file ảnh: " + fileName, "Lỗi hình ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    images[name] = null;
                }
            }
            return images[name];
        }

        public static void PlayMove()
        {
            try
            {
                soundMove.Play();
            }
            catch { }
        }
    }
}