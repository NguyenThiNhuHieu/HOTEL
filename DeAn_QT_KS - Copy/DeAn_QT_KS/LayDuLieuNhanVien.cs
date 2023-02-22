using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeAn_QT_KS
{
    //Phương thức Serialize để thực thi tuần tự hóa.
    [Serializable]
    class LayDuLieuNhanVien
    {
        // Quản trị viên
        public string maAdmin { get; set; }
        public string tenAdmin { get; set; }
        public Int64 cmndAdmin { get; set; }
        public Int64 soDienThoaiAdmin { get; set; }
        public string ngayLamAdmin { get; set; }
        public string caLamAdmin { get; set; }
        
    }
}
