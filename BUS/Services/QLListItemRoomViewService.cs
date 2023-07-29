using BUS.IServices;
using BUS.ViewModels;
using DAL.IRepositories;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class QLListItemRoomViewService : IQLListItemRoomViewService
    {
      
        private ILoaiPhongRepository _iloaiPhongRepos;
        private IPhongRepository _iphongRepos;
        private IChiTietPhieuThueRepository _iCTPTRepos;
        private IPhieuThueRepository _iPTRepos;
        private IKhachHangRepository _ikhRepos;

        public QLListItemRoomViewService()
        {
            _iloaiPhongRepos = new LoaiPhongRepository();
            _iphongRepos = new PhongRepository();
            _iCTPTRepos = new ChiTietPhieuThueRepository();
            _iPTRepos = new PhieuThueRepository();
            _ikhRepos = new KhachHangRepository();
        }
        public  List<ListItemRoomView> GetAll()
        {
            List<ListItemRoomView> lstPhongCoKH = new List<ListItemRoomView>();
            lstPhongCoKH = (from a in _iCTPTRepos.GetAll()
                   join b in _iPTRepos.GetAll() on a.IdPhieuThue equals b.ID
                   select new ListItemRoomView()
                   {
                       IdRoom = a.IdPhong,
                       IdKH = b.IdKH,

                   }
                   ).ToList();
            List<ListItemRoomView> lstPhongTrong = new List<ListItemRoomView>();
            lstPhongTrong = (//from a in _iphongRepos.GetAll()
                             from b in _iCTPTRepos.GetAll() 
                             join c in _iPTRepos.GetAll() on b.IdPhieuThue equals c.ID
                             where c.IdKH == null
                             select new ListItemRoomView()
                             {
                                 IdRoom = b.IdPhong
                             }
                             ).ToList();

            return lstPhongTrong;
        }
    }
}
