namespace GUI.View.UserControls
{
    partial class FrmThongKe
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
            this.dtg_thongke = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Nam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_thongke
            // 
            this.dtg_thongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_thongke.Location = new System.Drawing.Point(107, 167);
            this.dtg_thongke.Name = "dtg_thongke";
            this.dtg_thongke.RowHeadersWidth = 51;
            this.dtg_thongke.RowTemplate.Height = 29;
            this.dtg_thongke.Size = new System.Drawing.Size(887, 583);
            this.dtg_thongke.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmb_Nam);
            this.groupBox1.Location = new System.Drawing.Point(107, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Năm";
            // 
            // cmb_Nam
            // 
            this.cmb_Nam.FormattingEnabled = true;
            this.cmb_Nam.Location = new System.Drawing.Point(66, 26);
            this.cmb_Nam.Name = "cmb_Nam";
            this.cmb_Nam.Size = new System.Drawing.Size(185, 28);
            this.cmb_Nam.TabIndex = 0;
            this.cmb_Nam.SelectedIndexChanged += new System.EventHandler(this.cmb_Nam_SelectedIndexChanged);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1141, 851);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_thongke);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtg_thongke;
        private GroupBox groupBox1;
        private ComboBox cmb_Nam;
    }
}