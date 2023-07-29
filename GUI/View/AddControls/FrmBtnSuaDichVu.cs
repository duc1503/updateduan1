using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.Ultilities;

namespace GUI.View.AddControls
{
    public partial class FrmBtnSuaDichVu : Form
    {
        private IQLDichVuService _iQLDichVuService;
        private Validations Val;

        public Guid Id { get; set; }
        public string MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public int Gia { get; set; }
        public Guid IDLoaiDichVu { get; set; }
        public string TenLoaiDV { get; set; }
        public FrmBtnSuaDichVu()
        {
            InitializeComponent();
            _iQLDichVuService = new QLDichVuService();
            Val = new Validations();
        }

        private void btn_SuaDichVu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn sửa dịch vụ này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (Val.CheckRong(tb_GiaDichVu.Text) == false ||Val.CheckRong(tb_MaDichVu.Text)==false||Val.CheckRong(tb_TenDichVu.Text)==false)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                    return;
                }

                DichVuView ltn = new DichVuView();
                ltn.Id = Id;
                ltn.MaDichVu = tb_MaDichVu.Text;
                ltn.TenDichVu = tb_TenDichVu.Text;
                ltn.Gia = Convert.ToInt32(tb_GiaDichVu.Text);
                ltn.IDLoaiDichVu = IDLoaiDichVu;
                ltn.TenLoaiDV = cbb_TenLoaiDichVu.Text;
                MessageBox.Show(_iQLDichVuService.Update(ltn));
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy sửa dịch vụ này");
            }
        }

        private void FrmBtnSuaDichVu_Load(object sender, EventArgs e)
        {
            tb_MaDichVu.Text = MaDichVu;
            tb_TenDichVu.Text = TenDichVu;
            tb_GiaDichVu.Text = Gia.ToString();
            cbb_TenLoaiDichVu.Text = TenLoaiDV;
        }

        private void btn_HuySuaDichVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
