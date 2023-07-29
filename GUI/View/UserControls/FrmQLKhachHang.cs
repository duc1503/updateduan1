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
    public delegate void send_kh(List<KhachHangView> list);
    public partial class FrmQLKhachHang : Form
    {
        private IQLKhachHangService _iQLKhachHangService;
        public Guid IdKHSelect { get; set; }
        public string MaKHSelect;
        public string HoTenKHSelect;
        public string CCCDKHSelect;
        public string SDTKHSelect;
        public string DiaChiKHSelect;
        public string GioiTinhKHSelect;
        public string QuocTichSelect;
        public FrmQLKhachHang()
        {
            InitializeComponent();
            _iQLKhachHangService = new QLKhachHangService();
            LoadData(_iQLKhachHangService.GetAll());
        }

        private void LoadData(List<KhachHangView> list)
        {
            int stt = 1;
            dtg_DanhSachKH.ColumnCount = 9;
            dtg_DanhSachKH.Rows.Clear();
            dtg_DanhSachKH.Columns[0].Name = "ID";
            dtg_DanhSachKH.Columns[0].Visible = false;
            dtg_DanhSachKH.Columns[1].Name = "STT";
            dtg_DanhSachKH.Columns[2].Name = "Mã Khách Hàng";
            dtg_DanhSachKH.Columns[3].Name = "Họ tên";
            dtg_DanhSachKH.Columns[4].Name = "CCCD";
            dtg_DanhSachKH.Columns[5].Name = "Sđt";
            dtg_DanhSachKH.Columns[6].Name = "Địa chỉ";
            dtg_DanhSachKH.Columns[7].Name = "Giới tính";
            dtg_DanhSachKH.Columns[8].Name = "Quốc tịch";
            dtg_DanhSachKH.Rows.Clear();
            foreach (var x in list.OrderBy(p => p.MaKH))
            {
                dtg_DanhSachKH.Rows.Add(x.ID, stt++, x.MaKH, x.HovaTen, x.CCCD, x.SDT, x.DiaChi, x.GioiTinh == 1? "Nam" : x.GioiTinh == 2 ? "Nữ" : "Khác" , x.QuocTich);
            }
            // Thêm button control vào datadridview
            DataGridViewButtonColumn cbn_ChucNangSua = new DataGridViewButtonColumn();
            cbn_ChucNangSua.HeaderText = "Chức năng sửa";
            cbn_ChucNangSua.Text = "Sửa";
            cbn_ChucNangSua.Name = "btn_SuaKH";
            cbn_ChucNangSua.UseColumnTextForButtonValue = true;
            dtg_DanhSachKH.Columns.Add(cbn_ChucNangSua);

            DataGridViewButtonColumn cbn_ChucNangXoa = new DataGridViewButtonColumn();
            cbn_ChucNangXoa.HeaderText = "Chức năng xóa";
            cbn_ChucNangXoa.Text = "Xóa";
            cbn_ChucNangXoa.Name = "btn_XoaKH";
            cbn_ChucNangXoa.UseColumnTextForButtonValue = true;
            dtg_DanhSachKH.Columns.Add(cbn_ChucNangXoa);
        }
       
        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            FrmBtnThemKH kh = new FrmBtnThemKH(LoadData);
            kh.ShowDialog();
        }

        private void dtg_DanhSachKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DanhSachKH.Columns[e.ColumnIndex].Name == "btn_SuaKH") // nếu bấm vào nút có tên btn_SuaKH được tạo trên dtg thì :  
            {
                // Open Form BtnSuaPhong
                FrmBtnSuaKH btnsuakh = new FrmBtnSuaKH(LoadData);
                // Đấy dữ liệu vừa cell click sang các prop bên form FrmBtnSuaKH
                // bên frmSuaKh sẽ ko có select để cho dễ phân biệt
                btnsuakh.IdKH = IdKHSelect;
                btnsuakh.MaKH = MaKHSelect;
                btnsuakh.HoTenKH = HoTenKHSelect;
                btnsuakh.CCCDKH = CCCDKHSelect;
                btnsuakh.SDTKH = SDTKHSelect;
                btnsuakh.DiaChiKH = DiaChiKHSelect;
                btnsuakh.GioiTinhKH = GioiTinhKHSelect;
                btnsuakh.QuocTich = QuocTichSelect;
                btnsuakh.ShowDialog();
            }
            if (dtg_DanhSachKH.Columns[e.ColumnIndex].Name == "btn_XoaKH")
            {
                DialogResult hoi = MessageBox.Show("Bạn có muốn xóa khách hàng này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (hoi == DialogResult.Yes)
                {
                    KhachHangView pv = new KhachHangView();
                    pv.ID = IdKHSelect;
                    MessageBox.Show(_iQLKhachHangService.Remove(pv));
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại");
                }
            }
        }

        private void dtg_DanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DanhSachKH.Rows.Count - 1)
            {
                return;
            }
            IdKHSelect = Guid.Parse(Convert.ToString(dtg_DanhSachKH.Rows[rd].Cells[0].Value));
            MaKHSelect = Convert.ToString(dtg_DanhSachKH.Rows[rd].Cells[2].Value);
            HoTenKHSelect = Convert.ToString(dtg_DanhSachKH.Rows[rd].Cells[3].Value);
            SDTKHSelect = Convert.ToString(dtg_DanhSachKH.Rows[rd].Cells[5].Value);
            CCCDKHSelect = Convert.ToString(dtg_DanhSachKH.Rows[rd].Cells[4].Value);
            DiaChiKHSelect = Convert.ToString(dtg_DanhSachKH.Rows[rd].Cells[6].Value);
            GioiTinhKHSelect = Convert.ToString(dtg_DanhSachKH.Rows[rd].Cells[7].Value);
            QuocTichSelect = Convert.ToString(dtg_DanhSachKH.Rows[rd].Cells[8].Value);

        }

        private void tbt_SearchCusName_TextChanged(object sender, EventArgs e)
        {
            LoadData(_iQLKhachHangService.Search(tbt_SearchCusName.Text));
        }
    }
}
