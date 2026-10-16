namespace Project_GAME_GK_HK3_2026_ERROR
{
    partial class frmGameDM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLeft = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(12, 407);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(83, 56);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "<-";
            this.btnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(101, 407);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(83, 56);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = "->";
            this.btnRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(450, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 56);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(556, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 56);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(658, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 56);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // frmGameDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 488);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGameDM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "frmGameDM";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btnLeft;
        private System.Windows.Forms.Label btnRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}