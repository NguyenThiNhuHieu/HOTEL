using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeAn_QT_KS
{
    class DocFileLuuFileKhachHang
    {
        List<LayDuLieuKhachHang> list = new List<LayDuLieuKhachHang>();
        string path = "ThongTinKH.bin";

        public List<LayDuLieuKhachHang> GetList()
        {
            return list;
        }

        //Đọc file
        public List<LayDuLieuKhachHang> readFF()
        {
            //Trước tiên phải tạo một luồng đề đọc.
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            // đổi tượng BinaryFormatter được sử dụng cho quá trình tuần tự hóa nhị phân
            BinaryFormatter bf = new BinaryFormatter();
            if (File.ReadAllText(path) != "") // để có đối tượng để Deserialize đọc
            {
                list = (List<LayDuLieuKhachHang>) bf.Deserialize(fs); // deserialize đọc khi có đối tượng, chạy tuần tự
            }
            fs.Close(); 
            return list;
        }
        // Lưu file
        public void writeTF(List<LayDuLieuKhachHang> listSave )
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, list);
            fs.Close();
        }
    }
}
