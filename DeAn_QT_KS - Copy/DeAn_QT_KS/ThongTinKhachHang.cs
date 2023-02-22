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
    public partial class ThongTinKhachHang : Form
    {
        List<LayDuLieuKhachHang> list = new List<LayDuLieuKhachHang>();
        DocFileLuuFileKhachHang doc = new DocFileLuuFileKhachHang();
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            list = doc.readFF();
            dgvThongTinKH.DataSource = list;
            lbDem.Text = "Số khách hàng có trong danh sách là: " + list.Count;
            cbPhong.Focus();
        }
        private void cbPhong_TextChanged(object sender, EventArgs e)
        {
            bool index = false;
            lbThongBao.Text = "";
            foreach (var item in list)
            {
                if (item.phong.Equals(cbPhong.Text))
                {
                    txtTenKhachHang.Text = item.tenKhachHang;
                    txtCMND.Text = item.cMND.ToString();
                    txtSoDienThoai.Text = item.soDienThoai.ToString();
                    dtpNgayDen.Text = item.ngayDen.ToString();
                    dtpNgayDi.Text = item.ngayDi.ToString();
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                    index = true;
                }
            }
            if (!index)
            {
                txtTenKhachHang.Clear();
                txtCMND.Clear();
                txtSoDienThoai.Clear();
                dtpNgayDen.Text = DateTime.Now.ToShortDateString();
                dtpNgayDi.Text = DateTime.Now.ToShortDateString();
                lbThongBao.Text = "Chưa có khách hàng nào đặt phòng này!";
                btSua.Enabled = false;
                btXoa.Enabled = false;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát Form không?", "Xác nhận thoát Form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                lbThongBao.Text = "";
                if (txtTenKhachHang.Text == "" || txtCMND.Text == "" || txtSoDienThoai.Text == "" || cbPhong.Text == "")
                {
                    lbThongBao.Text = "Bạn phải nhập đủ thông tin!";
                }
                else
                {
                    bool index1 = false;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].phong.Equals(cbPhong.Text))
                        {
                            if (txtTenKhachHang.Text == list[i].tenKhachHang && txtCMND.Text == list[i].cMND.ToString() && txtSoDienThoai.Text == list[i].soDienThoai.ToString())
                            {
                                MessageBox.Show("Bạn chưa thay đổi thông tin nào!");
                                index1 = true;
                                break;
                            }
                            else if (MessageBox.Show("Bạn có muốn sửa hay không?", "Xác nhận sửa",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                list[i].tenKhachHang = txtTenKhachHang.Text;
                                list[i].cMND = Int64.Parse(txtCMND.Text);
                                list[i].soDienThoai = Int64.Parse(txtSoDienThoai.Text);
                                doc.writeTF(list);
                                index1 = true;
                                list = doc.readFF();
                                dgvThongTinKH.DataSource = list;
                                MessageBox.Show("Sửa thành công!");
                                break;
                            }
                        }
                    }
                    if (!index1)
                    {
                        MessageBox.Show("Sửa thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbPhong.Text == "")
            {
                lbThongBao.Text = "Bạn phải điền phòng của khách hàng cần xoá!";
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].phong.Equals(cbPhong.Text))
                    {

                        if (MessageBox.Show("Bạn có muốn xoá thông tin của khách hàng này hay không?", "Xác nhận xoá",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            list.Remove(list[i]);
                            doc.writeTF(list);
                            list = doc.readFF();
                            dgvThongTinKH.DataSource = list;
                            cbPhong.Text = null;
                            txtTenKhachHang.Text = null;
                            txtCMND.Clear();
                            txtSoDienThoai.Clear();
                            dtpNgayDen.Text = DateTime.Now.ToShortDateString();
                            dtpNgayDi.Text = DateTime.Now.ToShortDateString();
                            MessageBox.Show("Xoá thành công!");
                        }
                        else
                            MessageBox.Show("Xoá thất bại!");
                    }
                }
            }
        }

        private void dgvThongTinKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvThongTinKH.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtTenKhachHang.Text = row.Cells[0].Value.ToString();
                txtCMND.Text = row.Cells[1].Value.ToString();
                txtSoDienThoai.Text = row.Cells[2].Value.ToString();
                cbPhong.Text = row.Cells[3].Value.ToString();
                dtpNgayDen.Text = row.Cells[4].Value.ToString();
                dtpNgayDi.Text = row.Cells[5].Value.ToString();
            }
        }

        private void txtTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || Char.IsWhiteSpace(e.KeyChar)))
            {
                lbThongBao.Text = "Chỉ nhập được ký tự chữ!";
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                lbThongBao.Text = "Chỉ nhập được ký tự số!";
                e.Handled = true;
            }
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
        }

        private void btLuuThongTinKhachHang_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;  // ghi ra file text 
            SaveFileDialog saveFileDialog = new SaveFileDialog();   //tạo mới một file để lưu
            string fileName = ""; //lưu trên file mặc định 
            MessageBox.Show("Bạn hãy lưu vào file có đuôi .txt, nếu không có thì tạo mới File Text Document để lưu!");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
             
                fileName = saveFileDialog.FileName;
                MessageBox.Show("Lưu file thành công");
            }
            else
            {

                fileName = @"D:\ThongTinKhachHang.txt"; // nếu mà không có thì sẽ tạo ra một file txt mới này để lưu
                MessageBox.Show("Đã tự động lưu File ThongTinKhachHang.txt vào ổ đĩa D !");
            }
           
            // lưu
            if (File.Exists(fileName))
            {
                streamWriter = new StreamWriter(fileName); // fileName là đường dẫn
                                                           //cột 1 tên  50, cột 2 CMnd  12, cột 3 số điện thoại 12
                                                           // cột 4 phòng 6 ký tự , cột 5 ngày đến 12, cột 6 ngày đi 12 

                streamWriter.WriteLine(String.Format("{0,-30 }", dgvThongTinKH.Columns[0].HeaderText)
                                     + String.Format("{0,-20 }", dgvThongTinKH.Columns[1].HeaderText)
                                     + String.Format("{0,-20 }", dgvThongTinKH.Columns[2].HeaderText)
                                     + String.Format("{0,-20 }", dgvThongTinKH.Columns[3].HeaderText)
                                     + String.Format("{0,-20 }", dgvThongTinKH.Columns[4].HeaderText)
                                     + String.Format("{0,-20 }", dgvThongTinKH.Columns[5].HeaderText));
                for (int i = 0; i < dgvThongTinKH.Rows.Count; i++)
                {
                    streamWriter.WriteLine(String.Format("{0,-30 }", dgvThongTinKH.Rows[i].Cells[0].Value)
                                         + String.Format("{0,-20 }", dgvThongTinKH.Rows[i].Cells[1].Value)
                                         + String.Format("{0,-20 }", dgvThongTinKH.Rows[i].Cells[2].Value)
                                         + String.Format("{0,-20 }", dgvThongTinKH.Rows[i].Cells[3].Value)
                                         + String.Format("{0,-20 }", dgvThongTinKH.Rows[i].Cells[4].Value)
                                         + String.Format("{0,-20 }", dgvThongTinKH.Rows[i].Cells[5].Value));
                }
                streamWriter.Close();
            }
            else
            {
                streamWriter = File.AppendText(fileName);
                for (int i = 0; i < dgvThongTinKH.Rows.Count; i++)
                {
                    streamWriter.WriteLine(String.Format("{0,-30 }", dgvThongTinKH.Rows[i].Cells[0].Value)
                                         + String.Format("{0,-20 }", dgvThongTinKH.Rows[i].Cells[1].Value)
                                         + String.Format("{0,-20 }", dgvThongTinKH.Rows[i].Cells[2].Value)
                                         + String.Format("{0,-20 }", dgvThongTinKH.Rows[i].Cells[3].Value)
                                         + String.Format("{0,-20 }", dgvThongTinKH.Rows[i].Cells[4].Value)
                                         + String.Format("{0,-20 }", dgvThongTinKH.Rows[i].Cells[5].Value));
                }
                streamWriter.Close();
            }
        }
    }
}
