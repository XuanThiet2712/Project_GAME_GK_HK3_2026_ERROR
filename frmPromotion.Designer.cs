namespace Project_GAME_GK_HK3_2026_ERROR
{
    partial class frmPromotion
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
            this.btnQueen = new System.Windows.Forms.Button();
            this.btnKnight = new System.Windows.Forms.Button();
            this.btnRook = new System.Windows.Forms.Button();
            this.btnBishop = new System.Windows.Forms.Button();
            this.picQueen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQueen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQueen
            // 
            this.btnQueen.AllowDrop = true;
            this.btnQueen.BackColor = System.Drawing.Color.Goldenrod;
            this.btnQueen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQueen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueen.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQueen.Location = new System.Drawing.Point(25, 12);
            this.btnQueen.Name = "btnQueen";
            this.btnQueen.Size = new System.Drawing.Size(150, 60);
            this.btnQueen.TabIndex = 0;
            this.btnQueen.Text = "QUEEN";
            this.btnQueen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQueen.UseVisualStyleBackColor = false;
            this.btnQueen.Click += new System.EventHandler(this.btnQueen_Click);
            this.btnQueen.MouseEnter += new System.EventHandler(this.btnQueen_MouseEnter);
            // 
            // btnKnight
            // 
            this.btnKnight.BackColor = System.Drawing.Color.Goldenrod;
            this.btnKnight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKnight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKnight.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKnight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKnight.Location = new System.Drawing.Point(25, 89);
            this.btnKnight.Name = "btnKnight";
            this.btnKnight.Size = new System.Drawing.Size(150, 60);
            this.btnKnight.TabIndex = 1;
            this.btnKnight.Text = "KNIGHT";
            this.btnKnight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKnight.UseVisualStyleBackColor = false;
            this.btnKnight.Click += new System.EventHandler(this.btnKnight_Click);
            this.btnKnight.MouseEnter += new System.EventHandler(this.btnKnight_MouseEnter);
            // 
            // btnRook
            // 
            this.btnRook.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRook.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRook.Location = new System.Drawing.Point(25, 244);
            this.btnRook.Name = "btnRook";
            this.btnRook.Size = new System.Drawing.Size(150, 60);
            this.btnRook.TabIndex = 2;
            this.btnRook.Text = "ROOK";
            this.btnRook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRook.UseVisualStyleBackColor = false;
            this.btnRook.Click += new System.EventHandler(this.btnRook_Click);
            this.btnRook.MouseEnter += new System.EventHandler(this.btnRook_MouseEnter);
            // 
            // btnBishop
            // 
            this.btnBishop.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBishop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBishop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBishop.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBishop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBishop.Location = new System.Drawing.Point(25, 165);
            this.btnBishop.Name = "btnBishop";
            this.btnBishop.Size = new System.Drawing.Size(150, 60);
            this.btnBishop.TabIndex = 3;
            this.btnBishop.Text = "BISHOP";
            this.btnBishop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBishop.UseVisualStyleBackColor = false;
            this.btnBishop.Click += new System.EventHandler(this.btnBishop_Click);
            this.btnBishop.MouseEnter += new System.EventHandler(this.btnBishop_MouseEnter);
            // 
            // picQueen
            // 
            this.picQueen.BackColor = System.Drawing.Color.Goldenrod;
            this.picQueen.Location = new System.Drawing.Point(263, 89);
            this.picQueen.Name = "picQueen";
            this.picQueen.Size = new System.Drawing.Size(135, 136);
            this.picQueen.TabIndex = 4;
            this.picQueen.TabStop = false;
            // 
            // frmPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_GAME_GK_HK3_2026_ERROR.Properties.Resources.promotion1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 360);
            this.ControlBox = false;
            this.Controls.Add(this.picQueen);
            this.Controls.Add(this.btnBishop);
            this.Controls.Add(this.btnRook);
            this.Controls.Add(this.btnKnight);
            this.Controls.Add(this.btnQueen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPromotion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPromotion";
            this.Load += new System.EventHandler(this.frmPromotion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQueen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQueen;
        private System.Windows.Forms.Button btnKnight;
        private System.Windows.Forms.Button btnRook;
        private System.Windows.Forms.Button btnBishop;
        private System.Windows.Forms.PictureBox picQueen;
    }
}