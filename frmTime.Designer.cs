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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(109, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chọn thời gian";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(35, 55);
            this.btn10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(100, 28);
            this.btn10.TabIndex = 1;
            this.btn10.Text = "10 phút";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn15
            // 
            this.btn15.Location = new System.Drawing.Point(183, 55);
            this.btn15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(100, 28);
            this.btn15.TabIndex = 2;
            this.btn15.Text = "15 phút";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(334, 55);
            this.btn20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(100, 28);
            this.btn20.TabIndex = 3;
            this.btn20.Text = "20 phút";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.Button3_Click);
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(35, 105);
            this.numMinutes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(152, 22);
            this.numMinutes.TabIndex = 4;
            this.numMinutes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMinutes.ValueChanged += new System.EventHandler(this.numMinutes_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "phút / người";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(42, 218);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 28);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(309, 135);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 111);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Bắt đầu chơi";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(39, 144);
            this.lblPlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(96, 16);
            this.lblPlayer1.TabIndex = 8;
            this.lblPlayer1.Text = "Player 1 - Đen :";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(39, 178);
            this.lblPlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(108, 16);
            this.lblPlayer2.TabIndex = 9;
            this.lblPlayer2.Text = "Player 2 - Trắng :";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(143, 172);
            this.txtPlayer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlayer2.MaxLength = 30;
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(140, 22);
            this.txtPlayer2.TabIndex = 1;
            this.txtPlayer2.TextChanged += new System.EventHandler(this.txtPlayer2_TextChanged);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(143, 135);
            this.txtPlayer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlayer1.MaxLength = 30;
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(140, 22);
            this.txtPlayer1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 292);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numMinutes);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTime";
            this.Text = "frmTime";
            this.Load += new System.EventHandler(this.frmTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}