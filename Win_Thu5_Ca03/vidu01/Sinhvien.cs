using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu01
{
    public class Sinhvien
    {
        public int? LopId { get; set; }
        public Sinhvien()
        {
            Id = Guid.NewGuid();
        }

        [DisplayName("Id")]
        public Guid Id { get; set; }

        [DisplayName("Mã số")]
        public string Maso { get; set; }

        
        string _Hoten;
        [DisplayName("Họ tên")]
        public string Hoten
        {
            get { return _Hoten; }
            set 
            {
                if (Gioitinh == true)
                    throw new Exception("Nữ không thay đổi");
                _Hoten = value; 
            }
        }

        [DisplayName("Giới tính")]
        public bool Gioitinh { get; set; }

        public string GoitinhString
        {
            get
            {
                if (Gioitinh == true)
                    return "Nữ";
                return "Nam";
            }
        }
        public string HotenReadOnly
        {
            get
            {
                return Hoten;
            }
        }
    }
}
