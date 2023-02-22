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
    public partial class ThongTinDichVu : Form
    {
        public ThongTinDichVu()
        {
            InitializeComponent(); // Hiển thị màn hình
        }
        List<LayDuLieuDichVu> listDichVu = new List<LayDuLieuDichVu>();
        private void dgvThongTinDichVu_Load(object sender, EventArgs e)
        {
            // Thêm từng dòng
            listDichVu.Add(new LayDuLieuDichVu() { tenDichVu = "Buffet sáng", donGia = 300000, donVi = "Bữa" });
            listDichVu.Add(new LayDuLieuDichVu() { tenDichVu = "Buffet tối", donGia = 300000, donVi = "Bữa" });
            listDichVu.Add(new LayDuLieuDichVu() { tenDichVu = "Nước suối", donGia = 15000, donVi = "Chai" });
            listDichVu.Add(new LayDuLieuDichVu() { tenDichVu = "Nước ngọt", donGia = 20000, donVi = "Chai" });
            listDichVu.Add(new LayDuLieuDichVu() { tenDichVu = "Bia", donGia = 30000, donVi = "chai" });
            listDichVu.Add(new LayDuLieuDichVu() { tenDichVu = "Giặt ủi", donGia = 40000, donVi = "Kg" });
            listDichVu.Add(new LayDuLieuDichVu() { tenDichVu = "Spa", donGia = 700000, donVi = "Lần" });
            listDichVu.Add(new LayDuLieuDichVu() { tenDichVu = "Phòng gym", donGia = 250000, donVi = "Buổi" });
            listDichVu.Add(new LayDuLieuDichVu() { tenDichVu = "Golf", donGia = 600000, donVi = "Buổi" });
            listDichVu.Add(new LayDuLieuDichVu() { tenDichVu = "Bắn cung", donGia = 300000, donVi = "Buổi" });
            dgvThongTinDichVu.DataSource = listDichVu; // Câu lệnh lưu dữ liệu của bảng datagridview
            lbDem.Text = "Số dịch vụ có trong danh sách là: " + listDichVu.Count; //listDichVu.Count đến số dòng trong bảng datagridview
        }

        private void dgvThongTinDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvThongTinDichVu.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                cbbTenDichVu.Text = row.Cells[0].Value.ToString();
                txtDonGia.Text = row.Cells[1].Value.ToString();
                txtDonVi.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát Form không?", "Xác nhận thoát Form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void cbbTenDichVu_TextChanged(object sender, EventArgs e)
        {
            // Duyệt từng dòng của listDichVu
            foreach (var item in listDichVu)
            {
                if (item.tenDichVu.Equals(cbbTenDichVu.Text))
                {
                    {
                        txtDonGia.Text = item.donGia.ToString();
                        txtDonVi.Text = item.donVi.ToString();
                    }
                }
            }
        }

        private void btLuuThongTinDichVu_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;  // ghi ra file text 
            SaveFileDialog saveFileDialog = new SaveFileDialog();   //tạo mới một file để lưu
            string fileDaCo = ""; //lưu trên file mặc định 
            MessageBox.Show("Bạn hãy lưu vào file có đuôi .txt, nếu không có thì tạo mới File Text Document để lưu!");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileDaCo = saveFileDialog.FileName;
                MessageBox.Show("Lưu file thành công");
            }
            else //Bấm huỷ or cancel
            {
                fileDaCo = @"D:\ThongTinDichVu.txt"; // nếu mà không có thì sẽ tạo ra một file txt mới này để lưu
                MessageBox.Show("Đã tự động lưu File ThongTinDichVu.txt vào ổ đĩa D ! ");
            }
            // lưu
            if (File.Exists(fileDaCo))
            {
                streamWriter = new StreamWriter(fileDaCo); // fileName là đường dẫn
                                                           //cột 1 tên  50, cột 2 CMnd  12, cột 3 số điện thoại 12
                                                           // cột 4 phòng 6 ký tự , cột 5 ngày đến 12, cột 6 ngày đi 12 

                streamWriter.WriteLine(String.Format("{0,-30 }", dgvThongTinDichVu.Columns[0].HeaderText)
                                     + String.Format("{0,-30 }", dgvThongTinDichVu.Columns[1].HeaderText)
                                     + String.Format("{0,-30 }", dgvThongTinDichVu.Columns[2].HeaderText));

                for (int i = 0; i < dgvThongTinDichVu.Rows.Count; i++) //Duyệt từng dòng
                {
                    streamWriter.WriteLine(String.Format("{0,-30 }", dgvThongTinDichVu.Rows[i].Cells[0].Value)
                                         + String.Format("{0,-30 }", dgvThongTinDichVu.Rows[i].Cells[1].Value)
                                         + String.Format("{0,-30 }", dgvThongTinDichVu.Rows[i].Cells[2].Value));
                }
                streamWriter.Close();
            }
            else
            {
                streamWriter = File.AppendText(fileDaCo);
                for (int i = 0; i < dgvThongTinDichVu.Rows.Count; i++)
                {
                    streamWriter.WriteLine(String.Format("{0,-30 }", dgvThongTinDichVu.Rows[i].Cells[0].Value)
                                         + String.Format("{0,-30 }", dgvThongTinDichVu.Rows[i].Cells[1].Value)
                                         + String.Format("{0,-30 }", dgvThongTinDichVu.Rows[i].Cells[2].Value));

                }
                streamWriter.Close(); // Đóng file lại để lưu DL
            }
        }
    }
}
