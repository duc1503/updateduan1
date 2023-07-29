namespace GUI.View.AddControls
{
    partial class FrmBtnSuaPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBtnSuaPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_TrangThai = new System.Windows.Forms.ComboBox();
            this.cbb_TenLoaiPhong = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_MaPhong = new System.Windows.Forms.TextBox();
            this.btn_HuySuaPhong = new System.Windows.Forms.Button();
            this.btn_SuaPhong = new System.Windows.Forms.Button();
            this.lb_TenPhongSua = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(121, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 41);
            this.label1.TabIndex = 33;
            this.label1.Text = "Sửa thông tin phòng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.cbb_TrangThai);
            this.panel1.Controls.Add(this.cbb_TenLoaiPhong);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tb_MaPhong);
            this.panel1.Location = new System.Drawing.Point(149, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 359);
            this.panel1.TabIndex = 32;
            // 
            // cbb_TrangThai
            // 
            this.cbb_TrangThai.FormattingEnabled = true;
            this.cbb_TrangThai.Location = new System.Drawing.Point(122, 231);
            this.cbb_TrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_TrangThai.Name = "cbb_TrangThai";
            this.cbb_TrangThai.Size = new System.Drawing.Size(218, 28);
            this.cbb_TrangThai.TabIndex = 29;
            this.cbb_TrangThai.TabStop = false;
            // 
            // cbb_TenLoaiPhong
            // 
            this.cbb_TenLoaiPhong.FormattingEnabled = true;
            this.cbb_TenLoaiPhong.Items.AddRange(new object[] {
            "--Chọn loại phòng--"});
            this.cbb_TenLoaiPhong.Location = new System.Drawing.Point(122, 129);
            this.cbb_TenLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_TenLoaiPhong.Name = "cbb_TenLoaiPhong";
            this.cbb_TenLoaiPhong.Size = new System.Drawing.Size(218, 28);
            this.cbb_TenLoaiPhong.TabIndex = 27;
            this.cbb_TenLoaiPhong.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(71, 229);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(71, 129);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // tb_MaPhong
            // 
            this.tb_MaPhong.Location = new System.Drawing.Point(122, 40);
            this.tb_MaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_MaPhong.Name = "tb_MaPhong";
            this.tb_MaPhong.PlaceholderText = "Nhập mã phòng";
            this.tb_MaPhong.Size = new System.Drawing.Size(218, 27);
            this.tb_MaPhong.TabIndex = 17;
            this.tb_MaPhong.TabStop = false;
            // 
            // btn_HuySuaPhong
            // 
            this.btn_HuySuaPhong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_HuySuaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HuySuaPhong.FlatAppearance.BorderSize = 0;
            this.btn_HuySuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuySuaPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HuySuaPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_HuySuaPhong.Location = new System.Drawing.Point(438, 492);
            this.btn_HuySuaPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HuySuaPhong.Name = "btn_HuySuaPhong";
            this.btn_HuySuaPhong.Size = new System.Drawing.Size(110, 40);
            this.btn_HuySuaPhong.TabIndex = 35;
            this.btn_HuySuaPhong.Text = "Hủy";
            this.btn_HuySuaPhong.UseVisualStyleBackColor = false;
            this.btn_HuySuaPhong.Click += new System.EventHandler(this.btn_HuySuaPhong_Click);
            // 
            // btn_SuaPhong
            // 
            this.btn_SuaPhong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_SuaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SuaPhong.FlatAppearance.BorderSize = 0;
            this.btn_SuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuaPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SuaPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SuaPhong.Location = new System.Drawing.Point(291, 492);
            this.btn_SuaPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SuaPhong.Name = "btn_SuaPhong";
            this.btn_SuaPhong.Size = new System.Drawing.Size(110, 40);
            this.btn_SuaPhong.TabIndex = 34;
            this.btn_SuaPhong.Text = "Cập nhật";
            this.btn_SuaPhong.UseVisualStyleBackColor = false;
            this.btn_SuaPhong.Click += new System.EventHandler(this.btn_SuaPhong_Click);
            // 
            // lb_TenPhongSua
            // 
            this.lb_TenPhongSua.AutoSize = true;
            this.lb_TenPhongSua.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TenPhongSua.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lb_TenPhongSua.Location = new System.Drawing.Point(438, 27);
            this.lb_TenPhongSua.Name = "lb_TenPhongSua";
            this.lb_TenPhongSua.Size = new System.Drawing.Size(167, 41);
            this.lb_TenPhongSua.TabIndex = 36;
            this.lb_TenPhongSua.Text = "Tên phòng";
            // 
            // FrmBtnSuaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 571);
            this.Controls.Add(this.lb_TenPhongSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_HuySuaPhong);
            this.Controls.Add(this.btn_SuaPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBtnSuaPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBtnSuaPhong";
            this.Load += new System.EventHandler(this.FrmBtnSuaPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox cbb_TrangThai;
        private ComboBox cbb_TenLoaiPhong;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private TextBox tb_MaPhong;
        private Button btn_HuySuaPhong;
        private Button btn_SuaPhong;
        private Label lb_TenPhongSua;
    }
}