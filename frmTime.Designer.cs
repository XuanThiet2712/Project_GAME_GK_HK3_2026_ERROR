namespace Project_GAME_GK_HK3_2026_ERROR
{
    partial class frmTime
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.bt10 = new System.Windows.Forms.Button();
            this.bt20 = new System.Windows.Forms.Button();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.bt15 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(163, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chọn thời gian";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // bt10
            // 
            this.bt10.Location = new System.Drawing.Point(78, 71);
            this.bt10.Name = "bt10";
            this.bt10.Size = new System.Drawing.Size(75, 23);
            this.bt10.TabIndex = 1;
            this.bt10.Text = "10 phút";
            this.bt10.UseVisualStyleBackColor = true;
            this.bt10.Click += new System.EventHandler(this.bt10_Click);
            // 
            // bt20
            // 
            this.bt20.Location = new System.Drawing.Point(298, 71);
            this.bt20.Name = "bt20";
            this.bt20.Size = new System.Drawing.Size(75, 23);
            this.bt20.TabIndex = 3;
            this.bt20.Text = "20 phút";
            this.bt20.UseVisualStyleBackColor = true;
            this.bt20.Click += new System.EventHandler(this.bt20_Click);
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(78, 129);
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(222, 20);
            this.numMinutes.TabIndex = 4;
            this.numMinutes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMinutes.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "phút / người";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(78, 177);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(223, 177);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Bắt đầu chơi";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // bt15
            // 
            this.bt15.Location = new System.Drawing.Point(187, 71);
            this.bt15.Name = "bt15";
            this.bt15.Size = new System.Drawing.Size(75, 23);
            this.bt15.TabIndex = 8;
            this.bt15.Text = "15 phút";
            this.bt15.UseVisualStyleBackColor = true;
            this.bt15.Click += new System.EventHandler(this.bt15_Click);
            // 
            // frmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 235);
            this.Controls.Add(this.bt15);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numMinutes);
            this.Controls.Add(this.bt20);
            this.Controls.Add(this.bt10);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmTime";
            this.Text = "frmTime";
            this.Load += new System.EventHandler(this.frmTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button bt10;
        private System.Windows.Forms.Button bt20;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button bt15;
    }
}