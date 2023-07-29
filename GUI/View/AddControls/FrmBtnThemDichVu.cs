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
    public partial class FrmBtnThemDichVu : Form
    {
        private IQLDichVuService _iQDichVuService;
        private Validations val;
        private IQLLoaiDichVuService _iQLLoaiDichVuService;

        public FrmBtnThemDichVu()
        {
            InitializeComponent();
            _iQDichVuService = new QLDichVuService();
            _iQLLoaiDichVuService = new QLLoaiDichVuService();
            LoadCBB();
            val= new Validations();
        }

        private void LoadCBB()
        {
            var lst = _iQLLoaiDichVuService.GetAll();
            foreach (var x in lst)
            {
                cbb_TenLoaiDichVu.Items.Add(x.TenLoaiDichVu);
            }
        }
        private void btn_ThemDichVu_Click(object sender, EventArgs e)
        {
            DialogResult dls = MessageBox.Show("Bạn có muốn thêm dịch vụ này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dls == DialogResult.Yes)
            {
                if (val.CheckRong(tb_TenDichVu.Text) == false || val.CheckRong(tb_MaDichVu.Text) == false || val.CheckRong(tb_MaDichVu.Text) == false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                    return;
                }
                var ldv = new DichVuView()
                {
                    
                    Id = Guid.NewGuid(),
                    TenDichVu = tb_TenDichVu.Text,
                    MaDichVu = tb_MaDichVu.Text,
                    Gia = Convert.ToInt32(tb_GiaDichVu.Text),
                    TenLoaiDV = cbb_TenLoaiDichVu.Text,
                    IDLoaiDichVu = _iQLLoaiDichVuService.GetAll().FirstOrDefault(x => x.TenLoaiDichVu == cbb_TenLoaiDichVu.Text).ID
                };
                MessageBox.Show(_iQDichVuService.Add(ldv));
            }
            else
            {
                MessageBox.Show("Bạn đã không thêm dịch vụ này");
            }
        }

        private void btn_HuyDichVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
