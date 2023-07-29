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
using System.Windows.Documents;
using System.Windows.Forms;
using BUS.Ultilities;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge;
using ZXing;

namespace GUI.View.AddControls
{
    public partial class FrmBtnDatPhong : Form
    {
        public send_pt _send;
        private IQLPhongService _iqlPhongService;
        private IQLKhachHangService _iqlKHService;
        private IQLPhieuThueService _iqlPTService;
        private IQLChiTietPhieuThueService _iqlCTPTService;
        private Validations val;
        private Guid IdRoomPicked { get; set; }


        private List<PhongView> list_phong_trong;

        public TimeSpan oneHour = new TimeSpan(1, 0, 0);
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private List<PhongView> lstRoomChoosen;
        public FrmBtnDatPhong(send_pt send)
        {
            InitializeComponent();
            this._send = send;
            _iqlPhongService = new IPhongService();
            _iqlKHService = new QLKhachHangService();
            _iqlPTService = new QLPhieuThueService();
            _iqlCTPTService = new QLChiTietPhieuThueService();
            lstRoomChoosen = new List<PhongView>();
            list_phong_trong = new List<PhongView>();
            val = new Validations();
            loadcbo();

            /*LoadDataDSPhongTrong();
            LoadDataDSPhongDaChon();*/

        }

        public void loadcbo()
        {
            cbb_GioiTinhKH.Items.Add("Nam");
            cbb_GioiTinhKH.Items.Add("Nữ");
            cbb_GioiTinhKH.Items.Add("Khác");
        }
        private void LoadDataDSPhongTrong(List<PhongView> list)
        {
            dtg_DSPhongTrong.ColumnCount = 3;
            dtg_DSPhongTrong.Rows.Clear();
            dtg_DSPhongTrong.Columns[0].Name = "Id Room";
            dtg_DSPhongTrong.Columns[0].Visible = false;
            dtg_DSPhongTrong.Columns[1].Name = "Mã phòng";
            dtg_DSPhongTrong.Columns[2].Name = "Loại phòng";
            dtg_DSPhongTrong.Rows.Clear();
            foreach (var item in list)
            {
                dtg_DSPhongTrong.Rows.Add(item.Id, item.MaPhong, item.TenLoaiPhong);
            }

            DataGridViewButtonColumn cbn_ChucNangChonPhong = new DataGridViewButtonColumn();
            cbn_ChucNangChonPhong.HeaderText = "Thêm";
            cbn_ChucNangChonPhong.Text = "Thêm";
            cbn_ChucNangChonPhong.Name = "btn_ChooseRoom";
            cbn_ChucNangChonPhong.UseColumnTextForButtonValue = true;
            dtg_DSPhongTrong.Columns.Add(cbn_ChucNangChonPhong);
        }

        private void LoadDataDSPhongDaChon(List<PhongView> _list)
        {
            dtg_DSPhongDaChon.ColumnCount = 3;
            dtg_DSPhongDaChon.Rows.Clear();
            dtg_DSPhongDaChon.Columns[0].Name = "Id Room";
            dtg_DSPhongDaChon.Columns[0].Visible = false;
            dtg_DSPhongDaChon.Columns[1].Name = "Mã phòng";
            dtg_DSPhongDaChon.Columns[2].Name = "Loại phòng";

            foreach (var item in _list)
            {
                dtg_DSPhongDaChon.Rows.Add(item.Id, item.MaPhong, item.TenLoaiPhong);
            }

            DataGridViewButtonColumn cbn_ChucNangHuyChonPhong = new DataGridViewButtonColumn();
            cbn_ChucNangHuyChonPhong.HeaderText = "Hủy";
            cbn_ChucNangHuyChonPhong.Text = "Hủy";
            cbn_ChucNangHuyChonPhong.Name = "btn_CancelChooseRoom";
            cbn_ChucNangHuyChonPhong.UseColumnTextForButtonValue = true;
            dtg_DSPhongDaChon.Columns.Add(cbn_ChucNangHuyChonPhong);
        }

