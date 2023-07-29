
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
    public delegate void send_Lphong(List<LoaiPhongView> lphongList);
    public partial class FrmQLLoaiPhong : Form
    {
        private IQLLoaiPhongService _iqLLoaiPhongService;
        public Guid IDLoaiPhongSelect { get; set; }
        public string MaLoaiPhongSelect;
        public string TenLoaiPhongSelect;
        public int SoGiuongLoaiPhongSelect;
        public int GiaNgayLoaiPhongSelect;
        public FrmQLLoaiPhong()
        {
            InitializeComponent();
            _iqLLoaiPhongService = new ILoaiPhongService();
            LoadData(_iqLLoaiPhongService.GetAll());
        }

        private void btn_ThemLoaiPhong_Click(object sender, EventArgs e)
        {
            FrmBtnThemLoaiPhong frmBtnThemLoaiPhong = new FrmBtnThemLoaiPhong(LoadData);
            frmBtnThemLoaiPhong.ShowDialog();
        }

        private void LoadData(List<LoaiPhongView> lst)
        {
            dtg_DanhSachLoaiPhong.ColumnCount = 5;
            dtg_DanhSachLoaiPhong.Rows.Clear();
            dtg_DanhSachLoaiPhong.Columns[0].Name = "ID";
            dtg_DanhSachLoaiPhong.Columns[0].Visible = false;
            dtg_DanhSachLoaiPhong.Columns[1].Name = "Mã loại phòng";
            dtg_DanhSachLoaiPhong.Columns[2].Name = "Tên loại phòng";
            dtg_DanhSachLoaiPhong.Columns[3].Name = "Số lượng";
            dtg_DanhSachLoaiPhong.Columns[4].Name = "Giá ngay";

            foreach (var item in lst)
            {
                dtg_DanhSachLoaiPhong.Rows.Add(item.ID, item.MaLoaiPhong, item.TenLoaiPhong, item.SoGiuong, item.GiaNgay);
            }

            // Thêm button control vào datadridview
            DataGridViewButtonColumn cbn_ChucNangSua = new DataGridViewButtonColumn();
            cbn_ChucNangSua.HeaderText = "Chức năng sửa";
            cbn_ChucNangSua.Text = "Sửa";
            cbn_ChucNangSua.Name = "btn_SuaLoaiPhong";
            cbn_ChucNangSua.UseColumnTextForButtonValue = true;
            dtg_DanhSachLoaiPhong.Columns.Add(cbn_ChucNangSua);

            DataGridViewButtonColumn cbn_ChucNangXoa = new DataGridViewButtonColumn();
            cbn_ChucNangXoa.HeaderText = "Chức năng xóa";
            cbn_ChucNangXoa.Text = "Xóa";
            cbn_ChucNangXoa.Name = "btn_XoaLoaiPhong";
            cbn_ChucNangXoa.UseColumnTextForButtonValue = true;
            dtg_DanhSachLoaiPhong.Columns.Add(cbn_ChucNangXoa);
        }

        private void dtg_DanhSachLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DanhSachLoaiPhong.Rows.Count - 1)
            {
                return;
            }
            IDLoaiPhongSelect = Guid.Parse(Convert.ToString(dtg_DanhSachLoaiPhong.Rows[rd].Cells[0].Value));
            MaLoaiPhongSelect = Convert.ToString(dtg_DanhSachLoaiPhong.Rows[rd].Cells[1].Value);
            TenLoaiPhongSelect = Convert.ToString(dtg_DanhSachLoaiPhong.Rows[rd].Cells[2].Value);
            SoGiuongLoaiPhongSelect = int.Parse(Convert.ToString(dtg_DanhSachLoaiPhong.Rows[rd].Cells[3].Value));
            GiaNgayLoaiPhongSelect = int.Parse(Convert.ToString(dtg_DanhSachLoaiPhong.Rows[rd].Cells[4].Value));
        }

        private void dtg_DanhSachLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DanhSachLoaiPhong.Columns[e.ColumnIndex].Name == "btn_SuaLoaiPhong")
            {
                // Open Form BtnSuaPhong
                FrmBtnSuaLoaiPhong btnSuaLoaiPhong = new FrmBtnSuaLoaiPhong();
                // Đấy dữ liệu vừa cell click sang các prop bên form BtnSuaPhong
                btnSuaLoaiPhong.IDLoaiPhongSua = IDLoaiPhongSelect;
                btnSuaLoaiPhong.MaLoaiPhongSua = MaLoaiPhongSelect;
                btnSuaLoaiPhong.TenLoaiPhongSua = TenLoaiPhongSelect;
                btnSuaLoaiPhong.SoGiuongLoaiPhongSua = SoGiuongLoaiPhongSelect;
                btnSuaLoaiPhong.GiaNgayLoaiPhongSua = GiaNgayLoaiPhongSelect;
                btnSuaLoaiPhong.ShowDialog();
            }
            if (dtg_DanhSachLoaiPhong.Columns[e.ColumnIndex].Name == "btn_XoaLoaiPhong")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa loại phòng này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LoaiPhongView pv = new LoaiPhongView();
                    pv.ID = IDLoaiPhongSelect;
                    MessageBox.Show(_iqLLoaiPhongService.Remove(pv));
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Xóa loại phòng thất bại");
                }
            }
        }

        private void tbt_SearchRoomTypeName_TextChanged(object sender, EventArgs e)
        {
            LoadData(_iqLLoaiPhongService.Search(tbt_SearchRoomTypeName.Text));
        }
    }
}
