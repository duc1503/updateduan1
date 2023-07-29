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
using BUS.Ultilities;
using BUS.ViewModels;

namespace GUI.View.AddControls
{
    public partial class FrmBtnThemChucVu : Form
    {
        private IChucVuService _chucVuService;
        private Validations val;
        public FrmBtnThemChucVu()
        {
            _chucVuService = new ChucVuService();
            InitializeComponent();
            val= new Validations();
        }
        private ChucVuView GetData()
        {
            return new ChucVuView() { ID = Guid.Empty, MaCV = tb_MaChucVuThem.Text, TenCV = tb_tenChucVuThem.Text };
        }

        private void btn_ThemChucVu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (val.CheckRong(tb_MaChucVuThem.Text) == false || val.CheckRong(tb_tenChucVuThem.Text) == false)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                    return;
                }
                MessageBox.Show(_chucVuService.Add(GetData()));
            }
            if (result == DialogResult.No) MessageBox.Show("Canceled");
            this.Close();
        }

        private void btn_HuyThemChucVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
