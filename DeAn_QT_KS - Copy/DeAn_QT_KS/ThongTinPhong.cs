using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAn_QT_KS
{
    public partial class ThongTinPhong : Form
    {
        List<LayDuLieuPhong> list = new List<LayDuLieuPhong>();
        DocFileLuuFilePhong doc = new DocFileLuuFilePhong();
        public ThongTinPhong()
        {
            InitializeComponent();
        }

        private void ThongTinPhong_Load(object sender, EventArgs e)
        {
            list.Add(new LayDuLieuPhong() { phong = "V01", loaiPhong = "VIP", giaPhong = 2500000 });
            list.Add(new LayDuLieuPhong() { phong = "V02", loaiPhong = "VIP", giaPhong = 2500000 });
            list.Add(new LayDuLieuPhong() { phong = "V03", loaiPhong = "VIP", giaPhong = 2500000 });
            list.Add(new LayDuLieuPhong() { phong = "D01", loaiPhong = "Deluxe", giaPhong = 1500000 });
            list.Add(new LayDuLieuPhong() { phong = "D02", loaiPhong = "Deluxe", giaPhong = 1500000 });
            list.Add(new LayDuLieuPhong() { phong = "D03", loaiPhong = "Deluxe", giaPhong = 1500000 });
            list.Add(new LayDuLieuPhong() { phong = "S01", loaiPhong = "Standard", giaPhong = 1000000 });
            list.Add(new LayDuLieuPhong() { phong = "S02", loaiPhong = "Standard", giaPhong = 1000000 });
            list.Add(new LayDuLieuPhong() { phong = "S03", loaiPhong = "Standard", giaPhong = 1000000 });
            dgvThongTinPhong.DataSource = list;
            lbDem.Text = "Số phòng có trong danh sách là: " + list.Count;
        }

        private void cbbMaPhong_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                if (item.phong.Equals(cbbPhong.Text))
                {
                    {
                        txtLoaiPhong.Text = item.loaiPhong;
                        txtGiaPhog.Text = item.giaPhong.ToString();
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            bool index1 = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].phong.Equals(cbbPhong.Text))
                {
                    if (MessageBox.Show("Bạn có muốn sửa hay không?", "Xác nhận sửa",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        list[i].loaiPhong = txtLoaiPhong.Text;
                        list[i].giaPhong = int.Parse(txtGiaPhog.Text);
                        doc.writeTF(list);
                        index1 = true;
                        MessageBox.Show("Sửa thành công!");
                    }
                }
            }
            if (!index1)
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {

            LayDuLieuPhong thongTin = new LayDuLieuPhong();
            thongTin.loaiPhong = txtLoaiPhong.Text;
            thongTin.giaPhong = int.Parse(txtGiaPhog.Text);

            list.Add(thongTin);
            list = doc.readFF();
            dgvThongTinPhong.DataSource = list;
            MessageBox.Show("Lưu");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát Form không?", "Xác nhận thoát Form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void dgvThongTinPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvThongTinPhong.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                cbbPhong.Text = row.Cells[0].Value.ToString();
                txtLoaiPhong.Text = row.Cells[1].Value.ToString();
                txtGiaPhog.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btLuuThongTinPhong_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;  // ghi ra file text 
            SaveFileDialog luu = new SaveFileDialog();   //tạo mới một file để lưu
            string fileLuuMacDinh = ""; //lưu trên file mặc định 
            MessageBox.Show("Bạn hãy lưu vào file có đuôi .txt, nếu không có thì tạo mới File Text Document để lưu!");
            if (luu.ShowDialog() == DialogResult.OK)
            {
                fileLuuMacDinh = luu.FileName;
                MessageBox.Show("Lưu file thành công");
            }
            else
            {
                fileLuuMacDinh = @"D:\ThongTinPhong.txt"; // nếu mà không có thì sẽ tạo ra một file txt mới này để lưu
                MessageBox.Show("Đã tự động lưu File ThongTinPhong.txt vào ổ đĩa D !");
            }
            // lưu
            if (File.Exists(fileLuuMacDinh))
            {
                streamWriter = new StreamWriter(fileLuuMacDinh); // fileName là đường dẫn
                                                                 //cột 1 tên  50, cột 2 CMnd  12, cột 3 số điện thoại 12
                                                                 // cột 4 phòng 6 ký tự , cột 5 ngày đến 12, cột 6 ngày đi 12 

                streamWriter.WriteLine(String.Format("{0,-20 }", dgvThongTinPhong.Columns[0].HeaderText)
                                     + String.Format("{0,-20 }", dgvThongTinPhong.Columns[1].HeaderText)
                                     + String.Format("{0,-20 }", dgvThongTinPhong.Columns[2].HeaderText));

                for (int i = 0; i < dgvThongTinPhong.Rows.Count; i++)
                {
                    streamWriter.WriteLine(String.Format("{0,-20 }", dgvThongTinPhong.Rows[i].Cells[0].Value)
                                         + String.Format("{0,-20 }", dgvThongTinPhong.Rows[i].Cells[1].Value)
                                         + String.Format("{0,-20 }", dgvThongTinPhong.Rows[i].Cells[2].Value));
                }
                streamWriter.Close();
            }
            else
            {
                streamWriter = File.AppendText(fileLuuMacDinh);
                for (int i = 0; i < dgvThongTinPhong.Rows.Count; i++)
                {
                    streamWriter.WriteLine(String.Format("{0,-20 }", dgvThongTinPhong.Rows[i].Cells[0].Value)
                                         + String.Format("{0,-20 }", dgvThongTinPhong.Rows[i].Cells[1].Value)
                                         + String.Format("{0,-20 }", dgvThongTinPhong.Rows[i].Cells[2].Value));
                }
                streamWriter.Close();
            }
        }
    }
}
