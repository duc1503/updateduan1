namespace GUI.View.UserControls
{
    partial class FrmPhong
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_SearchMaPhong = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flp_PhongTang1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flp_PhongTang2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flp_PhongTang3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_TimeReset = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(254, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tìm kiếm";
            // 
            // tb_SearchMaPhong
            // 
            this.tb_SearchMaPhong.Location = new System.Drawing.Point(335, 94);
            this.tb_SearchMaPhong.Margin = new System.Windows.Forms.Padding(0);
            this.tb_SearchMaPhong.Name = "tb_SearchMaPhong";
            this.tb_SearchMaPhong.PlaceholderText = "    Tìm phòng";
            this.tb_SearchMaPhong.Size = new System.Drawing.Size(379, 23);
            this.tb_SearchMaPhong.TabIndex = 7;
            this.tb_SearchMaPhong.TextChanged += new System.EventHandler(this.tb_SearchMaPhong_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(24, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 506);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tabPage1.Controls.Add(this.flp_PhongTang1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(942, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tầng 1";
            // 
            // flp_PhongTang1
            // 
            this.flp_PhongTang1.AutoScroll = true;
            this.flp_PhongTang1.Location = new System.Drawing.Point(9, 14);
            this.flp_PhongTang1.Name = "flp_PhongTang1";
            this.flp_PhongTang1.Size = new System.Drawing.Size(916, 452);
            this.flp_PhongTang1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tabPage2.Controls.Add(this.flp_PhongTang2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(942, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tầng 2";
            // 
            // flp_PhongTang2
            // 
            this.flp_PhongTang2.AutoScroll = true;
            this.flp_PhongTang2.Location = new System.Drawing.Point(9, 14);
            this.flp_PhongTang2.Name = "flp_PhongTang2";
            this.flp_PhongTang2.Size = new System.Drawing.Size(919, 450);
            this.flp_PhongTang2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tabPage3.Controls.Add(this.flp_PhongTang3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(942, 478);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tầng 3";
            // 
            // flp_PhongTang3
            // 
            this.flp_PhongTang3.AutoScroll = true;
            this.flp_PhongTang3.Location = new System.Drawing.Point(9, 12);
            this.flp_PhongTang3.Name = "flp_PhongTang3";
            this.flp_PhongTang3.Size = new System.Drawing.Size(917, 451);
            this.flp_PhongTang3.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(899, 70);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Reset Now";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(835, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Second";
            // 
            // lb_TimeReset
            // 
            this.lb_TimeReset.AutoSize = true;
            this.lb_TimeReset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_TimeReset.ForeColor = System.Drawing.Color.Transparent;
            this.lb_TimeReset.Location = new System.Drawing.Point(804, 73);
            this.lb_TimeReset.Name = "lb_TimeReset";
            this.lb_TimeReset.Size = new System.Drawing.Size(25, 20);
            this.lb_TimeReset.TabIndex = 12;
            this.lb_TimeReset.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(37, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 17);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(210, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 17);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(506, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(38, 17);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Location = new System.Drawing.Point(723, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(38, 17);
            this.panel4.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(81, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Phòng trống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(767, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Phòng đang dọn dẹp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(550, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phòng đang có khách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(254, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Phòng sắp có khách thuê (1 hour)";
            // 
            // FrmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(998, 638);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_TimeReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tb_SearchMaPhong);
            this.Controls.Add(this.label4);
            this.Name = "FrmPhong";
            this.Text = "FrmPhong";
            this.Load += new System.EventHandler(this.FrmPhong_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private TextBox tb_SearchMaPhong;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private FlowLayoutPanel flp_PhongTang1;
        private FlowLayoutPanel flp_PhongTang2;
        private FlowLayoutPanel flp_PhongTang3;
        private Button btn_Refresh;
        private Label label5;
        private Label lb_TimeReset;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
    }
}