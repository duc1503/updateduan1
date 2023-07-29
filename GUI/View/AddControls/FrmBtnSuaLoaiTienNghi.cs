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
    
    public partial class FrmBtnSuaLoaiTienNghi : Form
    {
        public send_ltn _send;
        private IQLLoaiTienNghiService _iqlLoaiTienNghi;
        private IQLChiTietTienNghiService iqlChiTietTienNghiService;
        private Validations val;
        
        public Guid IdLoaiTiennghi { get; set; }

        public string MaLoaiTienNghi { get; set; }
        public string TenLoaiTienNghi { get; set; }
        public FrmBtnSuaLoaiTienNghi()
        {
            InitializeComponent();
            _iqlLoaiTienNghi = new QLLoaiTienNghiService();
            iqlChiTietTienNghiService = new QLChiTietTienNghiService();
        }
        public FrmBtnSuaLoaiTienNghi(send_ltn send)
        {
            InitializeComponent();
            _send= send;
            _iqlLoaiTienNghi = new QLLoaiTienNghiService();
            iqlChiTietTienNghiService = new QLChiTietTienNghiService();
            val = new Validations();
        }

        private void btn_SuaLoaiTienNghi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn sửa loại tiện nghi này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoaiTienNghiView ltn = new LoaiTienNghiView();
                ltn.ID = IdLoaiTiennghi;
                ltn.MaLoaiTienNghi = tb_maLoaiTienNghi.Text;
                ltn.TenLoaiTienNghi = tb_tenLoaiTienNghi.Text;
                MessageBox.Show(_iqlLoaiTienNghi.Update(ltn)); 
                _send(_iqlLoaiTienNghi.GetAll());
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy sửa loại tiện nghi này");
            }
        }

        private void FrmBtnSuaLoaiTienNghi_Load(object sender, EventArgs e)
        {
            tb_maLoaiTienNghi.Text = MaLoaiTienNghi;
            tb_tenLoaiTienNghi.Text = TenLoaiTienNghi;
        }

        private void btn_HuySuaLoaiTienNghi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
