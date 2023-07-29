namespace GUI.View.UserControls
{
    partial class FrmQLTienNghi
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
            this.btn_ThemTienNghi = new System.Windows.Forms.Button();
            this.tbt_SearchUseName = new System.Windows.Forms.TextBox();
            this.dtg_DanhSachTienNghi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachTienNghi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemTienNghi
            // 
            this.btn_ThemTienNghi.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemTienNghi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemTienNghi.FlatAppearance.BorderSize = 0;
            this.btn_ThemTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemTienNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemTienNghi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemTienNghi.Location = new System.Drawing.Point(817, 56);
            this.btn_ThemTienNghi.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemTienNghi.Name = "btn_ThemTienNghi";
            this.btn_ThemTienNghi.Size = new System.Drawing.Size(206, 53);
            this.btn_ThemTienNghi.TabIndex = 21;
            this.btn_ThemTienNghi.Text = "Thêm tiện nghi";
            this.btn_ThemTienNghi.UseVisualStyleBackColor = false;
            this.btn_ThemTienNghi.Click += new System.EventHandler(this.btn_ThemTienNghi_Click);
            // 
            // tbt_SearchUseName
            // 
            this.tbt_SearchUseName.Location = new System.Drawing.Point(101, 82);
            this.tbt_SearchUseName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchUseName.Name = "tbt_SearchUseName";
            this.tbt_SearchUseName.PlaceholderText = "    Nhập tên tện nghi cần tìm";
            this.tbt_SearchUseName.Size = new System.Drawing.Size(342, 27);
            this.tbt_SearchUseName.TabIndex = 20;
            this.tbt_SearchUseName.TextChanged += new System.EventHandler(this.tbt_SearchUseName_TextChanged);
            // 
            // dtg_DanhSachTienNghi
            // 
            this.dtg_DanhSachTienNghi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachTienNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachTienNghi.Location = new System.Drawing.Point(101, 153);
            this.dtg_DanhSachTienNghi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_DanhSachTienNghi.Name = "dtg_DanhSachTienNghi";
            this.dtg_DanhSachTienNghi.RowHeadersWidth = 51;
            this.dtg_DanhSachTienNghi.RowTemplate.Height = 25;
            this.dtg_DanhSachTienNghi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachTienNghi.Size = new System.Drawing.Size(922, 643);
            this.dtg_DanhSachTienNghi.TabIndex = 19;
            this.dtg_DanhSachTienNghi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachTienNghi_CellClick);
            this.dtg_DanhSachTienNghi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachTienNghi_CellContentClick);
            // 
            // FrmQLTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1141, 749);
            this.Controls.Add(this.btn_ThemTienNghi);
            this.Controls.Add(this.tbt_SearchUseName);
            this.Controls.Add(this.dtg_DanhSachTienNghi);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQLTienNghi";
            this.Text = "FrmQLTienNghi";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachTienNghi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ThemTienNghi;
        private TextBox tbt_SearchUseName;
        private DataGridView dtg_DanhSachTienNghi;
    }
}