using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.Ultilities;
using System.Windows.Forms;

namespace GUI.View.AddControls
{
    public partial class FrmBtnSuaLoaiPhong : Form
    {
        private IQLLoaiPhongService _iqlLoaiPhongService;
        private Validations VAL;
        public Guid IDLoaiPhongSua { get; set; }
        public string MaLoaiPhongSua { get; set; }
        public string TenLoaiPhongSua { get; set; }
        public int SoGiuongLoaiPhongSua { get; set; }
        public int GiaNgayLoaiPhongSua { get; set; }
        public FrmBtnSuaLoaiPhong()
        {
            InitializeComponent();
            _iqlLoaiPhongService = new ILoaiPhongService();
            VAL= new Validations();
        }

        private void btn_SuaLoaiPhong_Click(object sender, EventArgs e)
        {
            if (VAL.CheckRong(tb_TenLoaiPhong.Text) == false || VAL.CheckRong(tb_MaLoaiPhong.Text) == false || VAL.CheckRong(tb_SoGiuong.Text) == false || VAL.CheckRong(tb_GiaNgay.Text) == false)
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn sửa loại phòng này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoaiPhongView lpv = new LoaiPhongView();
                lpv.ID = IDLoaiPhongSua;
                lpv.MaLoaiPhong = tb_MaLoaiPhong.Text;
                lpv.TenLoaiPhong = tb_TenLoaiPhong.Text;
                lpv.SoGiuong = int.Parse(tb_SoGiuong.Text);
                lpv.GiaNgay = int.Parse(tb_GiaNgay.Text);
                MessageBox.Show(_iqlLoaiPhongService.Update(lpv));
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy sửa loại phòng");
            }
        }

        private void FrmBtnSuaLoaiPhong_Load(object sender, EventArgs e)
        {
            tb_MaLoaiPhong.Text = MaLoaiPhongSua;
            tb_TenLoaiPhong.Text = TenLoaiPhongSua;
            tb_SoGiuong.Text = Convert.ToString(SoGiuongLoaiPhongSua);
            tb_GiaNgay.Text = Convert.ToString(GiaNgayLoaiPhongSua);
        }

        private void btn_HuySuaLoaiPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
