using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
using GUI.View.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.View.AddControls
{
    public partial class FrmBtnXemCTPhieuThue : Form
    {
        private send_pt _send;
        private IQLChiTietPhieuThueService _iqlCTPTService;
        private IQLPhongService _iqlPhongService;
        private IQLPhieuThueService _iqlPhieuThue;
        public Guid IdPT { get; set; }
        public Guid IdKH { get; set; }
        public string TenKH { get; set; }
        public string TenNV { get; set; }
        public DateTime NgayLapPhieu { get; set; }

        private Guid IdCTPT { get; set; }
        public DateTime NgayBDThue { get; set; }
        public Guid IdPhongInCTPT { get; set; }
        public FrmBtnXemCTPhieuThue(send_pt send)
        {
            InitializeComponent();
            _send = send;
            _iqlCTPTService = new QLChiTietPhieuThueService();
            _iqlPhongService = new IPhongService();

            LoadDataCTPT();
        }

        private void LoadDataCTPT()
        {
            dtg_ChiTietPhieuThue.ColumnCount = 5;
            dtg_ChiTietPhieuThue.Rows.Clear();
            dtg_ChiTietPhieuThue.Columns[0].Name = "ID CTPT";
            dtg_ChiTietPhieuThue.Columns[0].Visible = false;
            dtg_ChiTietPhieuThue.Columns[1].Name = "Mã phòng";
            dtg_ChiTietPhieuThue.Columns[2].Name = "Ngày bắt đầu";
            dtg_ChiTietPhieuThue.Columns[3].Name = "Ngày kết thúc";
            dtg_ChiTietPhieuThue.Columns[4].Name = "Id Room";
            dtg_ChiTietPhieuThue.Columns[4].Visible = false;
 

            //var lstCtsp = _iqlCTPTService.GetAll();
            var lstCtsp = _iqlCTPTService.GetAll().Where(p => p.IdPhieuThue == IdPT);
            foreach (var item in lstCtsp)
            {
                dtg_ChiTietPhieuThue.Rows.Add(item.ID, item.MaPhong, item.NgayBatDau, item.NgayKetThuc, item.IdPhong);
            }

            DataGridViewButtonColumn cbn_ChucNangXoa = new DataGridViewButtonColumn();
            cbn_ChucNangXoa.HeaderText = "Chức năng xóa";
            cbn_ChucNangXoa.Text = "Xóa";
            cbn_ChucNangXoa.Name = "btn_XoaCTPhieuThue";
            cbn_ChucNangXoa.UseColumnTextForButtonValue = true;
            dtg_ChiTietPhieuThue.Columns.Add(cbn_ChucNangXoa);
        }

        private void FrmBtnXemCTPhieuThue_Load(object sender, EventArgs e)
        {
            lb_TenKH.Text = TenKH;
            lb_TenNV.Text = TenNV;
            dtp_NgayLapPhieu.Value = NgayLapPhieu;
            LoadDataCTPT();
        }

        private void dtg_ChiTietPhieuThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_ChiTietPhieuThue.Rows.Count - 1)
            {
                return;
            }
            IdCTPT = Guid.Parse(dtg_ChiTietPhieuThue.Rows[rd].Cells[0].Value.ToString());
            NgayBDThue = Convert.ToDateTime(dtg_ChiTietPhieuThue.Rows[rd].Cells[2].Value);
            IdPhongInCTPT = Guid.Parse(dtg_ChiTietPhieuThue.Rows[rd].Cells[4].Value.ToString());
        }

        private void dtg_ChiTietPhieuThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_ChiTietPhieuThue.Columns[e.ColumnIndex].Name == "btn_XoaCTPhieuThue")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa chi tiết phiếu thuê này không ? ", "Thông báo", MessageBoxButtons.YesNo);
                // DateTime.Compare(d1, d2) : if d1 sớm hơn d2 => <0
                // DateTime.Compare(d1, d2) : if d1 = d2 => 0
                // DateTime.Compare(d1, d2) : if d1 muộn hơn d2 => >0
                if (result == DialogResult.Yes)
                {
                    int checkDate = DateTime.Compare(DateTime.Now, NgayBDThue);
                    if (checkDate > 0 || checkDate == 0)
                    {
                        MessageBox.Show("Bạn không thể xóa phòng này vì phòng này hiện đang trong thời gian thuê !");
                        return;
                    }
                    PhongView pv = new PhongView();
                    pv.Id = IdPhongInCTPT;
                    pv.MaPhong = _iqlPhongService.GetAll().FirstOrDefault(p => p.Id == IdPhongInCTPT).MaPhong;
                    // 0 = Phòng trống, 1= Phòng có khách , 2 = Phòng đang dọn dẹp
                    pv.TinhTrang = 0;
                    pv.IDLoaiPhong = _iqlPhongService.GetAll().FirstOrDefault(p => p.Id == IdPhongInCTPT).IDLoaiPhong;
                    _iqlPhongService.Update(pv);
                    // Update trạng thái phòng => phòng trống
                    ChiTietPhieuThueView ctptv = new ChiTietPhieuThueView();
                    ctptv.ID = IdCTPT;
                    MessageBox.Show(_iqlCTPTService.Remove(ctptv));
                    LoadDataCTPT();
                 

                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Bạn vừa hủy xóa chi tiết phiếu thuê!");
                }
            }
        }

        private void btn_ThueThemPhong_Click(object sender, EventArgs e)
        {
            FrmUpdateCTPT frmUpdateCTPT = new FrmUpdateCTPT();
            frmUpdateCTPT.IdPhieuThueMuonUpdate = IdPT;
            frmUpdateCTPT.ShowDialog();
        }

        private void btn_HuyXemCTTienNghi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
