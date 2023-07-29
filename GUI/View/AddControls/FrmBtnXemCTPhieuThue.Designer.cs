namespace GUI.View.AddControls
{
    partial class FrmBtnXemCTPhieuThue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ThueThemPhong = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_NgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.lb_TenNV = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.dtg_ChiTietPhieuThue = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HuyXemCTTienNghi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChiTietPhieuThue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_ThueThemPhong);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dtp_NgayLapPhieu);
            this.panel1.Controls.Add(this.lb_TenNV);
            this.panel1.Controls.Add(this.lb_TenKH);
            this.panel1.Controls.Add(this.dtg_ChiTietPhieuThue);
            this.panel1.Location = new System.Drawing.Point(65, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 365);
            this.panel1.TabIndex = 0;
            // 
            // btn_ThueThemPhong
            // 
            this.btn_ThueThemPhong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThueThemPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThueThemPhong.FlatAppearance.BorderSize = 0;
            this.btn_ThueThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThueThemPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThueThemPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThueThemPhong.Location = new System.Drawing.Point(450, 321);
            this.btn_ThueThemPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThueThemPhong.Name = "btn_ThueThemPhong";
            this.btn_ThueThemPhong.Size = new System.Drawing.Size(151, 30);
            this.btn_ThueThemPhong.TabIndex = 18;
            this.btn_ThueThemPhong.Text = "Thêm phòng";
            this.btn_ThueThemPhong.UseVisualStyleBackColor = false;
            this.btn_ThueThemPhong.Click += new System.EventHandler(this.btn_ThueThemPhong_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(576, 31);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 34);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 34);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_NgayLapPhieu
            // 
            this.dtp_NgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLapPhieu.Location = new System.Drawing.Point(327, 35);
            this.dtp_NgayLapPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_NgayLapPhieu.Name = "dtp_NgayLapPhieu";
            this.dtp_NgayLapPhieu.Size = new System.Drawing.Size(124, 23);
            this.dtp_NgayLapPhieu.TabIndex = 3;
            // 
            // lb_TenNV
            // 
            this.lb_TenNV.AutoSize = true;
            this.lb_TenNV.Location = new System.Drawing.Point(620, 42);
            this.lb_TenNV.Name = "lb_TenNV";
            this.lb_TenNV.Size = new System.Drawing.Size(82, 15);
            this.lb_TenNV.TabIndex = 2;
            this.lb_TenNV.Text = "Ten Nhân viên";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Location = new System.Drawing.Point(89, 30);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(91, 15);
            this.lb_TenKH.TabIndex = 1;
            this.lb_TenKH.Text = "Tên Khách hàng";
            // 
            // dtg_ChiTietPhieuThue
            // 
            this.dtg_ChiTietPhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ChiTietPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ChiTietPhieuThue.Location = new System.Drawing.Point(53, 82);
            this.dtg_ChiTietPhieuThue.Name = "dtg_ChiTietPhieuThue";
            this.dtg_ChiTietPhieuThue.RowHeadersWidth = 51;
            this.dtg_ChiTietPhieuThue.RowTemplate.Height = 25;
            this.dtg_ChiTietPhieuThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_ChiTietPhieuThue.Size = new System.Drawing.Size(579, 225);
            this.dtg_ChiTietPhieuThue.TabIndex = 0;
            this.dtg_ChiTietPhieuThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ChiTietPhieuThue_CellClick);
            this.dtg_ChiTietPhieuThue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ChiTietPhieuThue_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Chi Tiết Phiếu Thuê";
            // 
            // btn_HuyXemCTTienNghi
            // 
            this.btn_HuyXemCTTienNghi.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_HuyXemCTTienNghi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HuyXemCTTienNghi.FlatAppearance.BorderSize = 0;
            this.btn_HuyXemCTTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyXemCTTienNghi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HuyXemCTTienNghi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_HuyXemCTTienNghi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_HuyXemCTTienNghi.Location = new System.Drawing.Point(740, 564);
            this.btn_HuyXemCTTienNghi.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HuyXemCTTienNghi.Name = "btn_HuyXemCTTienNghi";
            this.btn_HuyXemCTTienNghi.Size = new System.Drawing.Size(110, 40);
            this.btn_HuyXemCTTienNghi.TabIndex = 42;
            this.btn_HuyXemCTTienNghi.Text = "Hủy";
            this.btn_HuyXemCTTienNghi.UseVisualStyleBackColor = false;
            this.btn_HuyXemCTTienNghi.Click += new System.EventHandler(this.btn_HuyXemCTTienNghi_Click);
            // 
            // FrmBtnXemCTPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 591);
            this.Controls.Add(this.btn_HuyXemCTTienNghi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBtnXemCTPhieuThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBtnXemCTPhieuThue";
            this.Load += new System.EventHandler(this.FrmBtnXemCTPhieuThue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChiTietPhieuThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dtg_ChiTietPhieuThue;
        private Label lb_TenNV;
        private Label lb_TenKH;
        private DateTimePicker dtp_NgayLapPhieu;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;

        private Button btn_HuyXemCTTienNghi;

        private Button btn_ThueThemPhong;

    }
}