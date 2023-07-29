namespace GUI.View.UserControls
{
    partial class FrmQLNhanVien
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
            this.btn_ThemNhanVien = new System.Windows.Forms.Button();
            this.tbt_SearchStaffName = new System.Windows.Forms.TextBox();
            this.dtg_DanhSachNhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemNhanVien
            // 
            this.btn_ThemNhanVien.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemNhanVien.FlatAppearance.BorderSize = 0;
            this.btn_ThemNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemNhanVien.Location = new System.Drawing.Point(903, 54);
            this.btn_ThemNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemNhanVien.Name = "btn_ThemNhanVien";
            this.btn_ThemNhanVien.Size = new System.Drawing.Size(206, 53);
            this.btn_ThemNhanVien.TabIndex = 27;
            this.btn_ThemNhanVien.Text = "Thêm nhân viên";
            this.btn_ThemNhanVien.UseVisualStyleBackColor = false;
            this.btn_ThemNhanVien.Click += new System.EventHandler(this.btn_ThemNhanVien_Click);
            // 
            // tbt_SearchStaffName
            // 
            this.tbt_SearchStaffName.Location = new System.Drawing.Point(104, 80);
            this.tbt_SearchStaffName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchStaffName.Name = "tbt_SearchStaffName";
            this.tbt_SearchStaffName.PlaceholderText = "    Tìm theo nhân viên";
            this.tbt_SearchStaffName.Size = new System.Drawing.Size(342, 27);
            this.tbt_SearchStaffName.TabIndex = 26;
            this.tbt_SearchStaffName.TextChanged += new System.EventHandler(this.tbt_SearchStaffName_TextChanged);
            // 
            // dtg_DanhSachNhanVien
            // 
            this.dtg_DanhSachNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachNhanVien.Location = new System.Drawing.Point(104, 133);
            this.dtg_DanhSachNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_DanhSachNhanVien.Name = "dtg_DanhSachNhanVien";
            this.dtg_DanhSachNhanVien.RowHeadersWidth = 51;
            this.dtg_DanhSachNhanVien.RowTemplate.Height = 25;
            this.dtg_DanhSachNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachNhanVien.Size = new System.Drawing.Size(1005, 643);
            this.dtg_DanhSachNhanVien.TabIndex = 25;
            this.dtg_DanhSachNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachNhanVien_CellClick);
            this.dtg_DanhSachNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachNhanVien_CellContentClick);
            this.dtg_DanhSachNhanVien.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtg_DanhSachNhanVien_RowPostPaint);
            // 
            // FrmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1141, 749);
            this.Controls.Add(this.btn_ThemNhanVien);
            this.Controls.Add(this.tbt_SearchStaffName);
            this.Controls.Add(this.dtg_DanhSachNhanVien);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQLNhanVien";
            this.Text = "FrmQLNhanVien";
            this.Load += new System.EventHandler(this.FrmQLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ThemNhanVien;
        private TextBox tbt_SearchStaffName;
        private DataGridView dtg_DanhSachNhanVien;
    }
}