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
    public delegate void send_tk(List<TaiKhoanView> list);
    public partial class FrmQLTaiKhoan : Form
    {
        IQLTaiKhoanServices _iqLTaiKhoan;
        IQLNhanVienServices _iqLNhanVien;

        public Guid ID;
        public string TenTaiKhoan;
        public string MatKhau;
        public int CapDoQuyen;
        public Guid? IDNv;
        public string? TenNV;
        public string MaNv;
        public FrmQLTaiKhoan()
        {
            InitializeComponent();
            _iqLTaiKhoan = new QLTaiKhoanServices();
            _iqLNhanVien= new QLNhanVienServices();
            loaddata(_iqLTaiKhoan.GetAll());

        }
        public void loaddata(List<TaiKhoanView> list)
        {
            dtg_DanhSachTaiKhoan.ColumnCount = 7;
            dtg_DanhSachTaiKhoan.Columns[0].Name="ID";
            dtg_DanhSachTaiKhoan.Columns[1].Name="Tên tài khoản";
            dtg_DanhSachTaiKhoan.Columns[2].Name = "Mã Nhân Viên";
            dtg_DanhSachTaiKhoan.Columns[3].Name = "Tên Nhân Viên";
            dtg_DanhSachTaiKhoan.Columns[4].Name = "IDnv";
            dtg_DanhSachTaiKhoan.Columns[5].Name = "mật khẩu";
            dtg_DanhSachTaiKhoan.Columns[6].Name = "Cấp độ quyền";
            dtg_DanhSachTaiKhoan.Columns[0].Visible= false;
            dtg_DanhSachTaiKhoan.Columns[4].Visible= false;
            dtg_DanhSachTaiKhoan.Columns[5].Visible= false;
            dtg_DanhSachTaiKhoan.Columns[1].AutoSizeMode=DataGridViewAutoSizeColumnMode.AllCells;
            dtg_DanhSachTaiKhoan.Columns[2].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            dtg_DanhSachTaiKhoan.Columns[3].AutoSizeMode=DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dtg_DanhSachTaiKhoan.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_DanhSachTaiKhoan.Rows.Clear();

            DataGridViewButtonColumn cbn_ChucNangSua = new DataGridViewButtonColumn();
            cbn_ChucNangSua.HeaderText = "Chức năng sửa";
            cbn_ChucNangSua.Text = "Sửa";
            cbn_ChucNangSua.Name = "btn_Suataikhoan";
            cbn_ChucNangSua.UseColumnTextForButtonValue = true;
            dtg_DanhSachTaiKhoan.Columns.Add(cbn_ChucNangSua);

            DataGridViewButtonColumn cbn_ChucNangXoa = new DataGridViewButtonColumn();
            cbn_ChucNangXoa.HeaderText = "Chức năng xóa";
            cbn_ChucNangXoa.Text = "Xóa";
            cbn_ChucNangXoa.Name = "btn_Xoataikhoan";
            cbn_ChucNangXoa.UseColumnTextForButtonValue = true;
            dtg_DanhSachTaiKhoan.Columns.Add(cbn_ChucNangXoa);
            foreach (var item in list)
            {
                dtg_DanhSachTaiKhoan.Rows.Add(item.ID, item.TenTaiKhoan,(item.MaNv==null)?"":item.MaNv, item.TenNV, item.IDNv, item.MatKhau, item.CapDoQuyen);
            }
           

        }

        private void btn_ThemTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmBtnThemTaiKhoan fm = new FrmBtnThemTaiKhoan(loaddata);
            fm.ShowDialog();
        }

        private void dtg_DanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DanhSachTaiKhoan.Rows.Count - 1)
            {
                return;
            }
            ID = Guid.Parse(dtg_DanhSachTaiKhoan.Rows[rd].Cells[0].Value.ToString());
            TenTaiKhoan = dtg_DanhSachTaiKhoan.Rows[rd].Cells[1].Value.ToString();
            MaNv = dtg_DanhSachTaiKhoan.Rows[rd].Cells[2].Value.ToString();
            //TenNV = dtg_DanhSachTaiKhoan.Rows[rd].Cells[3].Value.ToString();
            //IDNv = Guid.Parse(dtg_DanhSachTaiKhoan.Rows[rd].Cells[4].Value.ToString());
            MatKhau = dtg_DanhSachTaiKhoan.Rows[rd].Cells[5].Value.ToString();
            CapDoQuyen = int.Parse(dtg_DanhSachTaiKhoan.Rows[rd].Cells[6].Value.ToString());
            
        }

        private void dtg_DanhSachTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtg_DanhSachTaiKhoan.Columns[e.ColumnIndex].Name == "btn_Suataikhoan")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật tài khoản này không", "Thông báo", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    FrmBtnSuaTaiKhoan fm = new FrmBtnSuaTaiKhoan(loaddata);
                    fm.ID = ID;
                    fm.MaNv = MaNv;
                    fm.TenTaiKhoan = TenTaiKhoan;
                    fm.TenNV= TenNV;
                    fm.IDNv= IDNv;
                    fm.MatKhau= MatKhau;
                    fm.CapDoQuyen= CapDoQuyen;
                    fm.ShowDialog();
                    
                    
                }
            }
            if (dtg_DanhSachTaiKhoan.Columns[e.ColumnIndex].Name== "btn_Xoataikhoan")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa tài khoản này không", "Thông báo", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    TaiKhoanView tk = new TaiKhoanView();
                    tk = _iqLTaiKhoan.GetAll().FirstOrDefault(C=>C.ID==ID);
                    MessageBox.Show(_iqLTaiKhoan.Delete(tk));
                    loaddata(_iqLTaiKhoan.GetAll());
                }else
                {
                    MessageBox.Show("Xóa nhân viên thất bại");
                }
            }
        }


        private void tbt_SearchAccountName_TextChanged(object sender, EventArgs e)
        {
            string search = tbt_SearchAccountName.Text;
            List<TaiKhoanView> listsearchtk = _iqLTaiKhoan.GetAll().Where(c => c.TenTaiKhoan.ToLower().Contains(search.ToLower())).ToList();
            loaddata(listsearchtk);
            
        }
    }
}