using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmGame: Form
    {
        //khai bao animation
        Image player;
        Image background;


        //vector player drum fireball
        int playerX = 0;
        int playerY = 250;

        int actionStrength = 0;
        int endFrame = 0;
        int backgroundPosition = 0;
        int totalFrame = 0;
        int bg_number = 0;

        float num;

        public frmGame()
        {
            InitializeComponent();
            SetUpForm();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(player, new Point(playerX, playerY));
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            this.Invalidate();
            ImageAnimator.UpdateFrames();
        }

        private void SetUpForm()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            player = Image.FromFile(@"../../Sprites/Nor/Idle_v1.gif");
            SetUpAnimation();
        }

        private void SetUpAnimation()
        {
            ImageAnimator.Animate(player, this.OnFrameChangeHandler);
            FrameDimension dimension = new FrameDimension(player.FrameDimensionsList[0]);
            totalFrame = player.GetFrameCount(dimension);
            endFrame = totalFrame - 3;
        }

        private void OnFrameChangeHandler(object sender, EventArgs e)
        {
            this.Invalidate();
        }

      
    }
}
