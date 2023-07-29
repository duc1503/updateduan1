namespace GUI.View.AddControls
{
    partial class FrmUpdateCTPT
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
            this.btn_HuyCapNhatPhieuThue = new System.Windows.Forms.Button();
            this.btn_LocPhongTrong = new System.Windows.Forms.Button();
            this.dtg_DSPhongDaChon = new System.Windows.Forms.DataGridView();
            this.dtg_DSPhongTrong = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CapNhatPhieuThue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DSPhongDaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DSPhongTrong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_HuyCapNhatPhieuThue
            // 
            this.btn_HuyCapNhatPhieuThue.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_HuyCapNhatPhieuThue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HuyCapNhatPhieuThue.FlatAppearance.BorderSize = 0;
            this.btn_HuyCapNhatPhieuThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyCapNhatPhieuThue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HuyCapNhatPhieuThue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_HuyCapNhatPhieuThue.Location = new System.Drawing.Point(679, 459);
            this.btn_HuyCapNhatPhieuThue.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HuyCapNhatPhieuThue.Name = "btn_HuyCapNhatPhieuThue";
            this.btn_HuyCapNhatPhieuThue.Size = new System.Drawing.Size(80, 30);
            this.btn_HuyCapNhatPhieuThue.TabIndex = 29;
            this.btn_HuyCapNhatPhieuThue.Text = "Hủy";
            this.btn_HuyCapNhatPhieuThue.UseVisualStyleBackColor = false;
            this.btn_HuyCapNhatPhieuThue.Click += new System.EventHandler(this.btn_HuyCapNhatPhieuThue_Click);
            // 
            // btn_LocPhongTrong
            // 
            this.btn_LocPhongTrong.Location = new System.Drawing.Point(343, 67);
            this.btn_LocPhongTrong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LocPhongTrong.Name = "btn_LocPhongTrong";
            this.btn_LocPhongTrong.Size = new System.Drawing.Size(82, 22);
            this.btn_LocPhongTrong.TabIndex = 25;
            this.btn_LocPhongTrong.Text = "Lọc phòng";
            this.btn_LocPhongTrong.UseVisualStyleBackColor = true;
            this.btn_LocPhongTrong.Click += new System.EventHandler(this.btn_LocPhongTrong_Click);
            // 
            // dtg_DSPhongDaChon
            // 
            this.dtg_DSPhongDaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DSPhongDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DSPhongDaChon.Location = new System.Drawing.Point(425, 196);
            this.dtg_DSPhongDaChon.Name = "dtg_DSPhongDaChon";
            this.dtg_DSPhongDaChon.RowHeadersWidth = 51;
            this.dtg_DSPhongDaChon.RowTemplate.Height = 25;
            this.dtg_DSPhongDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DSPhongDaChon.Size = new System.Drawing.Size(300, 147);
            this.dtg_DSPhongDaChon.TabIndex = 22;
            this.dtg_DSPhongDaChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DSPhongDaChon_CellClick);
            this.dtg_DSPhongDaChon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DSPhongDaChon_CellContentClick);
            // 
            // dtg_DSPhongTrong
            // 
            this.dtg_DSPhongTrong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DSPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DSPhongTrong.Location = new System.Drawing.Point(92, 196);
            this.dtg_DSPhongTrong.Name = "dtg_DSPhongTrong";
            this.dtg_DSPhongTrong.RowHeadersWidth = 51;
            this.dtg_DSPhongTrong.RowTemplate.Height = 25;
            this.dtg_DSPhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DSPhongTrong.Size = new System.Drawing.Size(300, 146);
            this.dtg_DSPhongTrong.TabIndex = 21;
            this.dtg_DSPhongTrong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DSPhongTrong_CellClick);
            this.dtg_DSPhongTrong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DSPhongTrong_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(425, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Phòng đã chọn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(92, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Danh sách phòng trống";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_NgayKetThuc);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(92, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 53);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày trả";
            // 
            // dtp_NgayKetThuc
            // 
            this.dtp_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayKetThuc.Location = new System.Drawing.Point(6, 18);
            this.dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            this.dtp_NgayKetThuc.Size = new System.Drawing.Size(213, 23);
            this.dtp_NgayKetThuc.TabIndex = 0;
            // 
            // dtp_NgayBatDau
            // 
            this.dtp_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayBatDau.Location = new System.Drawing.Point(6, 18);
            this.dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            this.dtp_NgayBatDau.Size = new System.Drawing.Size(206, 23);
            this.dtp_NgayBatDau.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_NgayBatDau);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(99, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 53);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày nhận";
            // 
            // btn_CapNhatPhieuThue
            // 
            this.btn_CapNhatPhieuThue.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_CapNhatPhieuThue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CapNhatPhieuThue.FlatAppearance.BorderSize = 0;
            this.btn_CapNhatPhieuThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhatPhieuThue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CapNhatPhieuThue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CapNhatPhieuThue.Location = new System.Drawing.Point(560, 459);
            this.btn_CapNhatPhieuThue.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CapNhatPhieuThue.Name = "btn_CapNhatPhieuThue";
            this.btn_CapNhatPhieuThue.Size = new System.Drawing.Size(80, 30);
            this.btn_CapNhatPhieuThue.TabIndex = 28;
            this.btn_CapNhatPhieuThue.Text = "Lưu";
            this.btn_CapNhatPhieuThue.UseVisualStyleBackColor = false;
            this.btn_CapNhatPhieuThue.Click += new System.EventHandler(this.btn_CapNhatPhieuThue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(343, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thông tin phòng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_LocPhongTrong);
            this.panel1.Controls.Add(this.dtg_DSPhongDaChon);
            this.panel1.Controls.Add(this.dtg_DSPhongTrong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(84, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 372);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(396, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cập nhật phiếu thuê";
            // 
            // FrmUpdateCTPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 523);
            this.Controls.Add(this.btn_HuyCapNhatPhieuThue);
            this.Controls.Add(this.btn_CapNhatPhieuThue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdateCTPT";
            this.Text = "FrmUpdateCTPT";
            this.Load += new System.EventHandler(this.FrmUpdateCTPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DSPhongDaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DSPhongTrong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_HuyCapNhatPhieuThue;
        private Button btn_LocPhongTrong;
        private DataGridView dtg_DSPhongDaChon;
        private DataGridView dtg_DSPhongTrong;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private DateTimePicker dtp_NgayKetThuc;
        private DateTimePicker dtp_NgayBatDau;
        private GroupBox groupBox1;
        private Button btn_CapNhatPhieuThue;
        private Label label3;
        private Panel panel1;
        private Label label1;
    }
}