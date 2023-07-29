using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.IServices;
using BUS.Services;
using GUI.View.UserControls;

namespace GUI.View
{
    public partial class FrmLogin : Form
    {
        private IQLTaiKhoanServices _iqLTaiKhoanServices;
        public FrmLogin()
        {
            InitializeComponent();
            _iqLTaiKhoanServices = new QLTaiKhoanServices();
            lb_tbsaittk.Visible= false;
            lb_tbsaimk.Visible = false;
        }
        


private void Bt_Dangnhap_Click_1(object sender, EventArgs e)
        {

            string tk = Tb_Taikhoan.Texts;
            string mk = Tb_Matkhau.Texts;
            var ttk = _iqLTaiKhoanServices.GetAll().FirstOrDefault(p => p.TenTaiKhoan == Tb_Taikhoan.Texts);
            if(ttk!= null)
            {
                if(ttk.MatKhau==Tb_Matkhau.Texts)
                {
                    if (ttk.CapDoQuyen == 1)
                    {
                       /* saveInfor(tk,mk); */
                        
                        MessageBox.Show("Chào mừng admin");
                        this.Hide();
                        FrmMain fm = new FrmMain(ttk);
                        fm.ShowDialog();
                    } else if( ttk.CapDoQuyen==2)
                    {
                        
                        MessageBox.Show("Chào mừng Quản lý");
                        this.Hide();
                        FrmMain fm = new FrmMain(ttk);
                        fm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Chào mừng nhân viên");
                        this.Hide();
                        FrmMain fm = new FrmMain(ttk);
                        
                        fm.ShowDialog();
                    }
                }
                else
                {
                    lb_tbsaittk.Visible = false;
                    lb_tbsaimk.Visible = true;
                }
            }
            else
            {
                lb_tbsaittk.Visible = true;
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Tb_Matkhau__TextChanged(object sender, EventArgs e)
        {
            
            if (Tb_Matkhau.Texts != "")
            {
                icon_seemk.Visible = true;
            } else
            {
                icon_seemk.Visible = false;
            }

        }


        private void icon_seemk_Click(object sender, EventArgs e)
        {
            if(Tb_Matkhau.PasswordChar == false)
            {
                Tb_Matkhau.PasswordChar=true;
            }
            else
            {
                Tb_Matkhau.PasswordChar= false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
