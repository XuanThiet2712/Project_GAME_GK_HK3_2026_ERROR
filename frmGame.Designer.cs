namespace Project_GAME_GK_HK3_2026_ERROR
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblPlayerWhite = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPlayerBlack = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.colWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picSelectedPiece = new System.Windows.Forms.PictureBox();
            this.lblBlackTime = new System.Windows.Forms.Label();
            this.lblWhiteTime = new System.Windows.Forms.Label();
            this.timerChess = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnGameMoi = new System.Windows.Forms.Button();
            this.chkAmthanh = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(27, 56);
            this.pnlBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(528, 539);
            this.pnlBoard.TabIndex = 0;
            this.pnlBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBoard_Paint);
            // 
            // lblPlayerWhite
            // 
            this.lblPlayerWhite.AutoSize = true;
            this.lblPlayerWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWhite.Location = new System.Drawing.Point(24, 615);
            this.lblPlayerWhite.Name = "lblPlayerWhite";
            this.lblPlayerWhite.Size = new System.Drawing.Size(88, 20);
            this.lblPlayerWhite.TabIndex = 3;
            this.lblPlayerWhite.Text = "Player 2: ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(750, 263);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(9, 7);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblPlayerBlack
            // 
            this.lblPlayerBlack.AutoSize = true;
            this.lblPlayerBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerBlack.Location = new System.Drawing.Point(24, 21);
            this.lblPlayerBlack.Name = "lblPlayerBlack";
            this.lblPlayerBlack.Size = new System.Drawing.Size(88, 20);
            this.lblPlayerBlack.TabIndex = 0;
            this.lblPlayerBlack.Text = "Player 1: ";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeColumns = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWhite,
            this.colBlack});
            this.dgvHistory.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHistory.Location = new System.Drawing.Point(630, 75);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(270, 212);
            this.dgvHistory.TabIndex = 7;
            // 
            // colWhite
            // 
            this.colWhite.HeaderText = "White";
            this.colWhite.MinimumWidth = 6;
            this.colWhite.Name = "colWhite";
            this.colWhite.ReadOnly = true;
            // 
            // colBlack
            // 
            this.colBlack.HeaderText = "Black";
            this.colBlack.MinimumWidth = 6;
            this.colBlack.Name = "colBlack";
            this.colBlack.ReadOnly = true;
            // 
            // picSelectedPiece
            // 
            this.picSelectedPiece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelectedPiece.Location = new System.Drawing.Point(704, 318);
            this.picSelectedPiece.Name = "picSelectedPiece";
            this.picSelectedPiece.Size = new System.Drawing.Size(134, 130);
            this.picSelectedPiece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSelectedPiece.TabIndex = 8;
            this.picSelectedPiece.TabStop = false;
            // 
            // lblBlackTime
            // 
            this.lblBlackTime.AutoSize = true;
            this.lblBlackTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackTime.Location = new System.Drawing.Point(512, 22);
            this.lblBlackTime.Name = "lblBlackTime";
            this.lblBlackTime.Size = new System.Drawing.Size(55, 20);
            this.lblBlackTime.TabIndex = 9;
            this.lblBlackTime.Text = "10:00";
            this.lblBlackTime.Click += new System.EventHandler(this.lblBlackTime_Click);
            // 
            // lblWhiteTime
            // 
            this.lblWhiteTime.AutoSize = true;
            this.lblWhiteTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWhiteTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhiteTime.Location = new System.Drawing.Point(512, 616);
            this.lblWhiteTime.Name = "lblWhiteTime";
            this.lblWhiteTime.Size = new System.Drawing.Size(55, 20);
            this.lblWhiteTime.TabIndex = 10;
            this.lblWhiteTime.Text = "10:00";
            // 
            // timerChess
            // 
            this.timerChess.Interval = 1000;
            this.timerChess.Tick += new System.EventHandler(this.timerChess_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(630, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Đầu Hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGameMoi
            // 
            this.btnGameMoi.BackColor = System.Drawing.Color.DarkGray;
            this.btnGameMoi.Location = new System.Drawing.Point(790, 500);
            this.btnGameMoi.Name = "btnGameMoi";
            this.btnGameMoi.Size = new System.Drawing.Size(110, 46);
            this.btnGameMoi.TabIndex = 12;
            this.btnGameMoi.Text = "Game mới";
            this.btnGameMoi.UseVisualStyleBackColor = false;
            this.btnGameMoi.Click += new System.EventHandler(this.btnGameMoi_Click);
            // 
            // chkAmthanh
            // 
            this.chkAmthanh.AllowDrop = true;
            this.chkAmthanh.AutoSize = true;
            this.chkAmthanh.Checked = true;
            this.chkAmthanh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAmthanh.Location = new System.Drawing.Point(822, 21);
            this.chkAmthanh.Name = "chkAmthanh";
            this.chkAmthanh.Size = new System.Drawing.Size(98, 20);
            this.chkAmthanh.TabIndex = 14;
            this.chkAmthanh.Text = "Âm Thanh";
            this.chkAmthanh.UseVisualStyleBackColor = true;
            this.chkAmthanh.CheckedChanged += new System.EventHandler(this.chkAmthanh_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Location = new System.Drawing.Point(844, 582);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "Quay lại Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 653);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chkAmthanh);
            this.Controls.Add(this.btnGameMoi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWhiteTime);
            this.Controls.Add(this.lblBlackTime);
            this.Controls.Add(this.lblPlayerWhite);
            this.Controls.Add(this.picSelectedPiece);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.lblPlayerBlack);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlBoard);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game ";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblPlayerBlack;
        private System.Windows.Forms.Label lblPlayerWhite;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlack;
        private System.Windows.Forms.PictureBox picSelectedPiece;
        private System.Windows.Forms.Label lblBlackTime;
        private System.Windows.Forms.Label lblWhiteTime;
        private System.Windows.Forms.Timer timerChess;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGameMoi;
        private System.Windows.Forms.CheckBox chkAmthanh;
        private System.Windows.Forms.Button button3;
    }
}