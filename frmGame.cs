using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Project_GAME_GK_HK3_2026_ERROR
{
    public partial class frmGame : Form
    {
        //khai bao animation
        Image player;
        Image background;
        Image drum;
        Image fireball;

        //vector player drum fireball
        int playerX = 0;
        int playerY = 300;

        int drumX = 450;
        int drumY = 355;

        int fireballX, fireballY;

        int drumMoveTimer = 0;
        int actionStrength = 0;
        int endFrame = 0;
        int backgroundPosition = 0;
        int totalFrame = 0;
        int bg_number = 0;

        float num;

        bool goLeft, goRight;
        bool directionPressed;
        bool playerAction;
        bool shotFireBall;

        List<string> background_images = new List<string>();

        public frmGame()
        {
            InitializeComponent();
            SetUpForm();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {

        }



        private void GameTimerEvent(object sender, EventArgs e)
        {

        }

        private void frmGame_Load(object sender, EventArgs e)
        {

        }

        private void SetUpForm() 
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            background_images = Directory.GetFiles("background", "*.jpg").ToList();
            background = Image.FromFile(background_images[bg_number]);
            player = Image.FromFile("player.png");
            drum = Image.FromFile("drum.png");
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

        private void MovePlayerAndBackground()
        {

        }

        private void MovePlayerAnimation(string direction)
        {
        }

        private void ResetPlayer()
        {

        }

        private void SetPlayerAction(string animation, int strength)
        {
        }

        private void ShootFireBall()
        {
        }

        private void CheckPunchHit()
        {
        }

        private void CheckFireBallHit()
        {
        }

        private bool DetectCollision()
        {
            return false;
        }
    }
}
