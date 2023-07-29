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
using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
namespace GUI.View.UserControls
{
    public delegate void send_ltn (List<LoaiTienNghiView> ltn);
    public partial class FrmQLTienNghi : Form
    {
        private IQLLoaiTienNghiService _iqlLoaiTienNghi;

        public Guid IdLoaiTienNghiSelect { get; set; }
        public string MaLoaiTienNghiSelect;
        public string TenLoaiTienNghiSelect;

        public FrmQLTienNghi()
        {
            InitializeComponent();
            _iqlLoaiTienNghi = new QLLoaiTienNghiService();
            LoadData(_iqlLoaiTienNghi.GetAll());
        }

        private void btn_ThemTienNghi_Click(object sender, EventArgs e)
        {
            FrmBtnThemLoaiTienNghi tn = new FrmBtnThemLoaiTienNghi(LoadData);
            tn.ShowDialog();

        }
        private void LoadData(List<LoaiTienNghiView> lst)
        {
            dtg_DanhSachTienNghi.ColumnCount = 3;
            dtg_DanhSachTienNghi.Rows.Clear();
            dtg_DanhSachTienNghi.Columns[0].Name = "ID";
            dtg_DanhSachTienNghi.Columns[0].Visible = false;
            dtg_DanhSachTienNghi.Columns[1].Name = "Mã loại tiện nghi";
            dtg_DanhSachTienNghi.Columns[2].Name = "Tên loại tiện nghi";
            

            foreach (var item in lst)
            {
                dtg_DanhSachTienNghi.Rows.Add(item.ID, item.MaLoaiTienNghi, item.TenLoaiTienNghi);
            }

            // Thêm button control vào datadridview
            DataGridViewButtonColumn cbn_ChucNangSua = new DataGridViewButtonColumn();
            cbn_ChucNangSua.HeaderText = "Chức năng sửa";
            cbn_ChucNangSua.Text = "Sửa";
            cbn_ChucNangSua.Name = "btn_SuaLoaiTienNghi";
            cbn_ChucNangSua.UseColumnTextForButtonValue = true;
            dtg_DanhSachTienNghi.Columns.Add(cbn_ChucNangSua);

            DataGridViewButtonColumn cbn_ChucNangXoa = new DataGridViewButtonColumn();
            cbn_ChucNangXoa.HeaderText = "Chức năng xóa";
            cbn_ChucNangXoa.Text = "Xóa";
            cbn_ChucNangXoa.Name = "btn_XoaLoaiTienNghi";
            cbn_ChucNangXoa.UseColumnTextForButtonValue = true;
            dtg_DanhSachTienNghi.Columns.Add(cbn_ChucNangXoa);
        }

        private void dtg_DanhSachTienNghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DanhSachTienNghi.Rows.Count - 1)
            {
                return;
            }
            IdLoaiTienNghiSelect = Guid.Parse(Convert.ToString(dtg_DanhSachTienNghi.Rows[rd].Cells[0].Value));
            MaLoaiTienNghiSelect = Convert.ToString(dtg_DanhSachTienNghi.Rows[rd].Cells[1].Value);
            TenLoaiTienNghiSelect = Convert.ToString(dtg_DanhSachTienNghi.Rows[rd].Cells[2].Value);
            
        }

        private void dtg_DanhSachTienNghi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DanhSachTienNghi.Columns[e.ColumnIndex].Name == "btn_SuaLoaiTienNghi")
            {
                // Open Form BtnSuaPhong
                FrmBtnSuaLoaiTienNghi btnsualtn = new FrmBtnSuaLoaiTienNghi(LoadData);
                // Đấy dữ liệu vừa cell click sang các prop bên form BtnSuaPhong
                btnsualtn.IdLoaiTiennghi = IdLoaiTienNghiSelect;
                btnsualtn.MaLoaiTienNghi = MaLoaiTienNghiSelect;
                btnsualtn.TenLoaiTienNghi = TenLoaiTienNghiSelect;
                btnsualtn.ShowDialog();
            }
            if (dtg_DanhSachTienNghi.Columns[e.ColumnIndex].Name == "btn_XoaLoaiTienNghi")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa loại tiện nghi này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LoaiTienNghiView pv = new LoaiTienNghiView();
                    pv.ID = IdLoaiTienNghiSelect;
                    MessageBox.Show(_iqlLoaiTienNghi.Remove(pv));
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Xóa loai tiện nghi thất bại");
                }
            }
        }

        private void tbt_SearchUseName_TextChanged(object sender, EventArgs e)
        {
            LoadData(_iqlLoaiTienNghi.Search(tbt_SearchUseName.Text));
        }
    }
}
