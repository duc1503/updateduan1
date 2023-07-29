namespace GUI.View.AddControls
{
    partial class FrmBtnEditDetailPhong
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
            this.dtg_DanhSachCTTNPhong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HuyCapNhatPhongCTTN = new System.Windows.Forms.Button();
            this.btn_CapNhatPhongCTTN = new System.Windows.Forms.Button();
            this.lb_TenPhongCTTN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_DanhSachCTTNTrong = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachCTTNPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachCTTNTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_DanhSachCTTNPhong
            // 
            this.dtg_DanhSachCTTNPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachCTTNPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachCTTNPhong.Location = new System.Drawing.Point(495, 113);
            this.dtg_DanhSachCTTNPhong.Name = "dtg_DanhSachCTTNPhong";
            this.dtg_DanhSachCTTNPhong.RowTemplate.Height = 25;
            this.dtg_DanhSachCTTNPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachCTTNPhong.Size = new System.Drawing.Size(409, 280);
            this.dtg_DanhSachCTTNPhong.TabIndex = 0;
            this.dtg_DanhSachCTTNPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachCTTNPhong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Chi tiết tiện nghi trong phòng";
            // 
            // btn_HuyCapNhatPhongCTTN
            // 
            this.btn_HuyCapNhatPhongCTTN.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_HuyCapNhatPhongCTTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HuyCapNhatPhongCTTN.FlatAppearance.BorderSize = 0;
            this.btn_HuyCapNhatPhongCTTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyCapNhatPhongCTTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HuyCapNhatPhongCTTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_HuyCapNhatPhongCTTN.Location = new System.Drawing.Point(391, 237);
            this.btn_HuyCapNhatPhongCTTN.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HuyCapNhatPhongCTTN.Name = "btn_HuyCapNhatPhongCTTN";
            this.btn_HuyCapNhatPhongCTTN.Size = new System.Drawing.Size(96, 30);
            this.btn_HuyCapNhatPhongCTTN.TabIndex = 24;
            this.btn_HuyCapNhatPhongCTTN.Text = "Hủy";
            this.btn_HuyCapNhatPhongCTTN.UseVisualStyleBackColor = false;
            this.btn_HuyCapNhatPhongCTTN.Click += new System.EventHandler(this.btn_HuyCapNhatPhongCTTN_Click);
            // 
            // btn_CapNhatPhongCTTN
            // 
            this.btn_CapNhatPhongCTTN.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_CapNhatPhongCTTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CapNhatPhongCTTN.FlatAppearance.BorderSize = 0;
            this.btn_CapNhatPhongCTTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhatPhongCTTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CapNhatPhongCTTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CapNhatPhongCTTN.Location = new System.Drawing.Point(391, 191);
            this.btn_CapNhatPhongCTTN.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CapNhatPhongCTTN.Name = "btn_CapNhatPhongCTTN";
            this.btn_CapNhatPhongCTTN.Size = new System.Drawing.Size(96, 30);
            this.btn_CapNhatPhongCTTN.TabIndex = 25;
            this.btn_CapNhatPhongCTTN.Text = "Cập nhật";
            this.btn_CapNhatPhongCTTN.UseVisualStyleBackColor = false;
            this.btn_CapNhatPhongCTTN.Click += new System.EventHandler(this.btn_CapNhatPhongCTTN_Click);
            // 
            // lb_TenPhongCTTN
            // 
            this.lb_TenPhongCTTN.AutoSize = true;
            this.lb_TenPhongCTTN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TenPhongCTTN.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lb_TenPhongCTTN.Location = new System.Drawing.Point(495, 9);
            this.lb_TenPhongCTTN.Name = "lb_TenPhongCTTN";
            this.lb_TenPhongCTTN.Size = new System.Drawing.Size(135, 32);
            this.lb_TenPhongCTTN.TabIndex = 26;
            this.lb_TenPhongCTTN.Text = "Tên phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Danh sách CTTN trống";
            // 
            // dtg_DanhSachCTTNTrong
            // 
            this.dtg_DanhSachCTTNTrong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachCTTNTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachCTTNTrong.Location = new System.Drawing.Point(23, 113);
            this.dtg_DanhSachCTTNTrong.Name = "dtg_DanhSachCTTNTrong";
            this.dtg_DanhSachCTTNTrong.RowTemplate.Height = 25;
            this.dtg_DanhSachCTTNTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachCTTNTrong.Size = new System.Drawing.Size(354, 280);
            this.dtg_DanhSachCTTNTrong.TabIndex = 29;
            this.dtg_DanhSachCTTNTrong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachCTTNTrong_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(521, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Danh sách CTTN trong phòng";
            // 
            // FrmBtnEditDetailPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtg_DanhSachCTTNTrong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_TenPhongCTTN);
            this.Controls.Add(this.btn_CapNhatPhongCTTN);
            this.Controls.Add(this.btn_HuyCapNhatPhongCTTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_DanhSachCTTNPhong);
            this.Name = "FrmBtnEditDetailPhong";
            this.Text = "FrmBtnEditDetailPhong";
            this.Load += new System.EventHandler(this.FrmBtnEditDetailPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachCTTNPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachCTTNTrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_DanhSachCTTNPhong;
        private Label label1;
        private Button btn_HuyCapNhatPhongCTTN;
        private Button btn_CapNhatPhongCTTN;
        private Label lb_TenPhongCTTN;
        private Label label2;
        private DataGridView dtg_DanhSachCTTNTrong;
        private Label label3;
    }
}