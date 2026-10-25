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
        private static Dictionary<string, SoundPlayer> sounds = new Dictionary<string, SoundPlayer>();

        public static string ImageFolder { get; set; } = @"../../images/";

        //public static string SoundFolder { get; set; } = @"../../sounds/";
        //public static bool SoundEnabled { get; set; } = true;
        public static string SoundFolder { get; set; } = @"../../sound/";
        public static bool SoundEnabled { get; set; } = true;


        public static Image GetImage(PieceType ptype, PieceColor pcolor)
        {
            string name = pcolor.ToString().ToUpper() + ptype.ToString().ToUpper();
            if (!images.ContainsKey(name))
            {
                //string path = Path.Combine(Application.StartupPath, "Images", name + ".png");
                try
                {
                    images[name] = Image.FromFile(ImageFolder + name + ".png");
                }

                catch (Exception)
                {
                    MessageBox.Show("Image file not found: " + name + ".png");
                    images[name] = null;
                }
            }

            return images[name];
        }

        // 1 ham lay am thanh
        public static SoundPlayer GetSound(string soundName)
        {
            if (!sounds.ContainsKey(soundName))
            {
                try
                {
                    string path = SoundFolder + soundName + ".wav";
                    //if (!File.Exists(path))
                    //{
                    //    // Thử tìm theo đường dẫn StartupPath nếu không thấy ở đường dẫn tương đối
                    //    path = Path.Combine(Application.StartupPath, "sounds", soundName + ".wav");
                    //}

                    if (File.Exists(path))
                    {
                        sounds[soundName] = new SoundPlayer(path);
                    }

                    else{
                        MessageBox.Show("Sound file not found: " + soundName + ".wav");
                        sounds[soundName] = null;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error loading sound file: " + soundName + ".wav");
                    sounds[soundName] = null;
                }
            }
            return sounds[soundName];
        }

    }
}