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
            if(e.KeyCode == Keys.Left && !directionPressed)
            {
                MovePlayerAnimation("left");
            }
            if (e.KeyCode == Keys.Right && !directionPressed)
            {
                MovePlayerAnimation("right");
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.X)
            {
                if(bg_number < background_images.Count - 1)
                {
                    bg_number++;
                }
                else
                {
                    bg_number = 0;
                }
                background = Image.FromFile(background_images[bg_number]);
                backgroundPosition = 0;
                drumMoveTimer = 0;
                drumX = 450;
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                goLeft = false;
                goRight = false;
                directionPressed = false;
                ResetPlayer();
            }
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(background, new Point(backgroundPosition , 0));
            e.Graphics.DrawImage(player, new Point(playerX, playerY));
            e.Graphics.DrawImage(drum, new Point(drumX, drumY));
        }



        private void GameTimerEvent(object sender, EventArgs e)
        {
            this.Invalidate();
            ImageAnimator.UpdateFrames();
            MovePlayerAndBackground();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {

        }

        private void SetUpForm() 
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            background_images = Directory.GetFiles(@"../../Assets/background").ToList();
            background = Image.FromFile(background_images[bg_number]);
            player = Image.FromFile(@"../../Assets/standing.gif");
            drum = Image.FromFile(@"../../Assets/drum.png");
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
            if (goLeft)
            {
                if (playerX > 0)
                {
                    playerX -= 6;
                }
            }
            if (goRight)
            {
                if(playerX + player.Width < this.ClientSize.Width)
                {
                    playerX += 6;
                }
            }

        }

        private void MovePlayerAnimation(string direction)
        {
            if(direction == "left")
            {
                goLeft = true;
                
                player = Image.FromFile(@"../../Assets/backwards.gif");
            }
            else if (direction == "right")
            {
                goRight = true;
                
                player = Image.FromFile(@"../../Assets/forwards.gif");
            }

            directionPressed = true;
            playerAction = false;
            SetUpAnimation();
        }

        private void ResetPlayer()
        {
            player = Image.FromFile(@"../../Assets/standing.gif");
            SetUpAnimation();
            num = 0;
            playerAction = false;
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
            return true;
        }
    }
}
