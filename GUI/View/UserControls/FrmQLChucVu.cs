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
    public delegate void send_cv(string obj);
    public partial class FrmQLChucVu : Form
    {
        
        private IChucVuService _chucVuService;
        public FrmQLChucVu()
        {
            InitializeComponent();
            _chucVuService = new ChucVuService();
            LoadData(string.Empty);
        }

        private void btn_ThemChucVu_Click(object sender, EventArgs e)
        {
            FrmBtnThemChucVu frm = new FrmBtnThemChucVu();
            frm.ShowDialog();
            LoadData(string.Empty);
        }
        private void LoadData(string obj)
        {
            int stt = 1;
            dtg_DanhSachChucVu.ColumnCount = 4;
            dtg_DanhSachChucVu.Columns[0].Name = "STT";
            dtg_DanhSachChucVu.Columns[1].Name = "ID";
            dtg_DanhSachChucVu.Columns[2].Name = "Mã Chức vụ";
            dtg_DanhSachChucVu.Columns[3].Name = "Tên Chức vụ";
            
            // Thêm button control vào datadridview
            DataGridViewButtonColumn cbn_ChucNangSua = new DataGridViewButtonColumn();
            cbn_ChucNangSua.HeaderText = "Chức năng sửa";
            cbn_ChucNangSua.Text = "Sửa";
            cbn_ChucNangSua.Name = "btn_SuaLoaiDichVu";
            cbn_ChucNangSua.UseColumnTextForButtonValue = true;
            dtg_DanhSachChucVu.Columns.Add(cbn_ChucNangSua);
            
            DataGridViewButtonColumn cbn_ChucNangXoa = new DataGridViewButtonColumn();
            cbn_ChucNangXoa.HeaderText = "Chức năng xóa";
            cbn_ChucNangXoa.Text = "Xóa";
            cbn_ChucNangXoa.Name = "btn_XoaLoaiDichVu";
            cbn_ChucNangXoa.UseColumnTextForButtonValue = true;
            dtg_DanhSachChucVu.Columns.Add(cbn_ChucNangXoa);

            dtg_DanhSachChucVu.Columns[1].Visible = false;
            dtg_DanhSachChucVu.Rows.Clear();
            foreach (var x in _chucVuService.GetList(obj))
            {
                dtg_DanhSachChucVu.Rows.Add(stt++, x.ID, x.MaCV, x.TenCV);
            }
        }
        private void tbt_SearchRoleName_TextChanged(object sender, EventArgs e)
        {
            LoadData(tbt_SearchRoleName.Text);
        }

        private void dtg_DanhSachChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa chức vụ này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ChucVuView _cvv = new ChucVuView();
                    _cvv.ID = Guid.Parse(dtg_DanhSachChucVu.Rows[e.RowIndex].Cells[1].Value.ToString());
                    MessageBox.Show(_chucVuService.Remove(_cvv));
                    LoadData(string.Empty);
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Hủy");
                }
            }
            if (e.ColumnIndex == 4)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa chức vụ này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    FrmBtnSuaChucVu frm = new FrmBtnSuaChucVu(LoadData);
                    frm._cvView.ID = Guid.Parse(dtg_DanhSachChucVu.Rows[e.RowIndex].Cells[1].Value.ToString());
                    frm._cvView.MaCV = dtg_DanhSachChucVu.Rows[e.RowIndex].Cells[2].Value.ToString();
                    frm._cvView.TenCV = dtg_DanhSachChucVu.Rows[e.RowIndex].Cells[3].Value.ToString();
                    frm.ShowDialog();
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Hủy");
                }
            }
        }


    }
}
