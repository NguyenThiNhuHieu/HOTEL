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
    public partial class DatPhong : Form
    {
        public DatPhong()
        {
            InitializeComponent();
        }

        List<LayDuLieuKhachHang> list = new List<LayDuLieuKhachHang>();
        DocFileLuuFileKhachHang docFileLuuFile = new DocFileLuuFileKhachHang();
        
        int[] giaDichVu = { 300000, 300000, 15000, 25000, 35000, 40000, 700000, 250000, 600000, 300000 };

        private void DatPhong_Load(object sender, EventArgs e)
        {
            lbThongBao.Text = "Vui lòng chọn phòng!";
            txtTenKhachHang.Enabled = false;
            txtCMND.Enabled = false;
            txtSoDienThoai.Enabled = false;
            dtpNgayDen.Enabled = false;
            dtpNgayDi.Enabled = false;
            //hứng DL sau khi lấy ra từ file
            list = docFileLuuFile.readFF();
        }

        private void cbPhong_TextChanged(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
            bool index = false;
            foreach (var item in list)
            {
                if (item.phong.Equals(cbPhong.Text))
                {
                    txtTenKhachHang.Text = item.tenKhachHang;
                    txtCMND.Text = item.cMND.ToString();
                    txtSoDienThoai.Text = item.soDienThoai.ToString();
                    dtpNgayDen.Text = item.ngayDen.ToString();
                    dtpNgayDi.Text = item.ngayDi.ToString();
                    txtTenKhachHang.Enabled = false;
                    txtCMND.Enabled = false;
                    txtSoDienThoai.Enabled = false;
                    dtpNgayDen.Enabled = false;
                    dtpNgayDi.Enabled = false;
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
                txtTenKhachHang.Enabled = true;
                txtCMND.Enabled = true;
                txtSoDienThoai.Enabled = true;
                dtpNgayDen.Enabled = true;
                dtpNgayDi.Enabled = true;
                lbThongBao.Text = "Hãy điền thông tin phòng!";
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát Form hay không?", "Xác nhận thoát form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        private void btDatPhong_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "" || txtCMND.Text == "" || txtSoDienThoai.Text == "" || cbPhong.Text == "")
            {
                lbThongBao.Text = "Bạn phải nhập đủ thông tin!";
                MessageBox.Show("Đặt phòng thất bại!");
            }
            else
            {
                TimeSpan thoiGianDi;
                thoiGianDi = dtpNgayDi.Value - dtpNgayDen.Value;
                if (thoiGianDi.TotalDays < 0) 
                {
                    MessageBox.Show("Đặt phòng thất bại!");
                    lbThongBao.Text = "Thời gian đặt ngày đi chưa đúng!";
                }
                else
                {
                    if (dtpNgayDen.Value < DateTime.Today)
                    {
                        MessageBox.Show("Đặt phòng thất bại!");
                        lbThongBao.Text = "Thời gian đặt ngày đến chưa đúng!";
                        dtpNgayDen.Value = DateTime.Today;
                    }

                    else
                    {
                        lbThongBao.Text = "";
                        double soNgayO = 0;
                        if (dtpNgayDen.Text == dtpNgayDi.Text)// Là đi và đến trong ngày
                        {
                            soNgayO = 1;
                        }

                        else
                        {
                            TimeSpan giaTriO = dtpNgayDi.Value - dtpNgayDen.Value;
                            soNgayO = Math.Round(giaTriO.TotalDays, 0);
                        }
                        lbTenKhachHang.Text = txtTenKhachHang.Text;
                        lbThoiGianXuatHoaDon1.Text = DateTime.Now.ToLongDateString();
                        lbThoiGianXuatHoaDon2.Text = DateTime.Now.ToLongTimeString();
                        // Tính tiền phòng
                        lbSoNgayO.Text = soNgayO.ToString();
                        int giaPhong = 0;

                        if ((cbPhong.Text == "V01") || (cbPhong.Text == "V02") || (cbPhong.Text == "V03"))
                            giaPhong = 2500000;
                        if ((cbPhong.Text == "D01") || (cbPhong.Text == "D02") || (cbPhong.Text == "D03"))
                            giaPhong = 1500000;
                        if ((cbPhong.Text == "S01") || (cbPhong.Text == "S02") || (cbPhong.Text == "S03"))
                            giaPhong = 1000000;
                        lbGiaPhong.Text = String.Format("{0:0,0}", giaPhong);
                        lbTongTienPhong.Text = String.Format("{0:0,0}", giaPhong * soNgayO); ;
                        // Tính tiền DV
                        int tongDichVu = 0;
                        tongDichVu += Convert.ToInt32(numBuffetSang.Value) * giaDichVu[0];
                        tongDichVu += Convert.ToInt32(numBuffetToi.Value) * giaDichVu[1];
                        tongDichVu += Convert.ToInt32(numNuocSuoi.Value) * giaDichVu[2];
                        tongDichVu += Convert.ToInt32(numNuocNgot.Value) * giaDichVu[3];
                        tongDichVu += Convert.ToInt32(numBia.Value) * giaDichVu[4];
                        tongDichVu += Convert.ToInt32(numGiatUi.Value) * giaDichVu[5];
                        tongDichVu += Convert.ToInt32(numSpa.Value) * giaDichVu[6];
                        tongDichVu += Convert.ToInt32(numPhongGym.Value) * giaDichVu[7];
                        tongDichVu += Convert.ToInt32(numGolf.Value) * giaDichVu[8];
                        tongDichVu += Convert.ToInt32(numBanCung.Value) * giaDichVu[9];
                        lbTongDichVu.Text = String.Format("{0:0,0}", tongDichVu);
                        pannelHoaDon.Visible = true;
                        btXacNhanDatPhong.Visible = true;
                        lbTongTienThanhToan.Text = String.Format("{0:0,0}", giaPhong * soNgayO + tongDichVu);
                        MessageBox.Show("Vui lòng xác nhận đặt phòng ở bảng hoá đơn bên dưới!");
                        cbPhong.Enabled = false;
                        txtTenKhachHang.Enabled = false;
                        txtCMND.Enabled = false;
                        txtSoDienThoai.Enabled = false;
                        dtpNgayDen.Enabled = false;
                        dtpNgayDi.Enabled = false;
                        numBuffetSang.Enabled = false;
                        numBuffetToi.Enabled = false;
                        numNuocNgot.Enabled = false;
                        numNuocSuoi.Enabled = false;
                        numBia.Enabled = false;
                        numGiatUi.Enabled = false;
                        numSpa.Enabled = false;
                        numPhongGym.Enabled = false;
                        numGolf.Enabled = false;
                        numBanCung.Enabled = false;
                    }
                } 
            }
        }

        private void numBuffetSang_ValueChanged(object sender, EventArgs e)
        {
            int tong = 0;
            tong = Convert.ToInt32(numBuffetSang.Value) * giaDichVu[0];
            lbBuffetSang.Text = String.Format("{0:0,0}", tong);
        }

        private void numBuffetToi_ValueChanged(object sender, EventArgs e)
        {
            int tong = 0;
            tong = Convert.ToInt32(numBuffetToi.Value) * giaDichVu[1];
            lbBuffetToi.Text = String.Format("{0:0,0}", tong);
        }

        private void numNuocSuoi_ValueChanged(object sender, EventArgs e)
        {
            int tong = 0;
            tong = Convert.ToInt32(numNuocSuoi.Value) * giaDichVu[2];
            lbNuocSuoi.Text = String.Format("{0:0,0}", tong);
        }

        private void numNuocNgot_ValueChanged(object sender, EventArgs e)
        {
            int tong = 0;
            tong = Convert.ToInt32(numNuocNgot.Value) * giaDichVu[3];
            lbNuocNgot.Text = String.Format("{0:0,0}", tong);
        }

        private void numBia_ValueChanged(object sender, EventArgs e)
        {
            int tong = 0;
            tong = Convert.ToInt32(numBia.Value) * giaDichVu[4];
            lbBia.Text = String.Format("{0:0,0}", tong );
        }

        private void numGiatUi_ValueChanged(object sender, EventArgs e)
        {
            int tong = 0;
            tong = Convert.ToInt32(numGiatUi.Value) * giaDichVu[5];
            lbGiatUi.Text = String.Format("{0:0,0}", tong);
        }

        private void numSpa_ValueChanged(object sender, EventArgs e)
        {
            int tong = 0;
            tong = Convert.ToInt32(numSpa.Value) * giaDichVu[6];
            lbSpa.Text = String.Format("{0:0,0}", tong);
        }

        private void numPhongGym_ValueChanged(object sender, EventArgs e)
        {
            int tong = 0;
            tong = Convert.ToInt32(numPhongGym.Value) * giaDichVu[7];
            lbPhongGym.Text = String.Format("{0:0,0}", tong);
        }

        private void numGolf_ValueChanged(object sender, EventArgs e)
        {
            int tong = 0;
            tong = Convert.ToInt32(numGolf.Value) * giaDichVu[8];
            lbGolf.Text = String.Format("{0:0,0}", tong);
        }

        private void numBanCung_ValueChanged(object sender, EventArgs e)
        {
            int tong = 0;
            tong = Convert.ToInt32(numBanCung.Value) * giaDichVu[9];
            lbBanCung.Text = String.Format("{0:0,0}", tong);
        }

        private void btXacNhanDatPhong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đặt phòng không?", "Xác nhận đặt phòng",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LayDuLieuKhachHang thongTin = new LayDuLieuKhachHang();
                thongTin.tenKhachHang = txtTenKhachHang.Text;
                thongTin.cMND = Int64.Parse(txtCMND.Text);
                thongTin.soDienThoai = Int64.Parse(txtSoDienThoai.Text);
                thongTin.phong = cbPhong.Text;
                thongTin.ngayDen = dtpNgayDen.Text;
                thongTin.ngayDi = dtpNgayDi.Text;
                docFileLuuFile.writeTF(list);
                list.Add(thongTin);
                docFileLuuFile.writeTF(list);
                MessageBox.Show("Đặt phòng thành công!");
                cbPhong.Text = txtTenKhachHang.Text = txtCMND.Text = txtSoDienThoai.Text = cbPhong.Text = null;
                cbPhong.Enabled = true;
                cbPhong.Focus();
                numBuffetSang.Value = numBuffetToi.Value = numNuocNgot.Value = numNuocSuoi.Value = numBia.Value = numGiatUi.Value = numSpa.Value
                    = numPhongGym.Value = numGolf.Value = numGolf.Value = numBanCung.Value = 0;
                numBuffetSang.Enabled = numBuffetToi.Enabled = numNuocNgot.Enabled = numNuocSuoi.Enabled = numBia.Enabled = numGiatUi.Enabled = numSpa.Enabled
                   = numPhongGym.Enabled = numGolf.Enabled = numGolf.Enabled = numBanCung.Enabled = true;
                pannelHoaDon.Visible = false;
                btXacNhanDatPhong.Visible = false;
            }
            else
                MessageBox.Show("Đã huỷ xác nhận đặt phòng!");
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

        private void btSua_Click(object sender, EventArgs e)
        {
            cbPhong.Enabled = true;
            txtTenKhachHang.Enabled = true;
            txtCMND.Enabled = true;
            txtSoDienThoai.Enabled = true;
            dtpNgayDen.Enabled = true;
            dtpNgayDi.Enabled = true;
            numBuffetSang.Enabled = true;
            numBuffetToi.Enabled = true;
            numNuocNgot.Enabled = true;
            numNuocSuoi.Enabled = true;
            numBia.Enabled = true;
            numGiatUi.Enabled = true;
            numSpa.Enabled = true;
            numPhongGym.Enabled = true;
            numGolf.Enabled = true;
            numBanCung.Enabled = true;
            pannelHoaDon.Visible = false;
            btXacNhanDatPhong.Visible = false;
        }
    }
}