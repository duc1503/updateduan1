using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
using GUI.View.UserControls;
using BUS.Ultilities;

namespace GUI.View.AddControls
{
    public partial class FrmBtnThemLoaiTienNghi : Form
    {
        public send_ltn _send;
        private IQLLoaiTienNghiService _iqlLoaiTiennghi;
        private Validations val;
        
        public FrmBtnThemLoaiTienNghi()
        {
            InitializeComponent();
            _iqlLoaiTiennghi = new QLLoaiTienNghiService();
        }
        public FrmBtnThemLoaiTienNghi(send_ltn send)
        {
            InitializeComponent();
            _send = send;
            _iqlLoaiTiennghi = new QLLoaiTienNghiService();
            val = new Validations();
        }

        private void btn_ThemLoaiTienNghi_Click(object sender, EventArgs e)
        {
            DialogResult dls = MessageBox.Show("Bạn có muốn thêm loai tiện nghi này không?", "Thông báo", MessageBoxButtons.YesNo);
            if(dls == DialogResult.Yes)
            {
                if(val.CheckRong(tb_tenThemLoaiTienNghi.Text)==false||val.CheckRong(tb_maThemLoaiTienNghi.Text)==false) 
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                    return;
                }
                var ltn = new LoaiTienNghiView()
                {
                    ID = Guid.NewGuid(),
                    TenLoaiTienNghi = tb_tenThemLoaiTienNghi.Text,
                    MaLoaiTienNghi = tb_maThemLoaiTienNghi.Text
                };
                MessageBox.Show(_iqlLoaiTiennghi.Add(ltn));
                _send(_iqlLoaiTiennghi.GetAll());
            }
            else
            {
                MessageBox.Show("Bạn đã không thên loại tiện nghi này");
            }
        }

        private void btn_HuySuaLoaiTienNghi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
