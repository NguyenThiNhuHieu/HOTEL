using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAn_QT_KS
{
    public partial class QuanTriVien : Form
    {
        public QuanTriVien()
        {
            InitializeComponent();
        }

        List<LayDuLieuNhanVien> list = new List<LayDuLieuNhanVien>();
        DocFileNhanVien docFileLuuFile = new DocFileNhanVien();
        string path = Application.StartupPath + @"\Hinh\";
        private void cbbMaAdmin_TextChanged(object sender, EventArgs e)
        {
            bool index = false;
            foreach (var item in list)
            {
                if (item.maAdmin.Equals(cbbMaAdmin.Text))
                {
                    txtTenAdmin.Text = item.tenAdmin;
                    txtCMNDAdmin.Text = item.cmndAdmin.ToString();
                    txtSoDienThoaiAdmin.Text = item.soDienThoaiAdmin.ToString();
                    dtpNgayLamAdmin.Text = item.ngayLamAdmin.ToString();
                    cbbCaLamAdmin.Text = item.caLamAdmin.ToString();
                    if (cbbMaAdmin.Text == "AD1")
                    {
                        picHinhAdmin.Image = Image.FromFile(path + "hinhAd1.jpg");
                    }
                    else if (cbbMaAdmin.Text == "AD2")
                    {
                        picHinhAdmin.Image = Image.FromFile(path + "hinhAd2.jpg");
                    }
                    else if (cbbMaAdmin.Text == "AD3")
                    {
                        picHinhAdmin.Image = Image.FromFile(path + "hinhAd3.jpg");
                    }
                    else if (cbbMaAdmin.Text == "AD4")
                    {
                        picHinhAdmin.Image = Image.FromFile(path + "hinhAd4.jpg");
                    }
                    else if (cbbMaAdmin.Text == "AD5")
                    {
                        picHinhAdmin.Image = Image.FromFile(path + "hinhAd5.jpg");
                    }
                    btThem.Enabled = false;
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                    lbThongBao.Text = "";
                    index = true;

                }
            }
            if (!index)
            {
                txtTenAdmin.Clear();
                txtCMNDAdmin.Clear();
                txtSoDienThoaiAdmin.Clear();
                dtpNgayLamAdmin.Text = DateTime.Now.ToShortDateString();
                cbbCaLamAdmin.Text = null;
                picHinhAdmin.Image = null;
                btThem.Enabled = true;
                btSua.Enabled = false;
                btXoa.Enabled = false;
                lbThongBao.Text = "Mã nhân viên chưa có thông tin!";
            }
        }

        private void QuanTriVien_Load(object sender, EventArgs e)
        {
            list = docFileLuuFile.readFF();
            dgvAdmin.DataSource = list;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbbMaAdmin.Text == "" || txtTenAdmin.Text == "" || txtCMNDAdmin.Text == ""
                || txtSoDienThoaiAdmin.Text == "" || cbbCaLamAdmin.Text == "")
            {
                lbThongBao.Text = "Bạn phải điền đủ thông tin!";
                MessageBox.Show("Thêm thất bại!");
            }
            else
            {
                if (dtpNgayLamAdmin.Value < DateTime.Today)
                {
                    lbThongBao.Text = "Thời gian làm bị sai!";
                }
                else
                {
                    bool index = false;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].maAdmin.Equals(cbbMaAdmin.Text))
                        {
                            lbThongBao.Text = "Mã nhân viên này đã có thông tin của nhân viên khác!";
                            MessageBox.Show("Thêm thất bại");
                            index = true;
                        }
                    }
                    if (!index)
                    {
                        LayDuLieuNhanVien thongTin = new LayDuLieuNhanVien();
                        thongTin.tenAdmin = txtTenAdmin.Text;
                        thongTin.cmndAdmin = Int64.Parse(txtCMNDAdmin.Text);
                        thongTin.soDienThoaiAdmin = Int64.Parse(txtSoDienThoaiAdmin.Text);
                        thongTin.maAdmin = cbbMaAdmin.Text;
                        thongTin.ngayLamAdmin = dtpNgayLamAdmin.Text;
                        thongTin.caLamAdmin = cbbCaLamAdmin.Text;
                        list.Add(thongTin);
                        docFileLuuFile.writeTF(list);
                        txtTenAdmin.Text = txtCMNDAdmin.Text = txtSoDienThoaiAdmin.Text = cbbMaAdmin.Text = null;
                        list = docFileLuuFile.readFF();
                        dgvAdmin.DataSource = list;
                        MessageBox.Show("Thêm thành công!");
                    }
                }
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
            if (dtpNgayLamAdmin.Value < DateTime.Today)
            {
                lbThongBao.Text = "Thời gian làm bị sai!";
            }
            else
            {
                bool index = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].maAdmin.Equals(cbbMaAdmin.Text))
                    {
                        if (txtTenAdmin.Text == list[i].tenAdmin.ToString() && txtSoDienThoaiAdmin.Text == list[i].soDienThoaiAdmin.ToString()
                            && txtCMNDAdmin.Text == list[i].cmndAdmin.ToString() && dtpNgayLamAdmin.Text == list[i].ngayLamAdmin && cbbCaLamAdmin.Text == list[i].caLamAdmin)
                        {
                            MessageBox.Show("Bạn chưa thay đổi thông tin nào!");
                            index = true;
                            break;
                        }
                        if (MessageBox.Show("Bạn có muốn sửa hay không?", "Xác nhận sửa",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            list[i].tenAdmin = txtTenAdmin.Text;
                            list[i].cmndAdmin = Int64.Parse(txtCMNDAdmin.Text);
                            list[i].soDienThoaiAdmin = Int64.Parse(txtSoDienThoaiAdmin.Text);
                            list[i].ngayLamAdmin = dtpNgayLamAdmin.Text;
                            list[i].caLamAdmin = cbbCaLamAdmin.Text;
                            docFileLuuFile.writeTF(list);
                            index = true;
                            list = docFileLuuFile.readFF();
                            dgvAdmin.DataSource = list;
                            MessageBox.Show("Sửa thành công!");
                            cbbMaAdmin.Text = null;
                            txtTenAdmin.Clear();
                            txtCMNDAdmin.Clear();
                            txtSoDienThoaiAdmin.Clear();
                            dtpNgayLamAdmin.Text = DateTime.Now.ToShortDateString();
                        }
                    }
                }
                if (!index)
                {
                    MessageBox.Show("Sửa thất bại!");
                    lbThongBao.Text = "";
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbbMaAdmin.Text == "" || txtTenAdmin.Text == "" || txtCMNDAdmin.Text == ""
                || txtSoDienThoaiAdmin.Text == "" || cbbCaLamAdmin.Text == "")
            {
                lbThongBao.Text = "Bạn phải điền mã nhân viên!";
                MessageBox.Show("Xoá thất bại!");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].maAdmin.Equals(cbbMaAdmin.Text))
                    {

                        if (MessageBox.Show("Bạn có muốn xoá hay không?", "Xác nhận xoá",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            list.Remove(list[i]);
                            docFileLuuFile.writeTF(list);
                            list = docFileLuuFile.readFF();
                            dgvAdmin.DataSource = list;
                            cbbMaAdmin.Text = null;
                            txtTenAdmin.Clear();
                            txtCMNDAdmin.Clear();
                            txtSoDienThoaiAdmin.Clear();
                            dtpNgayLamAdmin.Text = DateTime.Now.ToShortDateString();
                            cbbCaLamAdmin.Text = null;
                            MessageBox.Show("Xoá thành công!");
                        }
                    }
                }
            }
        }

        private void txtTenAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || Char.IsWhiteSpace(e.KeyChar)))
            {
                lbThongBao.Text = "Chỉ nhập được ký tự chữ!";
                e.Handled = true; //Khoá event KeyPress (ko nhận j từ bàn phím)
            }
        }

        private void txtCMNDAdmin_TextChanged(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
        }

        private void txtCMNDAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //ko phải kt số & ko phải kt điều khiển
            {
                lbThongBao.Text = "Chỉ nhập được ký tự số!";
                e.Handled = true;
            }
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvAdmin.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                cbbMaAdmin.Text = row.Cells[0].Value.ToString();
                txtTenAdmin.Text = row.Cells[1].Value.ToString();
                txtCMNDAdmin.Text = row.Cells[2].Value.ToString();
                txtSoDienThoaiAdmin.Text = row.Cells[3].Value.ToString();
                dtpNgayLamAdmin.Text = row.Cells[4].Value.ToString();
                cbbCaLamAdmin.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