        private void dtg_DSPhongTrong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DSPhongTrong.Columns[e.ColumnIndex].Name == "btn_ChooseRoom")
            {

                PhongView roomChoosen = _iqlPhongService.GetAll().FirstOrDefault(p => p.Id == IdRoomPicked);
                for (int i = 0; i < list_phong_trong.Count; i++)
                {
                    if (list_phong_trong[i].Id == roomChoosen.Id)
                    {
                        lstRoomChoosen.Add(list_phong_trong[i]);
                        list_phong_trong.Remove(list_phong_trong[i]);
                    }
                }

                LoadDataDSPhongTrong(list_phong_trong);
                LoadDataDSPhongDaChon(lstRoomChoosen);
                /*_iqlPhongService.Update(pv);*/
                /*LoadDataDSPhongTrong();*/

            }
        }

        private void dtg_DSPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DSPhongTrong.Rows.Count - 1)
            {
                return;
            }
            IdRoomPicked = Guid.Parse(dtg_DSPhongTrong.Rows[rd].Cells[0].Value.ToString());
        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đặt phòng không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DateTime ngayBatDau = dtp_NgayBatDau.Value;
                DateTime NgayKetThuc = dtp_NgayKetThuc.Value;
                if(val.CheckCCCD(tb_CCCDKH.Text)==false)
                {
                MessageBox.Show("Số CCCD không hợp lệ vui lòng nhập lại","Thông báo");
                return;
                } else if(val.CheckSDT(tb_SDTKH.Text)==false)
                {
                MessageBox.Show("Số điện thoại không hợp lệ vui lòng nhập lại", "Thông báo");
                return;
                } else if (val.CheckRong(tb_TenKH.Text) == false || val.CheckRong(tb_SDTKH.Text)==false||val.CheckRong(tb_DiaChiKH.Text)==false||val.CheckRong(tb_QuocTichKH.Text)==false||val.CheckRong(tb_CCCDKH.Text)==false||val.CheckRong(tb_QuocTichKH.Text)==false)
                {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin","Thông Báo");
                return;
                } else if (lstRoomChoosen.Count==0)
                {
                MessageBox.Show("Vui lòng chọn phòng để đặt", "Thông báo");
                return;
                } else if ((NgayKetThuc - ngayBatDau).TotalHours <= 1)
                {
                    MessageBox.Show("Ngày nhận phải lớn hơn ngày trả !");
                    return;
                }
                
                PhieuThueView ptv = new PhieuThueView();
                ptv.NgayLapPhieu = DateTime.Now;
                ptv.IdNV = FrmMain.IdNV;
                var lstmaPT = _iqlPTService.GetAll().Select(p => p.MaPhieuThue);

                int so = lstmaPT.Max() + 1;
                ptv.MaPhieuThue = so;

                //ptv.MaPhieuThue = 1;
                var lstKH = _iqlKHService.GetAll().FirstOrDefault(p => p.CCCD == tb_CCCDKH.Text);
                var somkh=_iqlKHService.GetAll().OrderBy(p=>p.MaKH).Select(p=>p.MaKH).ToList();
                if (lstKH == null)
                {
                    KhachHangView khv = new KhachHangView();
                    khv.CCCD = tb_CCCDKH.Text;
                //khv.MaKH = tb_MaKH.Text;
                    if (somkh.Count == 0)
                    {
                        khv.MaKH = "KH1";
                    }
                    else
                    {
                        int soduoima=somkh.Max(p=>Convert.ToInt32(p.Substring(2,p.Length-2)))+1;
                        khv.MaKH = "KH" + soduoima;
                    }
                    khv.HovaTen = tb_TenKH.Text;
                    khv.SDT = tb_SDTKH.Text;
                    khv.DiaChi = tb_DiaChiKH.Text;
                    khv.QuocTich = tb_QuocTichKH.Text;
                    khv.GioiTinh = cbb_GioiTinhKH.Text == "Nam" ? 1 : cbb_GioiTinhKH.Text == "Nữ" ? 2 : 3;
                    _iqlKHService.Add(khv);
                    ptv.IdKH = _iqlKHService.GetAll().FirstOrDefault(p => p.CCCD == tb_CCCDKH.Text).ID;
                }
                else
                {
                    ptv.IdKH = lstKH.ID;
                }
                _iqlPTService.Add(ptv);

                foreach (var item in lstRoomChoosen)
                {
                    // ĐOẠN NÀY là tôi ko biết là đặt xong chuyển sang trạng thái phòng khi đặt là  j ko thig tùy ý ông nhé  ông tự ấy theo đsung ý ông nhé ( chọn đc cái list muốn đặt rồi ông mới thay đổi trạng thái phòng)

                    ChiTietPhieuThueView ctptv = new ChiTietPhieuThueView();
                    ctptv.NgayBatDau = dtp_NgayBatDau.Value;
                    ctptv.NgayKetThuc = dtp_NgayKetThuc.Value;
                    ctptv.IdPhong = item.Id;
                    ctptv.IdPhieuThue = _iqlPTService.GetAll().FirstOrDefault(p => p.MaPhieuThue == so).ID;
                    //DateTime now = DateTime.Now;
                    _iqlCTPTService.Add(ctptv);
                    
                }
                MessageBox.Show("Đặt phòng thành công");
                _send(_iqlPTService.GetAll());

            }
            if (result == DialogResult.No)
            {
                foreach (var item in lstRoomChoosen)
                {
                    PhongView pv = new PhongView();
                    pv.Id = item.Id;
                    pv.MaPhong = item.MaPhong;
                    pv.IDLoaiPhong = item.IDLoaiPhong;
                    pv.TinhTrang = 0;
                    _iqlPhongService.Update(pv);
                }
                MessageBox.Show("Bạn đã hủy đặt phòng");
            }
            _send(_iqlPTService.GetAll());
        }

   

        private void dtg_DSPhongDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DSPhongDaChon.Rows.Count - 1)
            {
                return;
            }
            IdRoomPicked = Guid.Parse(dtg_DSPhongDaChon.Rows[rd].Cells[0].Value.ToString());
        }

        private void dtg_DSPhongDaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DSPhongDaChon.Columns[e.ColumnIndex].Name == "btn_CancelChooseRoom")
            {
                var roomChoosen = _iqlPhongService.GetAll().FirstOrDefault(p => p.Id == IdRoomPicked);
                //var room = lstRoomChoosen.FirstOrDefault(p => p.Id == IdRoomPicked);
                for (int i = 0; i < lstRoomChoosen.Count; i++)
                {
                    if (lstRoomChoosen[i].Id == roomChoosen.Id)
                    {
                        list_phong_trong.Add(lstRoomChoosen[i]);
                        lstRoomChoosen.Remove(lstRoomChoosen[i]);

                    }
                }
                LoadDataDSPhongDaChon(lstRoomChoosen);
                LoadDataDSPhongTrong(list_phong_trong);

            }
        }

        public void take_empty_room()
        {

            list_phong_trong.Clear();
            lstRoomChoosen.Clear();
            DateTime dt1 = dtp_NgayBatDau.Value;
            DateTime dt2 = dtp_NgayKetThuc.Value;

            if (dt1.CompareTo(dt2) >= 1)
            {
                MessageBox.Show("Ngày lọc không hợp lệ, Vui lòng nhập lại", "Thông Báo");
            }
            List<ChiTietPhieuThueView> y = _iqlCTPTService.GetAll().ToList();
            List<ChiTietPhieuThueView> List_loc_ctpt = new List<ChiTietPhieuThueView>();
            foreach (var item in y)
            {
                if (item.NgayBatDau.CompareTo(dt1) >= 1 && item.NgayKetThuc.CompareTo(dt2) <= -1)
                {
                    List_loc_ctpt.Add(item);
                }
                else if (item.NgayBatDau.CompareTo(dt1) <= -1 && item.NgayKetThuc.CompareTo(dt1) >= 1 && item.NgayKetThuc.CompareTo(dt2) <= -1)
                {
                    List_loc_ctpt.Add(item);
                }
                else if (item.NgayBatDau.CompareTo(dt1) >= 1 && item.NgayBatDau.CompareTo(dt2) <= -1 && item.NgayKetThuc.CompareTo(dt2) >= 1)
                {
                    List_loc_ctpt.Add(item);
                }
                else if (item.NgayBatDau.CompareTo(dt1) <= -1 && item.NgayKetThuc.CompareTo(dt2) >= 1)
                {
                    List_loc_ctpt.Add(item);
                }
            }
            if (List_loc_ctpt.Count == 0)
            {
                list_phong_trong = _iqlPhongService.GetAll();
            }
            else
            {
                List<PhongView> list_phong_co_kh = new List<PhongView>();
                //foreach (var item in List_loc_ctpt)
                //{
                //    // null
                //    PhongView pv = _iqlPhongService.GetAll().FirstOrDefault(c => c.Id == item.IdPhong);
                //    list_phong_co_kh.Add(pv);
                //}
                for (int i = 0; i < List_loc_ctpt.Count; i++)
                {
                    // OK
                   // MessageBox.Show(List_loc_ctpt[i].MaPhong + "phong co trong ctpt");
                    PhongView pv = _iqlPhongService.GetAll().FirstOrDefault(c => c.Id == List_loc_ctpt[i].IdPhong);
                    list_phong_co_kh.Add(pv);
                   // MessageBox.Show(list_phong_co_kh[i].MaPhong + "lst phong co KH sau khi add");
                    // OK
                }

                // check tu day
                // DB 34 phong || get all = 27
                List<PhongView> listt = _iqlPhongService.GetAll().OrderBy(c => c.MaPhong).ToList();
                //MessageBox.Show(listt.Count.ToString());// van la 34
                list_phong_co_kh = list_phong_co_kh.OrderBy(C => C.MaPhong).ToList();
                // OK

                // Loi tu duoi 
                //for (int i = 0; i < listt.Count; i++)
                //{
                //    for (int j = 0; j < list_phong_co_kh.Count; j++)
                //    {
                //        if (listt[0].MaPhong == list_phong_co_kh[0].MaPhong)
                //        {
                //            listt = listt.Where(c => c.MaPhong != listt[0].MaPhong).ToList();
                //            list_phong_co_kh = list_phong_co_kh.Where(c => c.MaPhong != list_phong_co_kh[0].MaPhong).ToList();
                //            // i = -1;
                //            i = 0;
                //            j = 0;
                //            if (list_phong_co_kh.Count == 0)
                //            {
                //                break;
                //            }
                //        }
                //        else
                //        {
                //            if (listt[i].MaPhong == list_phong_co_kh[j].MaPhong)
                //            {
                //                listt = listt.Where(c => c.MaPhong != listt[i].MaPhong).ToList();
                //                list_phong_co_kh = list_phong_co_kh.Where(c => c.MaPhong != list_phong_co_kh[j].MaPhong).ToList();
                //                i = 0;
                //                j = 0;
                //                if (list_phong_co_kh.Count == 0)
                //                {
                //                    break;
                //                }
                //            }
                //        }
                //    }
                //}


                //for (int i = 0; i < listt.Count; i++)
                //{
                //    for (int j = 0; j < list_phong_co_kh.Count; j++)
                //    {
                //        if (listt[i].MaPhong == list_phong_co_kh[j].MaPhong)
                //        {


                //        }
                //    }
                //}
                var listMaPhongTatCaPhong = new List<string>();
                var listMaPhongCoKH = new  List<string>();
                foreach (PhongView pv in listt)
                {
                    listMaPhongTatCaPhong.Add(pv.MaPhong);
                }
                foreach (var item in list_phong_co_kh)
                {
                    listMaPhongCoKH.Add(item.MaPhong);
                }

                IEnumerable<string> listMaPhongTrong = listMaPhongTatCaPhong.Except(listMaPhongCoKH);

                //MessageBox.Show(listMaPhongTrong.Count().ToString());
                //MessageBox.Show(list_phong_trong.Count.ToString());
                //list_phong_trong = listt;
                foreach (var item in listMaPhongTrong)
                {
                    var phongTrong = listt.FirstOrDefault(p => p.MaPhong == item);
                    list_phong_trong.Add(phongTrong);
                }
                //MessageBox.Show(list_phong_trong.Count.ToString());
            }
            LoadDataDSPhongTrong(list_phong_trong);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtp_NgayBatDau.Value;
            DateTime NgayKetThuc = dtp_NgayKetThuc.Value;
            
            if ((ngayBatDau - DateTime.Now).TotalHours <= 0)
            {
                MessageBox.Show("Bạn không thể chọn ngày nhận phòng nhỏ hơn thời điểm hiện tại!");
                return;
            }
            if ((NgayKetThuc - ngayBatDau).TotalHours <= 1)
            {
                MessageBox.Show("Ngày nhận phải lớn hơn ngày trả !");
                return;
            }
            take_empty_room();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void btn_HuyDatPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cai thu vien Aforce  va zxing 
        // aforce de doc video
        // zxing de decode tu img sang string

        private void FrmBtnDatPhong_Load(object sender, EventArgs e)
        {
            dtp_NgayBatDau.Format = DateTimePickerFormat.Custom;
            dtp_NgayBatDau.CustomFormat = "MM'/'dd'/'yyyy hh':'mm tt";
            dtp_NgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtp_NgayKetThuc.CustomFormat = "MM'/'dd'/'yyyy hh':'mm tt";

            // Tìm kiếm web cam , Thêm tên của web cam vào combobox
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo item in filterInfoCollection)
            {
                cbb_CameraName.Items.Add(item.Name);
            }
            cbb_CameraName.SelectedIndex = 0;
            //captureDevice = new VideoCaptureDevice();
        }

        private void btn_OpenFormScanCCCD_Click(object sender, EventArgs e)
        {
            // Tạo 1 frame sự kiện mới cho phép cập nhật img scan từ web cam vào Picture box
            if (tb_TextInfor.Text != "")
            {
                MessageBox.Show("Vui lòng mở lại form để có thể thay đổi thông tin scan !!");
                return;
            }
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbb_CameraName.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            TimeResetCam.Start();   
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
           pb_CamScan.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void FrmBtnDatPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            //captureDevice.Stop();
            //Đóng cam khi form đóng

            if (captureDevice != null)
            {
                if (captureDevice.IsRunning == true)
                {
                    captureDevice.SignalToStop();
                    captureDevice = null;
                }
            }
        }

        private void TimeResetCam_Tick(object sender, EventArgs e)
        {
            // Reset Img qr code từ web cam mỗi lần 1 s
            // 1s có thể quét lại đc
            if (pb_CamScan.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pb_CamScan.Image);
                if (result != null)
                {
                    tb_TextInfor.Text = result.ToString();
                    TimeResetCam.Stop();
                    try
                    {
                        if (captureDevice != null)
                        {
                            if (captureDevice.IsRunning == true)
                            {
                                captureDevice.SignalToStop();
                                captureDevice = null;
                            }
                        }
                    }
                    catch (Exception a)
                    {

                        MessageBox.Show(a + "");
                    }
                }
            }     

        }

        private void tb_TextInfor_TextChanged(object sender, EventArgs e)
        {
            if (tb_TextInfor.Text == "" )
            {
                return;
            }
            // 001203048325||Phạm Ánh Dương|30092003|Nam|2/25/98C phố Hữu Nghị, Xuân Khanh,Sơn Tây,Hà Nội|08022021
            string InforCus = tb_TextInfor.Text;
            string[] lstCharInforCus =  InforCus.Split('|');
            tb_CCCDKH.Text = lstCharInforCus[0];
            tb_TenKH.Text = lstCharInforCus[2];
            cbb_GioiTinhKH.Text = lstCharInforCus[4];
            string DiaChi = lstCharInforCus[5];
            string[] lstCharDiaChi = DiaChi.Split(',');
            tb_DiaChiKH.Text = lstCharDiaChi[lstCharDiaChi.Length - 1];
        }    
    }
}