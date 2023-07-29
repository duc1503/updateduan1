using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS.Ultilities
{
    public class Validations
    {
        public bool CheckCCCD(string obj)
        {
            return Regex.IsMatch(obj, @"^(0)+[0-9]{11}$");// Trả về true thì đúng(Chưa test)
        }
        public bool CheckSDT(string obj)
        {
            return Regex.IsMatch(obj, @"^((\+|)84)|0(3|5|7|8|9)+([0-9]{8})");// Số điện thoại có đầu +84 or 03 05 07 08 09 + 8 số phía sau tổng là 10 trả về true thì đúng(Test Sơ qua đã đúng)
        }
        public bool CheckTien(string obj) // obj giá trị lấy từ text box
        {
            try
            {
                Convert.ToDecimal(obj); // Kiểm tra xem có convert đc hay ko nếu convert đc thì string nhận vào đúng kiểu dữ liệu vào db
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool CheckRong(string obj)
        {
            // nếu giá trị truyền vào rỗng thì false
            if (obj.Trim() == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
