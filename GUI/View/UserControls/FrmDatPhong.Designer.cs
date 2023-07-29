namespace GUI.View.UserControls
{
    partial class FrmDatPhong
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
            this.dtg_DanhSachPT = new System.Windows.Forms.DataGridView();
            this.tbt_SearchCusName = new System.Windows.Forms.TextBox();
            this.btn_DatPhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachPT)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_DanhSachPT
            // 
            this.dtg_DanhSachPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachPT.Location = new System.Drawing.Point(104, 133);
            this.dtg_DanhSachPT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_DanhSachPT.Name = "dtg_DanhSachPT";
            this.dtg_DanhSachPT.RowHeadersWidth = 51;
            this.dtg_DanhSachPT.RowTemplate.Height = 25;
            this.dtg_DanhSachPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachPT.Size = new System.Drawing.Size(963, 643);
            this.dtg_DanhSachPT.TabIndex = 0;
            this.dtg_DanhSachPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachPT_CellClick);
            this.dtg_DanhSachPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachPT_CellContentClick);
            // 
            // tbt_SearchCusName
            // 
            this.tbt_SearchCusName.Location = new System.Drawing.Point(104, 65);
            this.tbt_SearchCusName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchCusName.Name = "tbt_SearchCusName";
            this.tbt_SearchCusName.PlaceholderText = "    Tìm theo tên khách hàng";
            this.tbt_SearchCusName.Size = new System.Drawing.Size(342, 27);
            this.tbt_SearchCusName.TabIndex = 8;
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_DatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DatPhong.FlatAppearance.BorderSize = 0;
            this.btn_DatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DatPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DatPhong.Location = new System.Drawing.Point(922, 39);
            this.btn_DatPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(145, 53);
            this.btn_DatPhong.TabIndex = 9;
            this.btn_DatPhong.Text = "Đặt phòng";
            this.btn_DatPhong.UseVisualStyleBackColor = false;
            this.btn_DatPhong.Click += new System.EventHandler(this.btn_DatPhong_Click);
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1141, 851);
            this.Controls.Add(this.btn_DatPhong);
            this.Controls.Add(this.tbt_SearchCusName);
            this.Controls.Add(this.dtg_DanhSachPT);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDatPhong";
            this.Text = "FrmDatPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_DanhSachPT;
        private TextBox tbt_SearchCusName;
        private Button btn_DatPhong;
    }
}