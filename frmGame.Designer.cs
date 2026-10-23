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
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWhite = new System.Windows.Forms.Label();
            this.lblBlack = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.colWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picSelectedPiece = new System.Windows.Forms.PictureBox();
            this.lblBlackTime = new System.Windows.Forms.Label();
            this.lblWhiteTime = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 615);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 2: ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(750, 263);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(9, 7);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1: ";
            // 
            // lblWhite
            // 
            this.lblWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWhite.AutoSize = true;
            this.lblWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhite.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblWhite.Location = new System.Drawing.Point(90, 0);
            this.lblWhite.Margin = new System.Windows.Forms.Padding(0);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(0, 39);
            this.lblWhite.TabIndex = 2;
            // 
            // lblBlack
            // 
            this.lblBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlack.AutoSize = true;
            this.lblBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblBlack.Location = new System.Drawing.Point(90, 600);
            this.lblBlack.Margin = new System.Windows.Forms.Padding(0);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(0, 39);
            this.lblBlack.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 23);
            this.lblTime.TabIndex = 11;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeColumns = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWhite,
            this.colBlack});
            this.dgvHistory.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHistory.Location = new System.Drawing.Point(650, 106);
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
            this.picSelectedPiece.Location = new System.Drawing.Point(709, 385);
            this.picSelectedPiece.Name = "picSelectedPiece";
            this.picSelectedPiece.Size = new System.Drawing.Size(134, 107);
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
            this.lblBlackTime.Size = new System.Drawing.Size(43, 16);
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
            this.lblWhiteTime.Size = new System.Drawing.Size(43, 16);
            this.lblWhiteTime.TabIndex = 10;
            this.lblWhiteTime.Text = "10:00";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 653);
            this.Controls.Add(this.lblWhiteTime);
            this.Controls.Add(this.lblBlackTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picSelectedPiece);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblBlack);
            this.Controls.Add(this.lblWhite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlBoard);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGame";
            this.Text = "frmGame";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWhite;
        private System.Windows.Forms.Label lblBlack;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWhite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlack;
        private System.Windows.Forms.PictureBox picSelectedPiece;
        private System.Windows.Forms.Label lblBlackTime;
        private System.Windows.Forms.Label lblWhiteTime;
    }
}