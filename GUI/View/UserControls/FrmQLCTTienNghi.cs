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
using GUI.View.AddControls;
namespace GUI.View.UserControls
{
    public delegate void send_cttn(List<ChiTietTienNghiView> LIST);
    public partial class FrmQLCTTienNghi : Form
    {
        private IQLChiTietTienNghiService _iqlCTTNService;

        private Guid IdSelected { get; set; }
        private string MaCTTN { get; set; }
        private string TenCTTN { get; set; }
        private string TenLoaiCTTN { get; set; }
        private string MaPhong { get; set; }

        public FrmQLCTTienNghi()
        {
            InitializeComponent();
            _iqlCTTNService = new QLChiTietTienNghiService();

            LoadDataCTTN(_iqlCTTNService.GetAll());
        }

        private void LoadDataCTTN(List<ChiTietTienNghiView> lst)
        {
            dtg_DanhSachCTTienNghi.ColumnCount = 5;
            dtg_DanhSachCTTienNghi.Rows.Clear();
            dtg_DanhSachCTTienNghi.Columns[0].Name = "ID CTTN";
            dtg_DanhSachCTTienNghi.Columns[0].Visible = false;
            dtg_DanhSachCTTienNghi.Columns[1].Name = "Mã CTTN";
            dtg_DanhSachCTTienNghi.Columns[2].Name = "Tên CTTN";
            dtg_DanhSachCTTienNghi.Columns[3].Name = "Tên Loại TN";   
            dtg_DanhSachCTTienNghi.Columns[4].Name = "Mã phòng";

            foreach (var item in lst.OrderBy(p => p.MaCTTienNghi))
            {
                dtg_DanhSachCTTienNghi.Rows.Add(item.ID, item.MaCTTienNghi, item.TenCTTienNghi, item.TenLoaiTienNghi, item.MaPhong);
            }

            DataGridViewButtonColumn cbn_ChucNangSua = new DataGridViewButtonColumn();
            cbn_ChucNangSua.HeaderText = "Chức năng sửa";
            cbn_ChucNangSua.Text = "Sửa";
            cbn_ChucNangSua.Name = "btn_SuaCTTN";
            cbn_ChucNangSua.UseColumnTextForButtonValue = true;
            dtg_DanhSachCTTienNghi.Columns.Add(cbn_ChucNangSua);

            DataGridViewButtonColumn cbn_ChucNangXoa = new DataGridViewButtonColumn();
            cbn_ChucNangXoa.HeaderText = "Chức năng xóa";
            cbn_ChucNangXoa.Text = "Xóa";
            cbn_ChucNangXoa.Name = "btn_XoaCTTN";
            cbn_ChucNangXoa.UseColumnTextForButtonValue = true;
            dtg_DanhSachCTTienNghi.Columns.Add(cbn_ChucNangXoa);
        }

        private void btn_ThemCTTienNghi_Click(object sender, EventArgs e)
        {
            FrmBtnThemTienNghi frmBtnThemTienNghi = new FrmBtnThemTienNghi(LoadDataCTTN);
            frmBtnThemTienNghi.ShowDialog();
        }

        private void dtg_DanhSachCTTienNghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DanhSachCTTienNghi.Rows.Count - 1)
            {
                return;
            }
            IdSelected = Guid.Parse(Convert.ToString(dtg_DanhSachCTTienNghi.Rows[rd].Cells[0].Value));
            MaCTTN = Convert.ToString(dtg_DanhSachCTTienNghi.Rows[rd].Cells[1].Value);
            TenCTTN = Convert.ToString(dtg_DanhSachCTTienNghi.Rows[rd].Cells[2].Value);
            TenLoaiCTTN = Convert.ToString(dtg_DanhSachCTTienNghi.Rows[rd].Cells[3].Value);
            MaPhong = Convert.ToString(dtg_DanhSachCTTienNghi.Rows[rd].Cells[4].Value);
           
        }

        private void dtg_DanhSachCTTienNghi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DanhSachCTTienNghi.Columns[e.ColumnIndex].Name == "btn_SuaCTTN")
            {
                // Open Form BtnSuaPhong
                FrmBtnSuaTienNghi btnSuaTN = new FrmBtnSuaTienNghi();
                // Đấy dữ liệu vừa cell click sang các prop bên form BtnSuaPhong
                btnSuaTN.IdSelect = IdSelected;
                btnSuaTN.MaCTTNSelect = MaCTTN;
                btnSuaTN.TenCTTNSelect = TenCTTN;
                btnSuaTN.TenLoaiCTTNSelect = TenLoaiCTTN;
                btnSuaTN.MaPhongSelect = MaPhong;
                btnSuaTN.ShowDialog();
            }
            if (dtg_DanhSachCTTienNghi.Columns[e.ColumnIndex].Name == "btn_XoaCTTN")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa loại tiện nghi này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ChiTietTienNghiView ctnv = new ChiTietTienNghiView();
                    ctnv.ID = IdSelected;
                    MessageBox.Show(_iqlCTTNService.Remove(ctnv));
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Xóa loai tiện nghi thất bại");
                }
            }
        }



        private void tbt_SearchUseDetailName_TextChanged(object sender, EventArgs e)
        {
            LoadDataCTTN(_iqlCTTNService.Search(tbt_SearchUseDetailName.Text));
        }
    }
}
