using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.ViewModels;
using FontAwesome.Sharp;
using GUI.View.UserControls;

namespace GUI.View
{
    public partial class FrmMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public static  Guid? IdNV { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            pn_MenuBar.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public FrmMain(TaiKhoanView tk)
        {
            InitializeComponent();
            OpenChildForm(new FrmPhong());
            phanquyen(tk);
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,45);
            pn_MenuBar.Controls.Add(leftBorderBtn);
            if (tk.CapDoQuyen == 1)
            {
                lb_TenNV.Text = "ADMIN";
                IdNV = null;
            }
            else
            {
                lb_TenNV.Text = tk.TenNV;
                IdNV = tk.IDNv;               
            }
       
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region SettingMain

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(0, 255, 0);
            public static Color color8 = Color.FromArgb(0, 255, 255);
            public static Color color9 = Color.FromArgb(255, 255, 0);
            public static Color color10 = Color.FromArgb(255, 69, 0);
            public static Color color11 = Color.FromArgb(139, 0, 139);
            public static Color color12 = Color.FromArgb(255, 228, 225);

        }
        public void phanquyen(TaiKhoanView tk)
        {
            if (tk.CapDoQuyen == 3)
            {
                ibtn_QLTaiKhoan.Visible = false;
                ibtn_QLDichVu.Visible = false;
                ibtn_QLLoaiDichVu.Visible = false;
                ibtn_QLCTTienNghi.Visible = false;
                ibtn_QLTienNghi.Visible = false;
                ibtn_QLNhanVien.Visible = false;
                ibtn_ChucVu.Visible = false;
            }
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }



        private void ibtn_DanhSachPhong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FrmPhong());
        }

        private void ibtn_DatPhong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FrmDatPhong());
        }

        private void ibtn_HoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FrmHoaDon());
        }

        private void ibtn_QLKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FrmQLKhachHang());
        }

        private void ibtn_QLLoaiPhong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FrmQLLoaiPhong());
        }

        private void ibtn_QLPhong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FrmQLPhong());
        }

        private void ibtn_QLLoaiDichVu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new FrmQLLoaiDichVu());
        }

        private void ibtn_QLDichVu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new FrmQLDichVu());
        }

        private void ibtn_QLTienNghi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
            OpenChildForm(new FrmQLTienNghi());
        }

        private void ibtn_QLCTTienNghi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color10);
            OpenChildForm(new FrmQLCTTienNghi());
        }

        private void ibtn_QLNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color11);
            OpenChildForm(new FrmQLNhanVien());
        }

        private void ibtn_QLTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color12);
            OpenChildForm(new FrmQLTaiKhoan());
        }

        private void ibtn_ChucVu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FrmQLChucVu());
        }

        private void ibtn_ThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FrmThongKe());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pn_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        #endregion

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin2 login = new FrmLogin2();        
            login.Show();         
        }
    }
}
