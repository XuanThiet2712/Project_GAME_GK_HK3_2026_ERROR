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
            this.SuspendLayout();
            // 
            // btnQueen
            // 
            this.btnQueen.Location = new System.Drawing.Point(0, 0);
            this.btnQueen.Name = "btnQueen";
            this.btnQueen.Size = new System.Drawing.Size(200, 110);
            this.btnQueen.TabIndex = 0;
            this.btnQueen.Text = "QUEEN";
            this.btnQueen.UseVisualStyleBackColor = true;
            this.btnQueen.Click += new System.EventHandler(this.btnQueen_Click);
            // 
            // btnKnight
            // 
            this.btnKnight.Location = new System.Drawing.Point(0, 116);
            this.btnKnight.Name = "btnKnight";
            this.btnKnight.Size = new System.Drawing.Size(200, 110);
            this.btnKnight.TabIndex = 1;
            this.btnKnight.Text = "KNIGHT";
            this.btnKnight.UseVisualStyleBackColor = true;
            this.btnKnight.Click += new System.EventHandler(this.btnKnight_Click);
            // 
            // btnRook
            // 
            this.btnRook.Location = new System.Drawing.Point(238, 128);
            this.btnRook.Name = "btnRook";
            this.btnRook.Size = new System.Drawing.Size(200, 110);
            this.btnRook.TabIndex = 2;
            this.btnRook.Text = "ROOK";
            this.btnRook.UseVisualStyleBackColor = true;
            this.btnRook.Click += new System.EventHandler(this.btnRook_Click);
            // 
            // btnBishop
            // 
            this.btnBishop.Location = new System.Drawing.Point(238, 12);
            this.btnBishop.Name = "btnBishop";
            this.btnBishop.Size = new System.Drawing.Size(200, 110);
            this.btnBishop.TabIndex = 3;
            this.btnBishop.Text = "BISHOP";
            this.btnBishop.UseVisualStyleBackColor = true;
            this.btnBishop.Click += new System.EventHandler(this.btnBishop_Click);
            // 
            // frmPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 273);
            this.ControlBox = false;
            this.Controls.Add(this.btnBishop);
            this.Controls.Add(this.btnRook);
            this.Controls.Add(this.btnKnight);
            this.Controls.Add(this.btnQueen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPromotion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPromotion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQueen;
        private System.Windows.Forms.Button btnKnight;
        private System.Windows.Forms.Button btnRook;
        private System.Windows.Forms.Button btnBishop;
    }
}