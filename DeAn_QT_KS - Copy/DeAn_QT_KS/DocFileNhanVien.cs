using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeAn_QT_KS
{
    class DocFileNhanVien
    {
        List<LayDuLieuNhanVien> list = new List<LayDuLieuNhanVien>();
        string path = "ThongTinNV.bin";

        public List<LayDuLieuNhanVien> GetList()
        {
            return list;
        }

        //Đọc file
        public List<LayDuLieuNhanVien> readFF()
        {
            //Trước tiên phải tạo một luồng đến file.
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            // đổi tượng BinaryFormatter được sử dụng cho quá trình tuần tự hóa nhị phân
            BinaryFormatter bf = new BinaryFormatter();
            if (File.ReadAllText(path) != "") // để có đối tượng để Deserialize đọc
            {
                list = (List<LayDuLieuNhanVien>)bf.Deserialize(fs); // deserialize đọc khi có đối tượng
            }
            fs.Close();
            return list;
        }
        public void writeTF(List<LayDuLieuNhanVien> listSave)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, list);
            fs.Close();
        }
    }
}
