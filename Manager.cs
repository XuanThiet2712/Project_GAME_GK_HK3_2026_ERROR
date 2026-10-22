using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public class Manager
    {
        private static Dictionary<string, Image> images = new Dictionary<string, Image>();

        public static Image GetImage(PieceType ptype , PieceColor pcolor)
        {
            string name = pcolor.ToString().ToUpper() + ptype.ToString().ToUpper();
            if (!images.ContainsKey(name))
            {
                //string path = Path.Combine(Application.StartupPath, "Images", name + ".png");
                try
                {
                    images[name] = Image.FromFile(@"../../images/" + name + ".png");
                }

                catch (FileNotFoundException)
                {
                    MessageBox.Show("Image file not found: " + name + ".png");
                    return null;
                }
            }
            return images[name];
        }

        // 1 ham lay am thanh


    }
}
