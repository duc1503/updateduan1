namespace GUI.View
{
    partial class FrmLogin
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
            this.Tb_Taikhoan = new RJCodeAdvance.RJControls.RJTextBox();
            this.Tb_Matkhau = new RJCodeAdvance.RJControls.RJTextBox();
            this.Bt_Dangnhap = new RJCodeAdvance.RJControls.RJButton();
            this.pl_userlogin = new System.Windows.Forms.Panel();
            this.icon_seemk = new FontAwesome.Sharp.IconPictureBox();
            this.lb_tbsaimk = new System.Windows.Forms.Label();
            this.lb_tbsaittk = new System.Windows.Forms.Label();
            this.tgg_button = new RJCodeAdvance.RJControls.RJToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pl_userlogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_seemk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_Taikhoan
            // 
            this.Tb_Taikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.Tb_Taikhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.Tb_Taikhoan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Tb_Taikhoan.BorderRadius = 6;
            this.Tb_Taikhoan.BorderSize = 1;
            this.Tb_Taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb_Taikhoan.ForeColor = System.Drawing.Color.HotPink;
            this.Tb_Taikhoan.Location = new System.Drawing.Point(37, 188);
            this.Tb_Taikhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tb_Taikhoan.Multiline = false;
            this.Tb_Taikhoan.Name = "Tb_Taikhoan";
            this.Tb_Taikhoan.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.Tb_Taikhoan.PasswordChar = false;
            this.Tb_Taikhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Tb_Taikhoan.PlaceholderText = "Tên tài khoản";
            this.Tb_Taikhoan.Size = new System.Drawing.Size(228, 27);
            this.Tb_Taikhoan.TabIndex = 7;
            this.Tb_Taikhoan.TabStop = false;
            this.Tb_Taikhoan.Texts = "";
            this.Tb_Taikhoan.UnderlinedStyle = false;
            // 
            // Tb_Matkhau
            // 
            this.Tb_Matkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.Tb_Matkhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.Tb_Matkhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Tb_Matkhau.BorderRadius = 6;
            this.Tb_Matkhau.BorderSize = 1;
            this.Tb_Matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb_Matkhau.ForeColor = System.Drawing.Color.HotPink;
            this.Tb_Matkhau.Location = new System.Drawing.Point(37, 236);
            this.Tb_Matkhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tb_Matkhau.Multiline = false;
            this.Tb_Matkhau.Name = "Tb_Matkhau";
            this.Tb_Matkhau.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.Tb_Matkhau.PasswordChar = true;
            this.Tb_Matkhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Tb_Matkhau.PlaceholderText = "Mật khẩu";
            this.Tb_Matkhau.Size = new System.Drawing.Size(228, 27);
            this.Tb_Matkhau.TabIndex = 8;
            this.Tb_Matkhau.TabStop = false;
            this.Tb_Matkhau.Texts = "";
            this.Tb_Matkhau.UnderlinedStyle = false;
            this.Tb_Matkhau._TextChanged += new System.EventHandler(this.Tb_Matkhau__TextChanged);
            // 
            // Bt_Dangnhap
            // 
            this.Bt_Dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.Bt_Dangnhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.Bt_Dangnhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.Bt_Dangnhap.BorderRadius = 20;
            this.Bt_Dangnhap.BorderSize = 0;
            this.Bt_Dangnhap.FlatAppearance.BorderSize = 0;
            this.Bt_Dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Dangnhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bt_Dangnhap.ForeColor = System.Drawing.Color.White;
            this.Bt_Dangnhap.Location = new System.Drawing.Point(91, 339);
            this.Bt_Dangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_Dangnhap.Name = "Bt_Dangnhap";
            this.Bt_Dangnhap.Size = new System.Drawing.Size(124, 39);
            this.Bt_Dangnhap.TabIndex = 9;
            this.Bt_Dangnhap.Text = "Đăng nhập";
            this.Bt_Dangnhap.TextColor = System.Drawing.Color.White;
            this.Bt_Dangnhap.UseVisualStyleBackColor = false;
            this.Bt_Dangnhap.Click += new System.EventHandler(this.Bt_Dangnhap_Click_1);
            // 
            // pl_userlogin
            // 
            this.pl_userlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.pl_userlogin.Controls.Add(this.icon_seemk);
            this.pl_userlogin.Controls.Add(this.lb_tbsaimk);
            this.pl_userlogin.Controls.Add(this.lb_tbsaittk);
            this.pl_userlogin.Controls.Add(this.tgg_button);
            this.pl_userlogin.Controls.Add(this.label1);
            this.pl_userlogin.Controls.Add(this.iconPictureBox1);
            this.pl_userlogin.Controls.Add(this.Tb_Taikhoan);
            this.pl_userlogin.Controls.Add(this.Bt_Dangnhap);
            this.pl_userlogin.Controls.Add(this.Tb_Matkhau);
            this.pl_userlogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_userlogin.Location = new System.Drawing.Point(0, 0);
            this.pl_userlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pl_userlogin.Name = "pl_userlogin";
            this.pl_userlogin.Size = new System.Drawing.Size(296, 450);
            this.pl_userlogin.TabIndex = 10;
            // 
            // icon_seemk
            // 
            this.icon_seemk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.icon_seemk.ForeColor = System.Drawing.Color.HotPink;
            this.icon_seemk.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.icon_seemk.IconColor = System.Drawing.Color.HotPink;
            this.icon_seemk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_seemk.IconSize = 19;
            this.icon_seemk.Location = new System.Drawing.Point(242, 243);
            this.icon_seemk.Margin = new System.Windows.Forms.Padding(0);
            this.icon_seemk.Name = "icon_seemk";
            this.icon_seemk.Size = new System.Drawing.Size(19, 19);
            this.icon_seemk.TabIndex = 17;
            this.icon_seemk.TabStop = false;
            this.icon_seemk.Visible = false;
            this.icon_seemk.Click += new System.EventHandler(this.icon_seemk_Click);
            // 
            // lb_tbsaimk
            // 
            this.lb_tbsaimk.AutoSize = true;
            this.lb_tbsaimk.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_tbsaimk.ForeColor = System.Drawing.Color.HotPink;
            this.lb_tbsaimk.Location = new System.Drawing.Point(38, 266);
            this.lb_tbsaimk.Name = "lb_tbsaimk";
            this.lb_tbsaimk.Size = new System.Drawing.Size(107, 12);
            this.lb_tbsaimk.TabIndex = 16;
            this.lb_tbsaimk.Text = "Mật khẩu không hợp lệ";
            // 
            // lb_tbsaittk
            // 
            this.lb_tbsaittk.AutoSize = true;
            this.lb_tbsaittk.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lb_tbsaittk.ForeColor = System.Drawing.Color.HotPink;
            this.lb_tbsaittk.Location = new System.Drawing.Point(37, 218);
            this.lb_tbsaittk.Name = "lb_tbsaittk";
            this.lb_tbsaittk.Size = new System.Drawing.Size(126, 12);
            this.lb_tbsaittk.TabIndex = 15;
            this.lb_tbsaittk.Text = "Tên tài khoản không hợp lệ";
            // 
            // tgg_button
            // 
            this.tgg_button.AutoSize = true;
            this.tgg_button.BackColor = System.Drawing.Color.Maroon;
            this.tgg_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tgg_button.Location = new System.Drawing.Point(37, 296);
            this.tgg_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgg_button.MinimumSize = new System.Drawing.Size(35, 15);
            this.tgg_button.Name = "tgg_button";
            this.tgg_button.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tgg_button.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.tgg_button.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.tgg_button.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tgg_button.Size = new System.Drawing.Size(35, 15);
            this.tgg_button.TabIndex = 14;
            this.tgg_button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(77, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhớ tài khoản";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.iconPictureBox1.BackgroundImage = global::GUI.Properties.Resources._002_coffee_cup;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 102;
            this.iconPictureBox1.Location = new System.Drawing.Point(102, 29);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(102, 102);
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(296, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 450);
            this.panel1.TabIndex = 11;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.AutoSize = true;
            this.btn_Minimize.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Minimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Minimize.ForeColor = System.Drawing.Color.Black;
            this.btn_Minimize.Location = new System.Drawing.Point(458, 0);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(21, 19);
            this.btn_Minimize.TabIndex = 8;
            this.btn_Minimize.Text = "__";
            this.btn_Minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click_1);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.ForeColor = System.Drawing.Color.Gray;
            this.btn_Exit.Location = new System.Drawing.Point(480, 7);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(17, 19);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "X";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.anh_thanh_pho;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pl_userlogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 250);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.pl_userlogin.ResumeLayout(false);
            this.pl_userlogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_seemk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJTextBox Tb_Taikhoan;
        private RJCodeAdvance.RJControls.RJTextBox Tb_Matkhau;
        private RJCodeAdvance.RJControls.RJButton Bt_Dangnhap;
        private Panel pl_userlogin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        internal RJCodeAdvance.RJControls.RJToggleButton tgg_button;
        private Panel panel1;
        private Label btn_Minimize;
        private Label btn_Exit;
        private PictureBox pictureBox1;
        private Label lb_tbsaimk;
        private Label lb_tbsaittk;
        private FontAwesome.Sharp.IconPictureBox icon_seemk;
    }
}