namespace duAnGameCoTuong_theHe2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.lblShowDongHoNguoiB = new System.Windows.Forms.Label();
            this.lblShowDongHoNguoiA = new System.Windows.Forms.Label();
            this.btnReStartGame = new System.Windows.Forms.Button();
            this.txtTenNguoiChoiB = new System.Windows.Forms.TextBox();
            this.txtTenNguoiChoiA = new System.Windows.Forms.TextBox();
            this.btnDaoLuocChoi = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblShowTenNguoiChoiB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShowTenNguoiChoiA = new System.Windows.Forms.Label();
            this.Lable1 = new System.Windows.Forms.Label();
            this.pnBanCo = new System.Windows.Forms.Panel();
            this.pnBanCo2 = new System.Windows.Forms.Panel();
            this.dongHoTinhGio = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 100);
            this.panel1.TabIndex = 2;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.lblShowDongHoNguoiB);
            this.groupInfo.Controls.Add(this.lblShowDongHoNguoiA);
            this.groupInfo.Controls.Add(this.btnReStartGame);
            this.groupInfo.Controls.Add(this.txtTenNguoiChoiB);
            this.groupInfo.Controls.Add(this.txtTenNguoiChoiA);
            this.groupInfo.Controls.Add(this.btnDaoLuocChoi);
            this.groupInfo.Controls.Add(this.btnStartGame);
            this.groupInfo.Controls.Add(this.lblShowTenNguoiChoiB);
            this.groupInfo.Controls.Add(this.label1);
            this.groupInfo.Controls.Add(this.lblShowTenNguoiChoiA);
            this.groupInfo.Controls.Add(this.Lable1);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfo.Location = new System.Drawing.Point(0, 0);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(1117, 96);
            this.groupInfo.TabIndex = 0;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Thông tin người dùng && điều khiển";
            // 
            // lblShowDongHoNguoiB
            // 
            this.lblShowDongHoNguoiB.BackColor = System.Drawing.Color.White;
            this.lblShowDongHoNguoiB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowDongHoNguoiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDongHoNguoiB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblShowDongHoNguoiB.Location = new System.Drawing.Point(407, 55);
            this.lblShowDongHoNguoiB.Name = "lblShowDongHoNguoiB";
            this.lblShowDongHoNguoiB.Size = new System.Drawing.Size(134, 30);
            this.lblShowDongHoNguoiB.TabIndex = 8;
            this.lblShowDongHoNguoiB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShowDongHoNguoiA
            // 
            this.lblShowDongHoNguoiA.BackColor = System.Drawing.Color.White;
            this.lblShowDongHoNguoiA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowDongHoNguoiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDongHoNguoiA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblShowDongHoNguoiA.Location = new System.Drawing.Point(407, 16);
            this.lblShowDongHoNguoiA.Name = "lblShowDongHoNguoiA";
            this.lblShowDongHoNguoiA.Size = new System.Drawing.Size(134, 30);
            this.lblShowDongHoNguoiA.TabIndex = 8;
            this.lblShowDongHoNguoiA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReStartGame
            // 
            this.btnReStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReStartGame.Enabled = false;
            this.btnReStartGame.Location = new System.Drawing.Point(1023, 19);
            this.btnReStartGame.Name = "btnReStartGame";
            this.btnReStartGame.Size = new System.Drawing.Size(68, 46);
            this.btnReStartGame.TabIndex = 7;
            this.btnReStartGame.Text = "Restart Game";
            this.btnReStartGame.UseVisualStyleBackColor = true;
            this.btnReStartGame.Click += new System.EventHandler(this.btnReStartGame_Click);
            // 
            // txtTenNguoiChoiB
            // 
            this.txtTenNguoiChoiB.Location = new System.Drawing.Point(142, 41);
            this.txtTenNguoiChoiB.Name = "txtTenNguoiChoiB";
            this.txtTenNguoiChoiB.Size = new System.Drawing.Size(235, 20);
            this.txtTenNguoiChoiB.TabIndex = 3;
            this.txtTenNguoiChoiB.Text = "Người Chơi B";
            // 
            // txtTenNguoiChoiA
            // 
            this.txtTenNguoiChoiA.Location = new System.Drawing.Point(142, 19);
            this.txtTenNguoiChoiA.Name = "txtTenNguoiChoiA";
            this.txtTenNguoiChoiA.Size = new System.Drawing.Size(235, 20);
            this.txtTenNguoiChoiA.TabIndex = 1;
            this.txtTenNguoiChoiA.Text = "Nguời Chơi A";
            // 
            // btnDaoLuocChoi
            // 
            this.btnDaoLuocChoi.Location = new System.Drawing.Point(243, 67);
            this.btnDaoLuocChoi.Name = "btnDaoLuocChoi";
            this.btnDaoLuocChoi.Size = new System.Drawing.Size(108, 23);
            this.btnDaoLuocChoi.TabIndex = 4;
            this.btnDaoLuocChoi.Text = "Đảo lược chơi";
            this.btnDaoLuocChoi.UseVisualStyleBackColor = true;
            this.btnDaoLuocChoi.Click += new System.EventHandler(this.btnDaoLuocChoi_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(162, 67);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblShowTenNguoiChoiB
            // 
            this.lblShowTenNguoiChoiB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowTenNguoiChoiB.BackColor = System.Drawing.Color.White;
            this.lblShowTenNguoiChoiB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowTenNguoiChoiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTenNguoiChoiB.ForeColor = System.Drawing.Color.White;
            this.lblShowTenNguoiChoiB.Location = new System.Drawing.Point(562, 54);
            this.lblShowTenNguoiChoiB.Name = "lblShowTenNguoiChoiB";
            this.lblShowTenNguoiChoiB.Size = new System.Drawing.Size(433, 31);
            this.lblShowTenNguoiChoiB.TabIndex = 6;
            this.lblShowTenNguoiChoiB.Text = "Tên Người Chơi B";
            this.lblShowTenNguoiChoiB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Người Chơi B";
            // 
            // lblShowTenNguoiChoiA
            // 
            this.lblShowTenNguoiChoiA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowTenNguoiChoiA.BackColor = System.Drawing.Color.White;
            this.lblShowTenNguoiChoiA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowTenNguoiChoiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTenNguoiChoiA.ForeColor = System.Drawing.Color.White;
            this.lblShowTenNguoiChoiA.Location = new System.Drawing.Point(562, 15);
            this.lblShowTenNguoiChoiA.Name = "lblShowTenNguoiChoiA";
            this.lblShowTenNguoiChoiA.Size = new System.Drawing.Size(433, 31);
            this.lblShowTenNguoiChoiA.TabIndex = 5;
            this.lblShowTenNguoiChoiA.Text = "Tên Người Chơi A";
            this.lblShowTenNguoiChoiA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lable1
            // 
            this.Lable1.Location = new System.Drawing.Point(35, 20);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(100, 20);
            this.Lable1.TabIndex = 0;
            this.Lable1.Text = "Tên Người Chơi A";
            // 
            // pnBanCo
            // 
            this.pnBanCo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnBanCo.Location = new System.Drawing.Point(37, 106);
            this.pnBanCo.Name = "pnBanCo";
            this.pnBanCo.Size = new System.Drawing.Size(495, 550);
            this.pnBanCo.TabIndex = 0;
            // 
            // pnBanCo2
            // 
            this.pnBanCo2.ForeColor = System.Drawing.Color.White;
            this.pnBanCo2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnBanCo2.Location = new System.Drawing.Point(598, 106);
            this.pnBanCo2.Name = "pnBanCo2";
            this.pnBanCo2.Size = new System.Drawing.Size(495, 550);
            this.pnBanCo2.TabIndex = 1;
            // 
            // dongHoTinhGio
            // 
            this.dongHoTinhGio.Interval = 1000;
            this.dongHoTinhGio.Tick += new System.EventHandler(this.dongHoTinhGio_Tick);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1121, 684);
            this.Controls.Add(this.pnBanCo2);
            this.Controls.Add(this.pnBanCo);
            this.Controls.Add(this.panel1);
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnBanCo;
        private System.Windows.Forms.Panel pnBanCo2;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Button btnReStartGame;
        private System.Windows.Forms.TextBox txtTenNguoiChoiB;
        private System.Windows.Forms.TextBox txtTenNguoiChoiA;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblShowTenNguoiChoiB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShowTenNguoiChoiA;
        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.Button btnDaoLuocChoi;
        private System.Windows.Forms.Label lblShowDongHoNguoiB;
        private System.Windows.Forms.Label lblShowDongHoNguoiA;
        private System.Windows.Forms.Timer dongHoTinhGio;
    }
}

