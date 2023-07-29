namespace GUI.View
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pn_MenuBar = new System.Windows.Forms.Panel();
            this.ibtn_ThongKe = new FontAwesome.Sharp.IconButton();
            this.ibtn_ChucVu = new FontAwesome.Sharp.IconButton();
            this.ibtn_QLTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.ibtn_QLNhanVien = new FontAwesome.Sharp.IconButton();
            this.ibtn_QLCTTienNghi = new FontAwesome.Sharp.IconButton();
            this.ibtn_QLTienNghi = new FontAwesome.Sharp.IconButton();
            this.ibtn_QLDichVu = new FontAwesome.Sharp.IconButton();
            this.ibtn_QLLoaiDichVu = new FontAwesome.Sharp.IconButton();
            this.ibtn_QLPhong = new FontAwesome.Sharp.IconButton();
            this.ibtn_QLLoaiPhong = new FontAwesome.Sharp.IconButton();
            this.ibtn_QLKhachHang = new FontAwesome.Sharp.IconButton();
            this.ibtn_HoaDon = new FontAwesome.Sharp.IconButton();
            this.ibtn_DatPhong = new FontAwesome.Sharp.IconButton();
            this.ibtn_DanhSachPhong = new FontAwesome.Sharp.IconButton();
            this.pn_AccImg = new System.Windows.Forms.Panel();
            this.lb_TenNV = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_TitleBar = new System.Windows.Forms.Panel();
            this.btn_Logout = new RJCodeAdvance.RJControls.RJButton();
            this.btn_Minimize = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Label();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pn_MenuBar.SuspendLayout();
            this.pn_AccImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_MenuBar
            // 
            this.pn_MenuBar.AutoScroll = true;
            this.pn_MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pn_MenuBar.Controls.Add(this.ibtn_ThongKe);
            this.pn_MenuBar.Controls.Add(this.ibtn_ChucVu);
            this.pn_MenuBar.Controls.Add(this.ibtn_QLTaiKhoan);
            this.pn_MenuBar.Controls.Add(this.ibtn_QLNhanVien);
            this.pn_MenuBar.Controls.Add(this.ibtn_QLCTTienNghi);
            this.pn_MenuBar.Controls.Add(this.ibtn_QLTienNghi);
            this.pn_MenuBar.Controls.Add(this.ibtn_QLDichVu);
            this.pn_MenuBar.Controls.Add(this.ibtn_QLLoaiDichVu);
            this.pn_MenuBar.Controls.Add(this.ibtn_QLPhong);
            this.pn_MenuBar.Controls.Add(this.ibtn_QLLoaiPhong);
            this.pn_MenuBar.Controls.Add(this.ibtn_QLKhachHang);
            this.pn_MenuBar.Controls.Add(this.ibtn_HoaDon);
            this.pn_MenuBar.Controls.Add(this.ibtn_DatPhong);
            this.pn_MenuBar.Controls.Add(this.ibtn_DanhSachPhong);
            this.pn_MenuBar.Controls.Add(this.pn_AccImg);
            this.pn_MenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_MenuBar.Location = new System.Drawing.Point(0, 0);
            this.pn_MenuBar.Name = "pn_MenuBar";
            this.pn_MenuBar.Size = new System.Drawing.Size(220, 735);
            this.pn_MenuBar.TabIndex = 0;
            // 
            // ibtn_ThongKe
            // 
            this.ibtn_ThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_ThongKe.FlatAppearance.BorderSize = 0;
            this.ibtn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_ThongKe.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_ThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.ibtn_ThongKe.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_ThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_ThongKe.IconSize = 24;
            this.ibtn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_ThongKe.Location = new System.Drawing.Point(0, 706);
            this.ibtn_ThongKe.Name = "ibtn_ThongKe";
            this.ibtn_ThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_ThongKe.Size = new System.Drawing.Size(203, 45);
            this.ibtn_ThongKe.TabIndex = 14;
            this.ibtn_ThongKe.Text = "Thống kê";
            this.ibtn_ThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_ThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_ThongKe.UseVisualStyleBackColor = true;
            this.ibtn_ThongKe.Click += new System.EventHandler(this.ibtn_ThongKe_Click);
            // 
            // ibtn_ChucVu
            // 
            this.ibtn_ChucVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_ChucVu.FlatAppearance.BorderSize = 0;
            this.ibtn_ChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_ChucVu.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_ChucVu.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.ibtn_ChucVu.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_ChucVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_ChucVu.IconSize = 24;
            this.ibtn_ChucVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_ChucVu.Location = new System.Drawing.Point(0, 661);
            this.ibtn_ChucVu.Name = "ibtn_ChucVu";
            this.ibtn_ChucVu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_ChucVu.Size = new System.Drawing.Size(203, 45);
            this.ibtn_ChucVu.TabIndex = 13;
            this.ibtn_ChucVu.Text = "QL Chức vụ";
            this.ibtn_ChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_ChucVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_ChucVu.UseVisualStyleBackColor = true;
            this.ibtn_ChucVu.Click += new System.EventHandler(this.ibtn_ChucVu_Click);
            // 
            // ibtn_QLTaiKhoan
            // 
            this.ibtn_QLTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_QLTaiKhoan.FlatAppearance.BorderSize = 0;
            this.ibtn_QLTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_QLTaiKhoan.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.FilePrescription;
            this.ibtn_QLTaiKhoan.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_QLTaiKhoan.IconSize = 24;
            this.ibtn_QLTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLTaiKhoan.Location = new System.Drawing.Point(0, 616);
            this.ibtn_QLTaiKhoan.Name = "ibtn_QLTaiKhoan";
            this.ibtn_QLTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_QLTaiKhoan.Size = new System.Drawing.Size(203, 45);
            this.ibtn_QLTaiKhoan.TabIndex = 12;
            this.ibtn_QLTaiKhoan.Text = "QL Tài khoản";
            this.ibtn_QLTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_QLTaiKhoan.UseVisualStyleBackColor = true;
            this.ibtn_QLTaiKhoan.Click += new System.EventHandler(this.ibtn_QLTaiKhoan_Click);
            // 
            // ibtn_QLNhanVien
            // 
            this.ibtn_QLNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_QLNhanVien.FlatAppearance.BorderSize = 0;
            this.ibtn_QLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_QLNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLNhanVien.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.ibtn_QLNhanVien.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_QLNhanVien.IconSize = 24;
            this.ibtn_QLNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLNhanVien.Location = new System.Drawing.Point(0, 571);
            this.ibtn_QLNhanVien.Name = "ibtn_QLNhanVien";
            this.ibtn_QLNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_QLNhanVien.Size = new System.Drawing.Size(203, 45);
            this.ibtn_QLNhanVien.TabIndex = 11;
            this.ibtn_QLNhanVien.Text = "QL Nhân viên";
            this.ibtn_QLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_QLNhanVien.UseVisualStyleBackColor = true;
            this.ibtn_QLNhanVien.Click += new System.EventHandler(this.ibtn_QLNhanVien_Click);
            // 
            // ibtn_QLCTTienNghi
            // 
            this.ibtn_QLCTTienNghi.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_QLCTTienNghi.FlatAppearance.BorderSize = 0;
            this.ibtn_QLCTTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_QLCTTienNghi.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLCTTienNghi.IconChar = FontAwesome.Sharp.IconChar.TvAlt;
            this.ibtn_QLCTTienNghi.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLCTTienNghi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_QLCTTienNghi.IconSize = 24;
            this.ibtn_QLCTTienNghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLCTTienNghi.Location = new System.Drawing.Point(0, 526);
            this.ibtn_QLCTTienNghi.Name = "ibtn_QLCTTienNghi";
            this.ibtn_QLCTTienNghi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_QLCTTienNghi.Size = new System.Drawing.Size(203, 45);
            this.ibtn_QLCTTienNghi.TabIndex = 10;
            this.ibtn_QLCTTienNghi.Text = "QL Chi tiết tiện nghi";
            this.ibtn_QLCTTienNghi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLCTTienNghi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_QLCTTienNghi.UseVisualStyleBackColor = true;
            this.ibtn_QLCTTienNghi.Click += new System.EventHandler(this.ibtn_QLCTTienNghi_Click);
            // 
            // ibtn_QLTienNghi
            // 
            this.ibtn_QLTienNghi.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_QLTienNghi.FlatAppearance.BorderSize = 0;
            this.ibtn_QLTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_QLTienNghi.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLTienNghi.IconChar = FontAwesome.Sharp.IconChar.ThList;
            this.ibtn_QLTienNghi.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLTienNghi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_QLTienNghi.IconSize = 24;
            this.ibtn_QLTienNghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLTienNghi.Location = new System.Drawing.Point(0, 481);
            this.ibtn_QLTienNghi.Name = "ibtn_QLTienNghi";
            this.ibtn_QLTienNghi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_QLTienNghi.Size = new System.Drawing.Size(203, 45);
            this.ibtn_QLTienNghi.TabIndex = 9;
            this.ibtn_QLTienNghi.Text = "QL Tiện nghi";
            this.ibtn_QLTienNghi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLTienNghi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_QLTienNghi.UseVisualStyleBackColor = true;
            this.ibtn_QLTienNghi.Click += new System.EventHandler(this.ibtn_QLTienNghi_Click);
            // 
            // ibtn_QLDichVu
            // 
            this.ibtn_QLDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_QLDichVu.FlatAppearance.BorderSize = 0;
            this.ibtn_QLDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_QLDichVu.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLDichVu.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            this.ibtn_QLDichVu.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLDichVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_QLDichVu.IconSize = 24;
            this.ibtn_QLDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLDichVu.Location = new System.Drawing.Point(0, 436);
            this.ibtn_QLDichVu.Name = "ibtn_QLDichVu";
            this.ibtn_QLDichVu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_QLDichVu.Size = new System.Drawing.Size(203, 45);
            this.ibtn_QLDichVu.TabIndex = 8;
            this.ibtn_QLDichVu.Text = "QL Dịch vụ";
            this.ibtn_QLDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_QLDichVu.UseVisualStyleBackColor = true;
            this.ibtn_QLDichVu.Click += new System.EventHandler(this.ibtn_QLDichVu_Click);
            // 
            // ibtn_QLLoaiDichVu
            // 
            this.ibtn_QLLoaiDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_QLLoaiDichVu.FlatAppearance.BorderSize = 0;
            this.ibtn_QLLoaiDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_QLLoaiDichVu.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLLoaiDichVu.IconChar = FontAwesome.Sharp.IconChar.WandMagic;
            this.ibtn_QLLoaiDichVu.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLLoaiDichVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_QLLoaiDichVu.IconSize = 24;
            this.ibtn_QLLoaiDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLLoaiDichVu.Location = new System.Drawing.Point(0, 391);
            this.ibtn_QLLoaiDichVu.Name = "ibtn_QLLoaiDichVu";
            this.ibtn_QLLoaiDichVu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_QLLoaiDichVu.Size = new System.Drawing.Size(203, 45);
            this.ibtn_QLLoaiDichVu.TabIndex = 7;
            this.ibtn_QLLoaiDichVu.Text = "QL Loại dịch vụ";
            this.ibtn_QLLoaiDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLLoaiDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_QLLoaiDichVu.UseVisualStyleBackColor = true;
            this.ibtn_QLLoaiDichVu.Click += new System.EventHandler(this.ibtn_QLLoaiDichVu_Click);
            // 
            // ibtn_QLPhong
            // 
            this.ibtn_QLPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_QLPhong.FlatAppearance.BorderSize = 0;
            this.ibtn_QLPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_QLPhong.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLPhong.IconChar = FontAwesome.Sharp.IconChar.HouseCircleCheck;
            this.ibtn_QLPhong.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_QLPhong.IconSize = 24;
            this.ibtn_QLPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLPhong.Location = new System.Drawing.Point(0, 346);
            this.ibtn_QLPhong.Name = "ibtn_QLPhong";
            this.ibtn_QLPhong.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_QLPhong.Size = new System.Drawing.Size(203, 45);
            this.ibtn_QLPhong.TabIndex = 6;
            this.ibtn_QLPhong.Text = "QL Phòng";
            this.ibtn_QLPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_QLPhong.UseVisualStyleBackColor = true;
            this.ibtn_QLPhong.Click += new System.EventHandler(this.ibtn_QLPhong_Click);
            // 
            // ibtn_QLLoaiPhong
            // 
            this.ibtn_QLLoaiPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_QLLoaiPhong.FlatAppearance.BorderSize = 0;
            this.ibtn_QLLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_QLLoaiPhong.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLLoaiPhong.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.ibtn_QLLoaiPhong.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLLoaiPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_QLLoaiPhong.IconSize = 24;
            this.ibtn_QLLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLLoaiPhong.Location = new System.Drawing.Point(0, 301);
            this.ibtn_QLLoaiPhong.Name = "ibtn_QLLoaiPhong";
            this.ibtn_QLLoaiPhong.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_QLLoaiPhong.Size = new System.Drawing.Size(203, 45);
            this.ibtn_QLLoaiPhong.TabIndex = 5;
            this.ibtn_QLLoaiPhong.Text = "QL Loại phòng";
            this.ibtn_QLLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLLoaiPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_QLLoaiPhong.UseVisualStyleBackColor = true;
            this.ibtn_QLLoaiPhong.Click += new System.EventHandler(this.ibtn_QLLoaiPhong_Click);
            // 
            // ibtn_QLKhachHang
            // 
            this.ibtn_QLKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_QLKhachHang.FlatAppearance.BorderSize = 0;
            this.ibtn_QLKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_QLKhachHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLKhachHang.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ibtn_QLKhachHang.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_QLKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_QLKhachHang.IconSize = 24;
            this.ibtn_QLKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLKhachHang.Location = new System.Drawing.Point(0, 256);
            this.ibtn_QLKhachHang.Name = "ibtn_QLKhachHang";
            this.ibtn_QLKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_QLKhachHang.Size = new System.Drawing.Size(203, 45);
            this.ibtn_QLKhachHang.TabIndex = 4;
            this.ibtn_QLKhachHang.Text = "QL Khách hàng";
            this.ibtn_QLKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_QLKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_QLKhachHang.UseVisualStyleBackColor = true;
            this.ibtn_QLKhachHang.Click += new System.EventHandler(this.ibtn_QLKhachHang_Click);
            // 
            // ibtn_HoaDon
            // 
            this.ibtn_HoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_HoaDon.FlatAppearance.BorderSize = 0;
            this.ibtn_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_HoaDon.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_HoaDon.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.ibtn_HoaDon.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_HoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_HoaDon.IconSize = 24;
            this.ibtn_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_HoaDon.Location = new System.Drawing.Point(0, 211);
            this.ibtn_HoaDon.Name = "ibtn_HoaDon";
            this.ibtn_HoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_HoaDon.Size = new System.Drawing.Size(203, 45);
            this.ibtn_HoaDon.TabIndex = 3;
            this.ibtn_HoaDon.Text = "Hóa đơn";
            this.ibtn_HoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_HoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_HoaDon.UseVisualStyleBackColor = true;
            this.ibtn_HoaDon.Click += new System.EventHandler(this.ibtn_HoaDon_Click);
            // 
            // ibtn_DatPhong
            // 
            this.ibtn_DatPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_DatPhong.FlatAppearance.BorderSize = 0;
            this.ibtn_DatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_DatPhong.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_DatPhong.IconChar = FontAwesome.Sharp.IconChar.BookAtlas;
            this.ibtn_DatPhong.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_DatPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_DatPhong.IconSize = 24;
            this.ibtn_DatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_DatPhong.Location = new System.Drawing.Point(0, 166);
            this.ibtn_DatPhong.Name = "ibtn_DatPhong";
            this.ibtn_DatPhong.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_DatPhong.Size = new System.Drawing.Size(203, 45);
            this.ibtn_DatPhong.TabIndex = 2;
            this.ibtn_DatPhong.Text = "Đặt phòng";
            this.ibtn_DatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_DatPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_DatPhong.UseVisualStyleBackColor = true;
            this.ibtn_DatPhong.Click += new System.EventHandler(this.ibtn_DatPhong_Click);
            // 
            // ibtn_DanhSachPhong
            // 
            this.ibtn_DanhSachPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_DanhSachPhong.FlatAppearance.BorderSize = 0;
            this.ibtn_DanhSachPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_DanhSachPhong.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_DanhSachPhong.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.ibtn_DanhSachPhong.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_DanhSachPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_DanhSachPhong.IconSize = 24;
            this.ibtn_DanhSachPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_DanhSachPhong.Location = new System.Drawing.Point(0, 121);
            this.ibtn_DanhSachPhong.Name = "ibtn_DanhSachPhong";
            this.ibtn_DanhSachPhong.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_DanhSachPhong.Size = new System.Drawing.Size(203, 45);
            this.ibtn_DanhSachPhong.TabIndex = 1;
            this.ibtn_DanhSachPhong.Text = "Phòng";
            this.ibtn_DanhSachPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_DanhSachPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_DanhSachPhong.UseVisualStyleBackColor = true;
            this.ibtn_DanhSachPhong.Click += new System.EventHandler(this.ibtn_DanhSachPhong_Click);
            // 
            // pn_AccImg
            // 
            this.pn_AccImg.Controls.Add(this.lb_TenNV);
            this.pn_AccImg.Controls.Add(this.pictureBox1);
            this.pn_AccImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_AccImg.Location = new System.Drawing.Point(0, 0);
            this.pn_AccImg.Name = "pn_AccImg";
            this.pn_AccImg.Size = new System.Drawing.Size(203, 121);
            this.pn_AccImg.TabIndex = 0;
            // 
            // lb_TenNV
            // 
            this.lb_TenNV.AutoSize = true;
            this.lb_TenNV.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_TenNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_TenNV.Location = new System.Drawing.Point(61, 100);
            this.lb_TenNV.Name = "lb_TenNV";
            this.lb_TenNV.Size = new System.Drawing.Size(56, 20);
            this.lb_TenNV.TabIndex = 1;
            this.lb_TenNV.Text = "Ten NV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pn_TitleBar
            // 
            this.pn_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pn_TitleBar.Controls.Add(this.btn_Logout);
            this.pn_TitleBar.Controls.Add(this.btn_Minimize);
            this.pn_TitleBar.Controls.Add(this.btn_Exit);
            this.pn_TitleBar.Controls.Add(this.lblTitleChildForm);
            this.pn_TitleBar.Controls.Add(this.iconCurrentChildForm);
            this.pn_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_TitleBar.Location = new System.Drawing.Point(220, 0);
            this.pn_TitleBar.Name = "pn_TitleBar";
            this.pn_TitleBar.Size = new System.Drawing.Size(1011, 45);
            this.pn_TitleBar.TabIndex = 1;
            this.pn_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_TitleBar_MouseDown);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Logout.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Logout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Logout.BorderRadius = 0;
            this.btn_Logout.BorderSize = 0;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(794, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(73, 24);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.TextColor = System.Drawing.Color.White;
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.AutoSize = true;
            this.btn_Minimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Minimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Minimize.Location = new System.Drawing.Point(956, 0);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(21, 19);
            this.btn_Minimize.TabIndex = 3;
            this.btn_Minimize.Text = "__";
            this.btn_Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Exit.Location = new System.Drawing.Point(988, 8);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(17, 19);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "X";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(51, 12);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(42, 15);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Phòng";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 24;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(21, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(24, 24);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 45);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1011, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 54);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1011, 681);
            this.panelDesktop.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 735);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.pn_TitleBar);
            this.Controls.Add(this.pn_MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.pn_MenuBar.ResumeLayout(false);
            this.pn_AccImg.ResumeLayout(false);
            this.pn_AccImg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_TitleBar.ResumeLayout(false);
            this.pn_TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pn_MenuBar;
        private Panel pn_AccImg;
        private FontAwesome.Sharp.IconButton ibtn_DanhSachPhong;
        private FontAwesome.Sharp.IconButton ibtn_QLCTTienNghi;
        private FontAwesome.Sharp.IconButton ibtn_QLTienNghi;
        private FontAwesome.Sharp.IconButton ibtn_QLDichVu;
        private FontAwesome.Sharp.IconButton ibtn_QLLoaiDichVu;
        private FontAwesome.Sharp.IconButton ibtn_QLPhong;
        private FontAwesome.Sharp.IconButton ibtn_QLLoaiPhong;
        private FontAwesome.Sharp.IconButton ibtn_QLKhachHang;
        private FontAwesome.Sharp.IconButton ibtn_HoaDon;
        private FontAwesome.Sharp.IconButton ibtn_DatPhong;
        private FontAwesome.Sharp.IconButton ibtn_QLTaiKhoan;
        private FontAwesome.Sharp.IconButton ibtn_QLNhanVien;
        private FontAwesome.Sharp.IconButton ibtn_ChucVu;
        private PictureBox pictureBox1;
        private Panel pn_TitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private Label btn_Exit;
        private Label btn_Minimize;
        private FontAwesome.Sharp.IconButton ibtn_ThongKe;
        private Label lb_TenNV;
        private RJCodeAdvance.RJControls.RJButton btn_Logout;
    }
}