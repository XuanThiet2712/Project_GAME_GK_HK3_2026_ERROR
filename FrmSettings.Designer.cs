namespace Project_GAME_GK_HK3_2026_ERROR
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.chkNhacmenu = new System.Windows.Forms.CheckBox();
            this.chkNhacco = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkNhacmenu
            // 
            this.chkNhacmenu.AutoSize = true;
            this.chkNhacmenu.BackColor = System.Drawing.Color.Transparent;
            this.chkNhacmenu.Checked = true;
            this.chkNhacmenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNhacmenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkNhacmenu.Location = new System.Drawing.Point(31, 65);
            this.chkNhacmenu.Name = "chkNhacmenu";
            this.chkNhacmenu.Size = new System.Drawing.Size(86, 20);
            this.chkNhacmenu.TabIndex = 0;
            this.chkNhacmenu.Text = "Nhạc nền";
            this.chkNhacmenu.UseVisualStyleBackColor = false;
            this.chkNhacmenu.Click += new System.EventHandler(this.chkNhacmenu_CheckedChanged);
            // 
            // chkNhacco
            // 
            this.chkNhacco.AutoSize = true;
            this.chkNhacco.BackColor = System.Drawing.Color.Transparent;
            this.chkNhacco.Checked = true;
            this.chkNhacco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNhacco.Location = new System.Drawing.Point(31, 106);
            this.chkNhacco.Name = "chkNhacco";
            this.chkNhacco.Size = new System.Drawing.Size(115, 20);
            this.chkNhacco.TabIndex = 1;
            this.chkNhacco.Text = "Tiếng đánh cờ";
            this.chkNhacco.UseVisualStyleBackColor = false;
            this.chkNhacco.Click += new System.EventHandler(this.chkNhacco_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(155, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CÀI ĐẶT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(133, 281);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 65);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Hoàn Thành";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 358);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkNhacco);
            this.Controls.Add(this.chkNhacmenu);
            this.DoubleBuffered = true;
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNhacmenu;
        private System.Windows.Forms.CheckBox chkNhacco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}