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
namespace GUI.View.AddControls
{
    public partial class FrmBtnThemNhieuPhong : Form
    {
        private IQLPhongService _qlphong;
        private IQLLoaiPhongService qlloaiPhong;
        public FrmBtnThemNhieuPhong()
        {
            InitializeComponent();
            _qlphong = new IPhongService();
            qlloaiPhong = new ILoaiPhongService();
            LoadCBB();
        }

        private void LoadCBB()
        {
            cbb_tang.Items.Add("Tầng 1");
            cbb_tang.Items.Add("Tầng 2");
            cbb_tang.Items.Add("Tầng 3");

            var lst = qlloaiPhong.GetAll();
            foreach (var item in lst)
            {
                cbb_TenLoaiPhong.Items.Add(item.TenLoaiPhong);
            }

            cbb_TinhTrangPhong.Items.Clear();
            cbb_TinhTrangPhong.Items.Add("Phòng trống");
            cbb_TinhTrangPhong.Items.Add("Phòng có khách");
            cbb_TinhTrangPhong.Items.Add("Phòng đang dọn dẹp");
        }
        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            DialogResult dls = MessageBox.Show("Bạn có muốn thêm nhũng phòng này không ?","Trả Lời",MessageBoxButtons.YesNo);
            if(dls == DialogResult.Yes)
            {
                for(int x = 0; x < Convert.ToInt32(tb_SoLuongThem.Text) ; x++)
                {
                    PhongView pv = new PhongView();
                    var lstPhong = _qlphong.GetAll();
                    var lstmaPhong = _qlphong.GetAll().Select(p => p.MaPhong).ToList();
                    if (cbb_tang.Text == "Tầng 1")
                    {
                        var lstMaPhongTang1 = lstmaPhong.Where(p => p.Substring(1, 1) == "1");
                        if (lstMaPhongTang1.Count() == 0)
                        {
                            pv.MaPhong = "P101";
                        }
                        else
                        {
                            int so = lstMaPhongTang1.Max(p => Convert.ToInt32(p.Substring(3, p.Length - 3)) + 1);
                            if (so<= 9)
                            {
                                pv.MaPhong = "P10" + so;
                            }
                            else
                            {
                                int SoLon = lstMaPhongTang1.Max(p => Convert.ToInt32(p.Substring(2, p.Length - 2)) + 1);
                                pv.MaPhong = "P1" + SoLon;
                            }                         
                        }
                    }
                    else if(cbb_tang.Text == "Tầng 2")
                    {
                        var lstMaPhongTang2 = lstmaPhong.Where(p => p.Substring(1, 1) == "2");
                        if (lstMaPhongTang2.Count() == 0)
                        {
                            pv.MaPhong = "P201";
                        }
                        else
                        {
                            int so = lstMaPhongTang2.Max(p => Convert.ToInt32(p.Substring(3, p.Length - 3)) + 1);
                            if (so <= 9)
                            {
                                pv.MaPhong = "P20" + so;
                            }
                            else
                            {
                                int SoLon = lstMaPhongTang2.Max(p => Convert.ToInt32(p.Substring(2, p.Length - 2)) + 1);
                                pv.MaPhong = "P2" + SoLon;
                            }
                        }
                    }
                    else if(cbb_tang.Text == "Tầng 3")
                    {
                        var lstMaPhongTang3 = lstmaPhong.Where(p => p.Substring(1, 1) == "3");
                        if (lstMaPhongTang3.Count() == 0)
                        {
                            pv.MaPhong = "P301";
                        }
                        else
                        {// P310
                            int so = lstMaPhongTang3.Max(p => Convert.ToInt32(p.Substring(3, p.Length - 3)) + 1);
                            if (so <= 9)
                            {
                                pv.MaPhong = "P30" + so;
                            }
                            else
                            {
                                int SoLon = lstMaPhongTang3.Max(p => Convert.ToInt32(p.Substring(2, p.Length - 2)) + 1);
                                pv.MaPhong = "P3" + SoLon;
                            }
                        }

                    }
         
                    if (cbb_TinhTrangPhong.Text == "Phòng có khách")
                    {
                        MessageBox.Show("Bạn không thế thêm phòng với trạng thái có khách đang thuê !!");
                        return;
                    }
                    pv.TinhTrang = cbb_TinhTrangPhong.Text == "Phòng trống" ? 0 : cbb_TinhTrangPhong.Text == "Phòng có khách" ? 1 : 2;
                    pv.IDLoaiPhong = _qlphong.GetIdLoaiPhongByName(cbb_TenLoaiPhong.Text);
                    _qlphong.Add(pv);
                   
                    
                }
                MessageBox.Show("Thêm phòng thành công");
            }
            else if(dls == DialogResult.No)
            {
                MessageBox.Show("Bạn đã không thêm nhưng phòng này");
            }
        }
    }
}
