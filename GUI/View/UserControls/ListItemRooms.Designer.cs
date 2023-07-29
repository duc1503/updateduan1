namespace GUI.View.UserControls
{
    partial class ListItemRooms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_MaPhong = new System.Windows.Forms.Label();
            this.lb_Gia = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.lb_DonDep = new System.Windows.Forms.Label();
            this.lb_TenLoaiPhong = new System.Windows.Forms.Label();
            this.lb_IdRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_MaPhong
            // 
            this.lb_MaPhong.AutoSize = true;
            this.lb_MaPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_MaPhong.ForeColor = System.Drawing.Color.White;
            this.lb_MaPhong.Location = new System.Drawing.Point(0, 3);
            this.lb_MaPhong.Name = "lb_MaPhong";
            this.lb_MaPhong.Size = new System.Drawing.Size(85, 21);
            this.lb_MaPhong.TabIndex = 0;
            this.lb_MaPhong.Text = "Mã phòng";
            // 
            // lb_Gia
            // 
            this.lb_Gia.AutoSize = true;
            this.lb_Gia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Gia.Location = new System.Drawing.Point(3, 67);
            this.lb_Gia.Name = "lb_Gia";
            this.lb_Gia.Size = new System.Drawing.Size(71, 17);
            this.lb_Gia.TabIndex = 1;
            this.lb_Gia.Text = "Giá phòng";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TenKH.ForeColor = System.Drawing.Color.Black;
            this.lb_TenKH.Location = new System.Drawing.Point(3, 37);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(51, 17);
            this.lb_TenKH.TabIndex = 2;
            this.lb_TenKH.Text = "Ten KH";
            // 
            // lb_DonDep
            // 
            this.lb_DonDep.AutoSize = true;
            this.lb_DonDep.Location = new System.Drawing.Point(91, 69);
            this.lb_DonDep.Name = "lb_DonDep";
            this.lb_DonDep.Size = new System.Drawing.Size(67, 15);
            this.lb_DonDep.TabIndex = 5;
            this.lb_DonDep.Text = "TT Don dep";
            // 
            // lb_TenLoaiPhong
            // 
            this.lb_TenLoaiPhong.AutoSize = true;
            this.lb_TenLoaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TenLoaiPhong.ForeColor = System.Drawing.Color.Transparent;
            this.lb_TenLoaiPhong.Location = new System.Drawing.Point(91, 8);
            this.lb_TenLoaiPhong.Name = "lb_TenLoaiPhong";
            this.lb_TenLoaiPhong.Size = new System.Drawing.Size(98, 17);
            this.lb_TenLoaiPhong.TabIndex = 6;
            this.lb_TenLoaiPhong.Text = "Ten loại phòng";
            // 
            // lb_IdRoom
            // 
            this.lb_IdRoom.AutoSize = true;
            this.lb_IdRoom.Location = new System.Drawing.Point(172, 37);
            this.lb_IdRoom.Name = "lb_IdRoom";
            this.lb_IdRoom.Size = new System.Drawing.Size(17, 15);
            this.lb_IdRoom.TabIndex = 7;
            this.lb_IdRoom.Text = "Id";
            // 
            // ListItemRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.lb_IdRoom);
            this.Controls.Add(this.lb_TenLoaiPhong);
            this.Controls.Add(this.lb_DonDep);
            this.Controls.Add(this.lb_TenKH);
            this.Controls.Add(this.lb_Gia);
            this.Controls.Add(this.lb_MaPhong);
            this.Name = "ListItemRooms";
            this.Size = new System.Drawing.Size(219, 94);
            this.Click += new System.EventHandler(this.ListItemRooms_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_MaPhong;
        private Label lb_Gia;
        private Label lb_TenKH;
        private Label lb_DonDep;
        private Label lb_TenLoaiPhong;
        private Label lb_IdRoom;
    }
}
