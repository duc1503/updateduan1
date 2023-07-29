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
using GUI.View.UserControls;
using BUS.Ultilities;


namespace GUI.View.AddControls
{
    public partial class FrmBtnSuaChucVu : Form
    {
        public send_cv _send;
        public ChucVuView _cvView;
        private IChucVuService _chucVuService;
        Validations VAL;
        public FrmBtnSuaChucVu()
        {
            _chucVuService = new ChucVuService();
            _cvView = new ChucVuView();
            InitializeComponent();
            
        }
        public FrmBtnSuaChucVu(send_cv send)
        {
            _chucVuService = new ChucVuService();
            _cvView = new ChucVuView();
            InitializeComponent();
            this._send= send;
            VAL= new Validations();

        }
        private void LoadData()
        {
            tb_MaChucVuSua.Text = _cvView.MaCV;
            tb_tenChucVuSua.Text = _cvView.TenCV;
        }
        private ChucVuView GetData()
        {
            return new ChucVuView()
            {
                ID = _cvView.ID,
                MaCV = tb_MaChucVuSua.Text,
                TenCV = tb_tenChucVuSua.Text
            };
        }
        private void btn_SuaChucVu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                if (VAL.CheckRong(tb_MaChucVuSua.Text) == false||VAL.CheckRong(tb_tenChucVuSua.Text)==false)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                    return;
                }
                MessageBox.Show(_chucVuService.Update(GetData()));
                _send(string.Empty);
                
            }
            if (result == DialogResult.No) MessageBox.Show("Canncel");
            
        }

        private void btn_HuySuaChucVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBtnSuaChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
