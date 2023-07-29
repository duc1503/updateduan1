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
    public delegate void send_nv(List<NhanVienView> nhanVienViews);
    public partial class FrmQLNhanVien : Form
    {
        IQLNhanVienServices _iqLNhanVien;

     
        public Guid ID;
        public string MaNV;
        public string TenNV;
        public DateTime NgaySinh;
        public int GioiTinh;
        public string DiaChi;
        public string SDT;
        public string CCCD;
        public int Luong;
        public Guid IDCv;
        public string TenCV;
        public FrmQLNhanVien()
        {
            InitializeComponent();
            _iqLNhanVien= new QLNhanVienServices();
            
            LoadData(_iqLNhanVien.GetAll());
        }

        public void LoadData(List<NhanVienView> list)
        {
            int index = 0;
            dtg_DanhSachNhanVien.ColumnCount = 11;
            dtg_DanhSachNhanVien.Columns[0].Name = "ID";
            dtg_DanhSachNhanVien.Columns[1].Name = "MaNV";
            dtg_DanhSachNhanVien.Columns[2].Name = "TenNV";
            dtg_DanhSachNhanVien.Columns[3].Name = "NgaySinh";
            dtg_DanhSachNhanVien.Columns[4].Name = "GioiTinh";
            dtg_DanhSachNhanVien.Columns[5].Name = "DiaChi";
            dtg_DanhSachNhanVien.Columns[6].Name = "SDT";
            dtg_DanhSachNhanVien.Columns[7].Name = "CCCD";
            dtg_DanhSachNhanVien.Columns[8].Name = "Luong";
            dtg_DanhSachNhanVien.Columns[9].Name = "IDCv";
            dtg_DanhSachNhanVien.Columns[10].Name = "TenCV";
            dtg_DanhSachNhanVien.Columns[0].Visible = false;
            dtg_DanhSachNhanVien.Columns[9].Visible= false;
            dtg_DanhSachNhanVien.Rows.Clear();
            DataGridViewButtonColumn cbn_ChucNangSua = new DataGridViewButtonColumn();
            cbn_ChucNangSua.HeaderText = "Chức năng sửa";
            cbn_ChucNangSua.Text = "Sửa";
            cbn_ChucNangSua.Name = "btn_Suanhanvien";
            cbn_ChucNangSua.UseColumnTextForButtonValue = true;
            dtg_DanhSachNhanVien.Columns.Add(cbn_ChucNangSua);

            DataGridViewButtonColumn cbn_ChucNangXoa = new DataGridViewButtonColumn();
            cbn_ChucNangXoa.HeaderText = "Chức năng xóa";
            cbn_ChucNangXoa.Text = "Xóa";
            cbn_ChucNangXoa.Name = "btn_Xoanhanvien";
            cbn_ChucNangXoa.UseColumnTextForButtonValue = true;
            dtg_DanhSachNhanVien.Columns.Add(cbn_ChucNangXoa);
            foreach (var item in list.OrderBy(p => p.MaNV))
            {
                dtg_DanhSachNhanVien.Rows.Add(item.ID, item.MaNV, item.TenNV, item.NgaySinh, (item.GioiTinh==1)?"Nam":(item.GioiTinh==2)?"Nữ":"Khác", item.DiaChi, item.SDT, item.CCCD, item.Luong, item.IDCv,item.TenCV);
            }
            

        }

        private void dtg_DanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DanhSachNhanVien.Rows.Count - 1)
            {
                return;
            }
            ID = Guid.Parse(Convert.ToString(dtg_DanhSachNhanVien.Rows[rd].Cells[0].Value));
            MaNV = Convert.ToString(dtg_DanhSachNhanVien.Rows[rd].Cells[1].Value);
            TenNV = Convert.ToString(dtg_DanhSachNhanVien.Rows[rd].Cells[2].Value);
            NgaySinh = DateTime.Parse(Convert.ToString(dtg_DanhSachNhanVien.Rows[rd].Cells[3].Value));
            GioiTinh = (dtg_DanhSachNhanVien.Rows[rd].Cells[4].Value.ToString() == "Nam") ? 1 : (dtg_DanhSachNhanVien.Rows[rd].Cells[4].Value.ToString() == "Nữ") ? 2 : 3;
            DiaChi= Convert.ToString(dtg_DanhSachNhanVien.Rows[rd].Cells[5].Value);
            SDT= Convert.ToString(dtg_DanhSachNhanVien.Rows[rd].Cells[6].Value);
            CCCD= Convert.ToString(dtg_DanhSachNhanVien.Rows[rd].Cells[7].Value);
            Luong = Convert.ToInt32(dtg_DanhSachNhanVien.Rows[rd].Cells[8].Value);
            IDCv = Guid.Parse(dtg_DanhSachNhanVien.Rows[rd].Cells[9].Value.ToString());
            TenCV = Convert.ToString(dtg_DanhSachNhanVien.Rows[rd].Cells[10].Value);

        }

        private void dtg_DanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DanhSachNhanVien.Columns[e.ColumnIndex].Name == "btn_Suanhanvien")
            {
               FrmBtnSuaNhanVien fm= new FrmBtnSuaNhanVien(LoadData);
                fm.ID = ID;
                fm.MaNV= MaNV;
                fm.TenNV= TenNV;
                fm.NgaySinh = NgaySinh;
                fm.GioiTinh= GioiTinh;
                fm.DiaChi = DiaChi;
                fm.SDT = SDT;
                fm.CCCD = CCCD;
                fm.Luong= Luong;
                fm.IDCv= IDCv;
                fm.TenCV= TenCV;
                fm.ShowDialog();
                
                
            }
            if(dtg_DanhSachNhanVien.Columns[e.ColumnIndex].Name == "btn_Xoanhanvien")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa Nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    NhanVienView NV = new NhanVienView();
                    NV= _iqLNhanVien.GetAll().FirstOrDefault(c=>c.ID == ID);
                    MessageBox.Show(_iqLNhanVien.Delete(NV));
                    LoadData(_iqLNhanVien.GetAll());
                }
                else
                {
                    MessageBox.Show("Xoá nhân viên thất bại");
                }
            }
            
        }

        private void btn_ThemNhanVien_Click(object sender, EventArgs e)
        {
            FrmBtnThemNhanVien fm = new FrmBtnThemNhanVien(LoadData);
            fm.ShowDialog(this);
            
        }

        private void FrmQLNhanVien_Load(object sender, EventArgs e)
        {

        }


        private void tbt_SearchStaffName_TextChanged(object sender, EventArgs e)
        {
            string searchnv=tbt_SearchStaffName.Text;
            List<NhanVienView> listnvsearch = _iqLNhanVien.GetAll().Where(c => c.TenNV.ToLower().Contains(searchnv.ToLower())).ToList();
            LoadData(listnvsearch);
        }

        private void dtg_DanhSachNhanVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }
       
    }
}
