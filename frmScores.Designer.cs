namespace Project_GAME_GK_HK3_2026_ERROR
{
    partial class frmScores
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
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.pnlReplayBoard = new System.Windows.Forms.Panel();
            this.lblMatchInfo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryTitle.Location = new System.Drawing.Point(450, 20);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(135, 21);
            this.lblHistoryTitle.TabIndex = 0;
            this.lblHistoryTitle.Text = "Lịch sử trận đấu ";
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Location = new System.Drawing.Point(450, 60);
            this.dgvMatches.MultiSelect = false;
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(620, 260);
            this.dgvMatches.TabIndex = 1;
            this.dgvMatches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatches_CellContentClick);
            this.dgvMatches.SelectionChanged += new System.EventHandler(this.dgvMatches_SelectionChanged);
            // 
            // pnlReplayBoard
            // 
            this.pnlReplayBoard.Location = new System.Drawing.Point(20, 60);
            this.pnlReplayBoard.Name = "pnlReplayBoard";
            this.pnlReplayBoard.Size = new System.Drawing.Size(400, 400);
            this.pnlReplayBoard.TabIndex = 2;
            this.pnlReplayBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlReplayBoard_Paint);
            // 
            // lblMatchInfo
            // 
            this.lblMatchInfo.AutoSize = true;
            this.lblMatchInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchInfo.Location = new System.Drawing.Point(450, 335);
            this.lblMatchInfo.Name = "lblMatchInfo";
            this.lblMatchInfo.Size = new System.Drawing.Size(51, 20);
            this.lblMatchInfo.TabIndex = 3;
            this.lblMatchInfo.Text = "label1";
            this.lblMatchInfo.Click += new System.EventHandler(this.lblMatchInfo_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(950, 465);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 501);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMatchInfo);
            this.Controls.Add(this.pnlReplayBoard);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.lblHistoryTitle);
            this.Name = "frmScores";
            this.Text = "frmScores";
            this.Load += new System.EventHandler(this.frmScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Panel pnlReplayBoard;
        private System.Windows.Forms.Label lblMatchInfo;
        private System.Windows.Forms.Button btnBack;
    }
}