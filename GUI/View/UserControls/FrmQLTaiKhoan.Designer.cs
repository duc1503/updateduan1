namespace GUI.View.UserControls
{
    partial class FrmQLTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ThemTaiKhoan = new System.Windows.Forms.Button();
            this.tbt_SearchAccountName = new System.Windows.Forms.TextBox();
            this.dtg_DanhSachTaiKhoan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemTaiKhoan
            // 
            this.btn_ThemTaiKhoan.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btn_ThemTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemTaiKhoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemTaiKhoan.Location = new System.Drawing.Point(914, 56);
            this.btn_ThemTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemTaiKhoan.Name = "btn_ThemTaiKhoan";
            this.btn_ThemTaiKhoan.Size = new System.Drawing.Size(206, 53);
            this.btn_ThemTaiKhoan.TabIndex = 24;
            this.btn_ThemTaiKhoan.Text = "Thêm tài khoản";
            this.btn_ThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_ThemTaiKhoan.Click += new System.EventHandler(this.btn_ThemTaiKhoan_Click);
            // 
            // tbt_SearchAccountName
            // 
            this.tbt_SearchAccountName.Location = new System.Drawing.Point(104, 82);
            this.tbt_SearchAccountName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchAccountName.Name = "tbt_SearchAccountName";
            this.tbt_SearchAccountName.PlaceholderText = "    Tìm theo tài khoản";
            this.tbt_SearchAccountName.Size = new System.Drawing.Size(342, 27);
            this.tbt_SearchAccountName.TabIndex = 23;
            this.tbt_SearchAccountName.TextChanged += new System.EventHandler(this.tbt_SearchAccountName_TextChanged);
            // 
            // dtg_DanhSachTaiKhoan
            // 
            this.dtg_DanhSachTaiKhoan.AllowUserToOrderColumns = true;
            this.dtg_DanhSachTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_DanhSachTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_DanhSachTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_DanhSachTaiKhoan.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_DanhSachTaiKhoan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_DanhSachTaiKhoan.EnableHeadersVisualStyles = false;
            this.dtg_DanhSachTaiKhoan.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg_DanhSachTaiKhoan.Location = new System.Drawing.Point(104, 133);
            this.dtg_DanhSachTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_DanhSachTaiKhoan.Name = "dtg_DanhSachTaiKhoan";
            this.dtg_DanhSachTaiKhoan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtg_DanhSachTaiKhoan.RowHeadersWidth = 51;
            this.dtg_DanhSachTaiKhoan.RowTemplate.Height = 25;
            this.dtg_DanhSachTaiKhoan.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dtg_DanhSachTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachTaiKhoan.Size = new System.Drawing.Size(1016, 643);
            this.dtg_DanhSachTaiKhoan.StandardTab = true;
            this.dtg_DanhSachTaiKhoan.TabIndex = 22;
            this.dtg_DanhSachTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachTaiKhoan_CellClick);
            this.dtg_DanhSachTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachTaiKhoan_CellContentClick);
            // 
            // FrmQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1141, 749);
            this.Controls.Add(this.btn_ThemTaiKhoan);
            this.Controls.Add(this.tbt_SearchAccountName);
            this.Controls.Add(this.dtg_DanhSachTaiKhoan);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQLTaiKhoan";
            this.Text = "FrmQLTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ThemTaiKhoan;
        private TextBox tbt_SearchAccountName;
        private DataGridView dtg_DanhSachTaiKhoan;
    }
}