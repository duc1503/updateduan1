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
    public delegate void send_pt(List<PhieuThueView> list);
    public partial class FrmDatPhong : Form
    {
        private IQLPhieuThueService _iqlPTService;
        public Guid IdPTSelected { get; set; }
        public Guid IdKH { get; set; }
        public string TenKHSelect { get; set; }
        public string TenNvSelect { get; set; }
        public DateTime NgayLapPhieuSelect { get; set; }
        public FrmDatPhong()
        {
            InitializeComponent();
            _iqlPTService = new QLPhieuThueService();
            LoadDataPT(_iqlPTService.GetAll());
        }

        private void LoadDataPT(List<PhieuThueView> lst)
        {
            
            dtg_DanhSachPT.ColumnCount = 6;
            dtg_DanhSachPT.Rows.Clear();
            dtg_DanhSachPT.Columns[0].Name = "ID PT";
            dtg_DanhSachPT.Columns[0].Visible = false;
            dtg_DanhSachPT.Columns[1].Name = "Mã Phiếu thuê";
            dtg_DanhSachPT.Columns[2].Name = "Tên khách hàng";
            dtg_DanhSachPT.Columns[3].Name = "Ngày lập phiếu";
            dtg_DanhSachPT.Columns[4].Name = "Tên nhân viên";
            dtg_DanhSachPT.Columns[5].Name = "ID KH";
            dtg_DanhSachPT.Columns[5].Visible =false;

            foreach (var item in lst.OrderBy(p => p.MaPhieuThue))
            {
                dtg_DanhSachPT.Rows.Add(item.ID, item.MaPhieuThue, item.TenKH, item.NgayLapPhieu, item.TenNV, item.IdKH);
            }

            DataGridViewButtonColumn cbn_ChucNangXemCT = new DataGridViewButtonColumn();
            cbn_ChucNangXemCT.HeaderText = "Xem chi tiết";
            cbn_ChucNangXemCT.Text = "Detail";
            cbn_ChucNangXemCT.Name = "btn_XemCTPhieuThue";
            cbn_ChucNangXemCT.UseColumnTextForButtonValue = true;
            dtg_DanhSachPT.Columns.Add(cbn_ChucNangXemCT);

            DataGridViewButtonColumn cbn_ChucNangXoa = new DataGridViewButtonColumn();
            cbn_ChucNangXoa.HeaderText = "Chức năng xóa";
            cbn_ChucNangXoa.Text = "Xóa";
            cbn_ChucNangXoa.Name = "btn_XoaPhieuThue";
            cbn_ChucNangXoa.UseColumnTextForButtonValue = true;
            dtg_DanhSachPT.Columns.Add(cbn_ChucNangXoa);
        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            FrmBtnDatPhong btnDatphong = new FrmBtnDatPhong(LoadDataPT);
            btnDatphong.ShowDialog();
        }

        private void dtg_DanhSachPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DanhSachPT.Rows.Count - 1)
            {
                return;
            }
            IdPTSelected = Guid.Parse(dtg_DanhSachPT.Rows[rd].Cells[0].Value.ToString());
            TenKHSelect = dtg_DanhSachPT.Rows[rd].Cells[2].Value.ToString();
            TenNvSelect = dtg_DanhSachPT.Rows[rd].Cells[4].Value.ToString();
            NgayLapPhieuSelect = Convert.ToDateTime(dtg_DanhSachPT.Rows[rd].Cells[3].Value);
            IdKH = Guid.Parse(dtg_DanhSachPT.Rows[rd].Cells[5].Value.ToString());
        }

        private void dtg_DanhSachPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DanhSachPT.Columns[e.ColumnIndex].Name == "btn_XemCTPhieuThue")
            {
                // Open Form BtnSuaPhong
                FrmBtnXemCTPhieuThue ctpt = new FrmBtnXemCTPhieuThue(LoadDataPT);
                // Đấy dữ liệu vừa cell click sang các prop bên form BtnSuaPhong
                ctpt.IdPT = IdPTSelected;
                ctpt.TenKH = TenKHSelect;
                ctpt.TenNV = TenNvSelect;
                ctpt.IdKH = IdKH;
                ctpt.NgayLapPhieu = NgayLapPhieuSelect;
                ctpt.ShowDialog();
            }
            if (dtg_DanhSachPT.Columns[e.ColumnIndex].Name == "btn_XoaPhieuThue")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa phiếu thuê này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    PhieuThueView ptv = new PhieuThueView();
                    ptv.ID = IdPTSelected;
                    MessageBox.Show(_iqlPTService.Remove(ptv));
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Bạn đã hủy xóa phiếu thuê");
                }
            }
        }

    }
}
