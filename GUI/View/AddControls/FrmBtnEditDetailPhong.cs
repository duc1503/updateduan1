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
    public partial class FrmBtnEditDetailPhong : Form
    {
        public string MaPhong { get; set; }
        public Guid IdRoomSelected { get; set; }
        private Guid IdCTTNSelected { get; set; }

        private Guid IdCTNNHaveRoom { get; set; }

        private string MaCTTN { get; set; }
        private string TenCTTN { get; set; }
        private Guid IdLoaiTienNghi { get; set; }
        
        private IQLChiTietTienNghiService _iqlCTTNService;

        public FrmBtnEditDetailPhong()
        {
            InitializeComponent();
            _iqlCTTNService = new QLChiTietTienNghiService();

        }

        private void LoadDataCTTNTrong()
        {
            dtg_DanhSachCTTNTrong.ColumnCount = 5;
            dtg_DanhSachCTTNTrong.Rows.Clear();
            dtg_DanhSachCTTNTrong.Columns[0].Name = "ID CTTN";
            dtg_DanhSachCTTNTrong.Columns[0].Visible = false;
            dtg_DanhSachCTTNTrong.Columns[1].Name = "Ma CTTN";
            dtg_DanhSachCTTNTrong.Columns[2].Name = "Ten CTTN";
            dtg_DanhSachCTTNTrong.Columns[3].Name = "Ten Loai TN";
            dtg_DanhSachCTTNTrong.Columns[4].Name = "ID Loai TN";
            dtg_DanhSachCTTNTrong.Columns[4].Visible = false;

            var lstCTTNTrong = _iqlCTTNService.GetEmptyCTTN();
        
            foreach (var item in lstCTTNTrong)
            {
                dtg_DanhSachCTTNTrong.Rows.Add(item.ID, item.MaCTTienNghi, item.TenCTTienNghi, item.TenLoaiTienNghi, item.IDLoaiTienNghi);
            }
        }

        private void LoadDataCTTNPhong()
        {
            dtg_DanhSachCTTNPhong.ColumnCount = 7;
            dtg_DanhSachCTTNPhong.Rows.Clear();
            dtg_DanhSachCTTNPhong.Columns[0].Name = "ID CTTN";
            dtg_DanhSachCTTNPhong.Columns[0].Visible = false;
            dtg_DanhSachCTTNPhong.Columns[1].Name = "Mã CTTN";
            dtg_DanhSachCTTNPhong.Columns[2].Name = "Tên CTTN";
            dtg_DanhSachCTTNPhong.Columns[3].Name = "Tên Loại TN";
            dtg_DanhSachCTTNPhong.Columns[4].Name = "ID Phòng";
            dtg_DanhSachCTTNPhong.Columns[4].Visible = false;
            dtg_DanhSachCTTNPhong.Columns[5].Name = "Mã phòng";
            dtg_DanhSachCTTNPhong.Columns[6].Name = "ID loại TN";
            dtg_DanhSachCTTNPhong.Columns[6].Visible = false;

            //var lstCTTNPhong = _iqlCTTNService.GetListCTTNRoom(Guid.Parse("86393AF9-2C4F-43C5-861C-1605E3B96938"));
            var lstCTTNPhong = _iqlCTTNService.GetListCTTNRoom(IdRoomSelected);  
            foreach (var item in lstCTTNPhong)
            {
                dtg_DanhSachCTTNPhong.Rows.Add(item.ID, item.MaCTTienNghi, item.TenCTTienNghi, item.TenLoaiTienNghi, item.IdPhong, item.MaPhong, item.IDLoaiTienNghi);
            }
        }

        private void FrmBtnEditDetailPhong_Load(object sender, EventArgs e)
        {
            lb_TenPhongCTTN.Text = MaPhong;
            LoadDataCTTNTrong();
            LoadDataCTTNPhong();
        }

        private void dtg_DanhSachCTTNTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DanhSachCTTNTrong.Rows.Count - 1)
            {
                return;
            }
            IdCTTNSelected = Guid.Parse(Convert.ToString(dtg_DanhSachCTTNTrong.Rows[rd].Cells[0].Value));
            MaCTTN = Convert.ToString(dtg_DanhSachCTTNTrong.Rows[rd].Cells[1].Value);
            TenCTTN = Convert.ToString(dtg_DanhSachCTTNTrong.Rows[rd].Cells[2].Value);
            IdLoaiTienNghi = Guid.Parse(Convert.ToString(dtg_DanhSachCTTNTrong.Rows[rd].Cells[4].Value));
        }

        private void btn_CapNhatPhongCTTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn sẽ thêm tiện nghi cho phòng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ChiTietTienNghiView ctnv = new ChiTietTienNghiView();
                ctnv.ID = IdCTTNSelected;
                ctnv.MaCTTienNghi = MaCTTN;
                ctnv.TenCTTienNghi = TenCTTN;
                ctnv.IDLoaiTienNghi = IdLoaiTienNghi;
                ctnv.IdPhong = IdRoomSelected;
                MessageBox.Show(_iqlCTTNService.Update(ctnv));
            }
            if (result == DialogResult.No)
            {             
                MessageBox.Show("Bạn đã hủy thêm tiện nghi cho phòng");
            }
            LoadDataCTTNTrong();
            LoadDataCTTNPhong();
        }

        private void dtg_DanhSachCTTNPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DanhSachCTTNPhong.Rows.Count - 1)
            {
                return;
            }
            IdCTNNHaveRoom = Guid.Parse(Convert.ToString(dtg_DanhSachCTTNPhong.Rows[rd].Cells[0].Value));
            MaCTTN = Convert.ToString(dtg_DanhSachCTTNPhong.Rows[rd].Cells[1].Value);
            TenCTTN = Convert.ToString(dtg_DanhSachCTTNPhong.Rows[rd].Cells[2].Value);
            IdLoaiTienNghi = Guid.Parse(Convert.ToString(dtg_DanhSachCTTNPhong.Rows[rd].Cells[6].Value));
        }

        private void btn_HuyCapNhatPhongCTTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa tiện nghi này ra khỏi phòng không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ChiTietTienNghiView ctnv = new ChiTietTienNghiView();
                ctnv.ID = IdCTNNHaveRoom;
                ctnv.MaCTTienNghi = MaCTTN;
                ctnv.TenCTTienNghi = TenCTTN;
                ctnv.IDLoaiTienNghi = IdLoaiTienNghi;
                ctnv.IdPhong = null;
                MessageBox.Show(_iqlCTTNService.Update(ctnv));
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy xóa tiện nghi cho phòng");
            }
            LoadDataCTTNTrong();
            LoadDataCTTNPhong();
        }
    }
}
