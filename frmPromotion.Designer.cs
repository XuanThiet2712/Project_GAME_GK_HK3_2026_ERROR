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
            this.btnQueen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueen.Location = new System.Drawing.Point(0, 0);
            this.btnQueen.Name = "btnQueen";
            this.btnQueen.Size = new System.Drawing.Size(161, 76);
            this.btnQueen.TabIndex = 0;
            this.btnQueen.Text = "QUEEN";
            this.btnQueen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQueen.UseVisualStyleBackColor = true;
            this.btnQueen.Click += new System.EventHandler(this.btnQueen_Click);
            this.btnQueen.MouseEnter += new System.EventHandler(this.btnQueen_Click);
            // 
            // btnKnight
            // 
            this.btnKnight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKnight.Location = new System.Drawing.Point(0, 98);
            this.btnKnight.Name = "btnKnight";
            this.btnKnight.Size = new System.Drawing.Size(161, 65);
            this.btnKnight.TabIndex = 1;
            this.btnKnight.Text = "KNIGHT";
            this.btnKnight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKnight.UseVisualStyleBackColor = true;
            this.btnKnight.Click += new System.EventHandler(this.btnKnight_Click);
            this.btnKnight.MouseEnter += new System.EventHandler(this.btnKnight_Click);
            // 
            // btnRook
            // 
            this.btnRook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRook.Location = new System.Drawing.Point(0, 289);
            this.btnRook.Name = "btnRook";
            this.btnRook.Size = new System.Drawing.Size(161, 76);
            this.btnRook.TabIndex = 2;
            this.btnRook.Text = "ROOK";
            this.btnRook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRook.UseVisualStyleBackColor = true;
            this.btnRook.Click += new System.EventHandler(this.btnRook_Click);
            this.btnRook.MouseEnter += new System.EventHandler(this.btnRook_Click);
            // 
            // btnBishop
            // 
            this.btnBishop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBishop.Location = new System.Drawing.Point(0, 191);
            this.btnBishop.Name = "btnBishop";
            this.btnBishop.Size = new System.Drawing.Size(161, 71);
            this.btnBishop.TabIndex = 3;
            this.btnBishop.Text = "BISHOP";
            this.btnBishop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBishop.UseVisualStyleBackColor = true;
            this.btnBishop.Click += new System.EventHandler(this.btnBishop_Click);
            this.btnBishop.MouseEnter += new System.EventHandler(this.btnBishop_Click);
            // 
            // picQueen
            // 
            this.picQueen.Location = new System.Drawing.Point(201, 24);
            this.picQueen.Name = "picQueen";
            this.picQueen.Size = new System.Drawing.Size(135, 169);
            this.picQueen.TabIndex = 4;
            this.picQueen.TabStop = false;
            this.picQueen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 360);
            this.ControlBox = false;
            this.Controls.Add(this.picQueen);
            this.Controls.Add(this.btnBishop);
            this.Controls.Add(this.btnRook);
            this.Controls.Add(this.btnKnight);
            this.Controls.Add(this.btnQueen);
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