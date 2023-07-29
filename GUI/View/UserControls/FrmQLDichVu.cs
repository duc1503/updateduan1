using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
using GUI.View.AddControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.View.UserControls
{
    public partial class FrmQLDichVu : Form
    {
        private IQLDichVuService _iQLDichVuService;

        public Guid IdDichVuSelected { get; set; }
        public string MaDichVuSelected;
        public string TenDichVuSelected;
        public int GiaSelected;
        public Guid IDLoaiDichVuSelected;
        public string TenLoaiDichVuSelected;
        public FrmQLDichVu()
        {
            InitializeComponent();
            _iQLDichVuService = new QLDichVuService();
            LoadData(_iQLDichVuService.GetAll());
        }

        private void btn_ThemDichVu_Click(object sender, EventArgs e)
        {
            FrmBtnThemDichVu dv = new FrmBtnThemDichVu();
            dv.ShowDialog();
        }

        private void LoadData(List<DichVuView> lst) 
        {
            dtg_DanhSachDichVu.ColumnCount = 6;
            dtg_DanhSachDichVu.Rows.Clear();
            dtg_DanhSachDichVu.Columns[0].Name = "ID dịch vụ";
            dtg_DanhSachDichVu.Columns[0].Visible = false;
            dtg_DanhSachDichVu.Columns[1].Name = "Mã dịch vụ";
            dtg_DanhSachDichVu.Columns[2].Name = "Tên dịch vụ";
            dtg_DanhSachDichVu.Columns[3].Name = "Giá dịch vụ";
            dtg_DanhSachDichVu.Columns[4].Name = "ID loại dịch vụ";
            dtg_DanhSachDichVu.Columns[4].Visible = false;
            dtg_DanhSachDichVu.Columns[5].Name = "Tên loại dịch vụ";


            foreach (var x in lst.OrderBy(p => p.MaDichVu))
            {
                dtg_DanhSachDichVu.Rows.Add(x.Id,x.MaDichVu,x.TenDichVu,x.Gia,x.IDLoaiDichVu,x.TenLoaiDV);
            }

            // Thêm button control vào datadridview
            DataGridViewButtonColumn cbn_ChucNangSua = new DataGridViewButtonColumn();
            cbn_ChucNangSua.HeaderText = "Chức năng sửa";
            cbn_ChucNangSua.Text = "Sửa";
            cbn_ChucNangSua.Name = "btn_SuaDichVu";
            cbn_ChucNangSua.UseColumnTextForButtonValue = true;
            dtg_DanhSachDichVu.Columns.Add(cbn_ChucNangSua);

            DataGridViewButtonColumn cbn_ChucNangXoa = new DataGridViewButtonColumn();
            cbn_ChucNangXoa.HeaderText = "Chức năng xóa";
            cbn_ChucNangXoa.Text = "Xóa";
            cbn_ChucNangXoa.Name = "btn_XoaDichVu";
            cbn_ChucNangXoa.UseColumnTextForButtonValue = true;
            dtg_DanhSachDichVu.Columns.Add(cbn_ChucNangXoa);
        }

        private void dtg_DanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DanhSachDichVu.Rows.Count - 1)
            {
                return;
            }
            IdDichVuSelected = Guid.Parse(Convert.ToString(dtg_DanhSachDichVu.Rows[rd].Cells[0].Value));
            MaDichVuSelected = Convert.ToString(dtg_DanhSachDichVu.Rows[rd].Cells[1].Value);
            TenDichVuSelected = Convert.ToString(dtg_DanhSachDichVu.Rows[rd].Cells[2].Value);
            GiaSelected = Convert.ToInt32(dtg_DanhSachDichVu.Rows[rd].Cells[3].Value);
            IDLoaiDichVuSelected = Guid.Parse(Convert.ToString(dtg_DanhSachDichVu.Rows[rd].Cells[4].Value));
            TenLoaiDichVuSelected = Convert.ToString(dtg_DanhSachDichVu.Rows[rd].Cells[5].Value);
        }

        private void dtg_DanhSachDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DanhSachDichVu.Columns[e.ColumnIndex].Name == "btn_SuaDichVu")
            {
                // Open Form BtnSuaPhong
                FrmBtnSuaDichVu btnsualtn = new FrmBtnSuaDichVu();
                // Đấy dữ liệu vừa cell click sang các prop bên form BtnSuaPhong
                btnsualtn.Id = IdDichVuSelected;
                btnsualtn.MaDichVu = MaDichVuSelected;
                btnsualtn.TenDichVu = TenDichVuSelected;
                btnsualtn.Gia = GiaSelected;
                btnsualtn.IDLoaiDichVu = IDLoaiDichVuSelected;
                btnsualtn.TenLoaiDV = TenLoaiDichVuSelected;
                btnsualtn.ShowDialog();
            }
            if (dtg_DanhSachDichVu.Columns[e.ColumnIndex].Name == "btn_XoaDichVu")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dịch vụ này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DichVuView pv = new DichVuView();
                    pv.Id = IdDichVuSelected;
                    MessageBox.Show(_iQLDichVuService.Delete(pv));
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Xóa dịch vụ thất bại");
                }
            }
        }



        private void tbt_SearchServicesName_TextChanged(object sender, EventArgs e)
        {
            LoadData(_iQLDichVuService.Sreach(tbt_SearchServicesName.Text));
        }
    }
}
