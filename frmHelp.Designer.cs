namespace Project_GAME_GK_HK3_2026_ERROR
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblNhom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.AutoSize = true;
            this.pnlBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(318, 301);
            this.pnlBoard.TabIndex = 0;
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.BackColor = System.Drawing.Color.White;
            this.lblHuongDan.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuongDan.ForeColor = System.Drawing.Color.Black;
            this.lblHuongDan.Location = new System.Drawing.Point(355, 203);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(362, 167);
            this.lblHuongDan.TabIndex = 1;
            this.lblHuongDan.Text = "mô tả";
            this.lblHuongDan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHuongDan.Click += new System.EventHandler(this.lblHuongDan_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.BurlyWood;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(27, 325);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 45);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Tiếp tục";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(174, 325);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 45);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblNhom
            // 
            this.lblNhom.BackColor = System.Drawing.Color.White;
            this.lblNhom.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhom.ForeColor = System.Drawing.Color.Black;
            this.lblNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNhom.Location = new System.Drawing.Point(359, 9);
            this.lblNhom.Name = "lblNhom";
            this.lblNhom.Size = new System.Drawing.Size(362, 167);
            this.lblNhom.TabIndex = 4;
            this.lblNhom.Text = "Lớp: 2611COMP101901 \nNhóm thực hiện: ERROR\r\nNguyễn Xuân Thiết - 51.01.104.096\r\nHu" +
    "ỳnh Hải Kiên - 51.01.104.051\r\nTrần Hoàng Anh Khoa - 51.01.104.047\r\nNguyễn Thái K" +
    "ha - 51.01.104.040";
            this.lblNhom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNhom.Click += new System.EventHandler(this.lblNhom_Click);
            // 
            // frmHelp
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 386);
            this.Controls.Add(this.lblNhom);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblHuongDan);
            this.Controls.Add(this.pnlBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHelp";
            this.Text = "Hướng Dẫn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblNhom;
    }
}