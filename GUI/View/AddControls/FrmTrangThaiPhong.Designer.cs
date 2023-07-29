namespace GUI.View.AddControls
{
    partial class FrmTrangThaiPhong
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
            this.btn_LuuDichVu = new System.Windows.Forms.Button();
            this.dtg_DSDichVu = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btn_HuyLuuDV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThemDichVu = new System.Windows.Forms.Button();
            this.tb_GiaTienDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_TenDV = new System.Windows.Forms.ComboBox();
            this.lb_MaPhong = new System.Windows.Forms.Label();
            this.btn_NhanPhong = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_ChuyenTTPhongTrong = new System.Windows.Forms.Button();
            this.tb_SL = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DSDichVu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_SL)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LuuDichVu
            // 
            this.btn_LuuDichVu.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_LuuDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LuuDichVu.FlatAppearance.BorderSize = 0;
            this.btn_LuuDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LuuDichVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_LuuDichVu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_LuuDichVu.Location = new System.Drawing.Point(506, 473);
            this.btn_LuuDichVu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_LuuDichVu.Name = "btn_LuuDichVu";
            this.btn_LuuDichVu.Size = new System.Drawing.Size(80, 30);
            this.btn_LuuDichVu.TabIndex = 28;
            this.btn_LuuDichVu.Text = "Lưu";
            this.btn_LuuDichVu.UseVisualStyleBackColor = false;
            this.btn_LuuDichVu.Click += new System.EventHandler(this.btn_LuuDichVu_Click);
            // 
            // dtg_DSDichVu
            // 
            this.dtg_DSDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DSDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DSDichVu.Location = new System.Drawing.Point(51, 177);
            this.dtg_DSDichVu.Name = "dtg_DSDichVu";
            this.dtg_DSDichVu.RowHeadersWidth = 51;
            this.dtg_DSDichVu.RowTemplate.Height = 25;
            this.dtg_DSDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DSDichVu.Size = new System.Drawing.Size(385, 165);
            this.dtg_DSDichVu.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(529, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Danh sách dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(51, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Danh sách dịch vụ đã chọn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_NgayKetThuc);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(529, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 53);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày trả";
            // 
            // dtp_NgayKetThuc
            // 
            this.dtp_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayKetThuc.Location = new System.Drawing.Point(6, 18);
            this.dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            this.dtp_NgayKetThuc.Size = new System.Drawing.Size(221, 23);
            this.dtp_NgayKetThuc.TabIndex = 0;
            // 
            // btn_HuyLuuDV
            // 
            this.btn_HuyLuuDV.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_HuyLuuDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HuyLuuDV.FlatAppearance.BorderSize = 0;
            this.btn_HuyLuuDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyLuuDV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HuyLuuDV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_HuyLuuDV.Location = new System.Drawing.Point(625, 473);
            this.btn_HuyLuuDV.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HuyLuuDV.Name = "btn_HuyLuuDV";
            this.btn_HuyLuuDV.Size = new System.Drawing.Size(80, 30);
            this.btn_HuyLuuDV.TabIndex = 29;
            this.btn_HuyLuuDV.Text = "Hủy";
            this.btn_HuyLuuDV.UseVisualStyleBackColor = false;
            this.btn_HuyLuuDV.Click += new System.EventHandler(this.btn_HuyLuuDV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_NgayBatDau);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(224, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 53);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày nhận";
            // 
            // dtp_NgayBatDau
            // 
            this.dtp_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayBatDau.Location = new System.Drawing.Point(6, 18);
            this.dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            this.dtp_NgayBatDau.Size = new System.Drawing.Size(206, 23);
            this.dtp_NgayBatDau.TabIndex = 0;
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TenKH.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lb_TenKH.Location = new System.Drawing.Point(51, 24);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(59, 20);
            this.lb_TenKH.TabIndex = 1;
            this.lb_TenKH.Text = "Tên KH";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtg_DSDichVu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lb_TenKH);
            this.panel1.Location = new System.Drawing.Point(30, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 372);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.tb_SL);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_ThemDichVu);
            this.panel2.Controls.Add(this.tb_GiaTienDV);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbb_TenDV);
            this.panel2.Location = new System.Drawing.Point(529, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 200);
            this.panel2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Giá tiền";
            // 
            // btn_ThemDichVu
            // 
            this.btn_ThemDichVu.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemDichVu.FlatAppearance.BorderSize = 0;
            this.btn_ThemDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemDichVu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemDichVu.Location = new System.Drawing.Point(95, 157);
            this.btn_ThemDichVu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemDichVu.Name = "btn_ThemDichVu";
            this.btn_ThemDichVu.Size = new System.Drawing.Size(132, 32);
            this.btn_ThemDichVu.TabIndex = 32;
            this.btn_ThemDichVu.Text = "Thêm dịch vụ";
            this.btn_ThemDichVu.UseVisualStyleBackColor = false;
            this.btn_ThemDichVu.Click += new System.EventHandler(this.btn_ThemDichVu_Click);
            // 
            // tb_GiaTienDV
            // 
            this.tb_GiaTienDV.Location = new System.Drawing.Point(104, 79);
            this.tb_GiaTienDV.Name = "tb_GiaTienDV";
            this.tb_GiaTienDV.Size = new System.Drawing.Size(168, 23);
            this.tb_GiaTienDV.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên dịch vụ";
            // 
            // cbb_TenDV
            // 
            this.cbb_TenDV.FormattingEnabled = true;
            this.cbb_TenDV.Location = new System.Drawing.Point(104, 30);
            this.cbb_TenDV.Name = "cbb_TenDV";
            this.cbb_TenDV.Size = new System.Drawing.Size(168, 23);
            this.cbb_TenDV.TabIndex = 34;
            this.cbb_TenDV.SelectedValueChanged += new System.EventHandler(this.cbb_TenDV_SelectedValueChanged);
            // 
            // lb_MaPhong
            // 
            this.lb_MaPhong.AutoSize = true;
            this.lb_MaPhong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_MaPhong.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lb_MaPhong.Location = new System.Drawing.Point(430, 15);
            this.lb_MaPhong.Name = "lb_MaPhong";
            this.lb_MaPhong.Size = new System.Drawing.Size(138, 32);
            this.lb_MaPhong.TabIndex = 26;
            this.lb_MaPhong.Text = "Mã phòng ";
            // 
            // btn_NhanPhong
            // 
            this.btn_NhanPhong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_NhanPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NhanPhong.FlatAppearance.BorderSize = 0;
            this.btn_NhanPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NhanPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NhanPhong.Location = new System.Drawing.Point(342, 473);
            this.btn_NhanPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_NhanPhong.Name = "btn_NhanPhong";
            this.btn_NhanPhong.Size = new System.Drawing.Size(132, 30);
            this.btn_NhanPhong.TabIndex = 30;
            this.btn_NhanPhong.Text = "Nhận phòng";
            this.btn_NhanPhong.UseVisualStyleBackColor = false;
            this.btn_NhanPhong.Click += new System.EventHandler(this.btn_NhanPhong_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThanhToan.Location = new System.Drawing.Point(741, 473);
            this.btn_ThanhToan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(132, 30);
            this.btn_ThanhToan.TabIndex = 31;
            this.btn_ThanhToan.Text = "Xem hóa đơn";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_ChuyenTTPhongTrong
            // 
            this.btn_ChuyenTTPhongTrong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ChuyenTTPhongTrong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChuyenTTPhongTrong.FlatAppearance.BorderSize = 0;
            this.btn_ChuyenTTPhongTrong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChuyenTTPhongTrong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ChuyenTTPhongTrong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ChuyenTTPhongTrong.Location = new System.Drawing.Point(107, 473);
            this.btn_ChuyenTTPhongTrong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ChuyenTTPhongTrong.Name = "btn_ChuyenTTPhongTrong";
            this.btn_ChuyenTTPhongTrong.Size = new System.Drawing.Size(207, 30);
            this.btn_ChuyenTTPhongTrong.TabIndex = 32;
            this.btn_ChuyenTTPhongTrong.Text = "Chuyển thành phòng trống";
            this.btn_ChuyenTTPhongTrong.UseVisualStyleBackColor = false;
            this.btn_ChuyenTTPhongTrong.Click += new System.EventHandler(this.btn_ChuyenTTPhongTrong_Click);
            // 
            // tb_SL
            // 
            this.tb_SL.Location = new System.Drawing.Point(119, 117);
            this.tb_SL.Name = "tb_SL";
            this.tb_SL.Size = new System.Drawing.Size(120, 23);
            this.tb_SL.TabIndex = 38;
            this.tb_SL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmTrangThaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 549);
            this.Controls.Add(this.btn_ChuyenTTPhongTrong);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_NhanPhong);
            this.Controls.Add(this.btn_LuuDichVu);
            this.Controls.Add(this.btn_HuyLuuDV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_MaPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTrangThaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTrangThaiPhong";
            this.Load += new System.EventHandler(this.FrmTrangThaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DSDichVu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_SL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_LuuDichVu;
        private DataGridView dtg_DSDichVu;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private DateTimePicker dtp_NgayKetThuc;
        private Button btn_HuyLuuDV;
        private GroupBox groupBox1;
        private DateTimePicker dtp_NgayBatDau;
        private Label lb_TenKH;
        private Panel panel1;
        private Label lb_MaPhong;
        private Button btn_NhanPhong;
        private Button btn_ThanhToan;
        private Button btn_ThemDichVu;
        private Panel panel2;
        private Label label3;
        private TextBox tb_GiaTienDV;
        private Label label1;
        private ComboBox cbb_TenDV;
        private Button btn_ChuyenTTPhongTrong;
        private NumericUpDown tb_SL;
    }
}