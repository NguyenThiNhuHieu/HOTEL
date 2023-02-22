using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeAn_QT_KS
{
    //Phương thức Serialize để thực thi tuần tự hóa.
    [Serializable]
    class LayDuLieuKhachHang
    {
        // Khách hàng
        public string tenKhachHang { get; set; }
        public Int64 cMND { get; set; }
        public Int64 soDienThoai { get; set; }
        public string phong { get; set; }
        public string ngayDen { get; set; }
        public string ngayDi { get; set; }
        public float thanhToan{ get; set; }
        public int soNgayO { get; set; }

    }
}
