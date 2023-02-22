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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        //private Form FormConGanDay;
        private void MoFormCon(Form FormCon)
        {
            //if (FormConGanDay != null)
            //{
            //    FormConGanDay.Close();
            //}
            //FormConGanDay = FormCon;
            FormCon.TopLevel = false;
            FormCon.FormBorderStyle = FormBorderStyle.None;
            FormCon.Dock = DockStyle.Fill;
            pnFormCon.Controls.Add(FormCon);
            pnFormCon.Tag = FormCon;
            FormCon.BringToFront();
            FormCon.Show();
        }

        private void tsKhachHang_Click(object sender, EventArgs e)
        {
            MoFormCon(new ThongTinKhachHang());
        }

        private void tsDatPhong_Click(object sender, EventArgs e)
        {
            MoFormCon(new DatPhong());
        }

        private void btHoTro_Click(object sender, EventArgs e)
        {
            MoFormCon(new LienHe());
        }


        private void tsPhong_Click(object sender, EventArgs e)
        {
            MoFormCon(new ThongTinPhong());
        }

        private void tsDichVu_Click(object sender, EventArgs e)
        {
            MoFormCon(new ThongTinDichVu());
        }

        private void tsThongTin_DropDownOpened(object sender, EventArgs e)
        {
            ts2.Location = new Point(10, 217);
            ts3.Location = new Point(10, 272);
            ts4.Location = new Point(10, 327);
            ts5.Location = new Point(10, 382);
        }
        private void tsThongTin_DropDownClosed(object sender, EventArgs e)
        {
            ts2.Location = new Point(10, 126);
            ts3.Location = new Point(10, 182);
            ts4.Location = new Point(10, 237);
            ts5.Location = new Point(10, 295);
        }

        private void tsQuanTriVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new QuanTriVien());
        }

        private void tsDatPhong_Click_1(object sender, EventArgs e)
        {
            MoFormCon(new DatPhong());
        }

        private void tsDangXuat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DangNhap f = new DangNhap();
                f.Show();
                this.Hide();
            }
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Menu formMenu = new Menu();
            formMenu.Show();
            this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
