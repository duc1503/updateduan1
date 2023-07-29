using BUS.IServices;
using BUS.Services;
using GUI.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmLogin2 : Form
    {
        IQLTaiKhoanServices _iqLTaiKhoanServices;
        public FrmLogin2()
        {
            InitializeComponent();
            _iqLTaiKhoanServices= new QLTaiKhoanServices();
            Tb_Matkhau.PasswordChar = true;
        }

        private void tgl_Switch_CheckedChanged(object sender, EventArgs e)
        {
            if (tgl_Switch.Checked)
            {
                Tb_Matkhau.PasswordChar=false;
            }
            else
            {
                Tb_Matkhau.PasswordChar = true;
            }
        }

        private void Bt_Dangnhap_Click(object sender, EventArgs e)
        {
            // T vũ chỉ làm login chứ đừng có đụng vào bất cứ cái gì kể cả design hay hiệu ứng cho t nhờ nhé
            string tk = tb_Taikhoan.Texts;
            string mk = Tb_Matkhau.Texts;
            var ttk = _iqLTaiKhoanServices.GetAll().FirstOrDefault(p => p.TenTaiKhoan == tb_Taikhoan.Texts);
            if (ttk != null)
            {
                if (ttk.MatKhau == Tb_Matkhau.Texts)
                {
                    this.Hide();
                    FrmMain fm = new FrmMain(ttk);
                    fm.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Mật Khẩu không đúng, Vui lòng nhập lại", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập không đúng, Vui Lòng Nhập Lại","Thông Báo");
            }
        }
    }
}
