using BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLListItemRoomViewService
    {
        List<ListItemRoomView> GetAll();
    }
}
