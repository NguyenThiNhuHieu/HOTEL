namespace DeAn_QT_KS
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnFormCon = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tsPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsThongTin = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.ts1 = new System.Windows.Forms.ToolStrip();
            this.ts2 = new System.Windows.Forms.ToolStrip();
            this.tsDatPhong = new System.Windows.Forms.ToolStripButton();
            this.ts3 = new System.Windows.Forms.ToolStrip();
            this.tsQuanTriVien = new System.Windows.Forms.ToolStripButton();
            this.btHoTro = new System.Windows.Forms.ToolStripButton();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.ts4 = new System.Windows.Forms.ToolStrip();
            this.pn_Left = new System.Windows.Forms.Panel();
            this.ts5 = new System.Windows.Forms.ToolStrip();
            this.tsDangXuat = new System.Windows.Forms.ToolStripButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ts1.SuspendLayout();
            this.ts2.SuspendLayout();
            this.ts3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.ts4.SuspendLayout();
            this.pn_Left.SuspendLayout();
            this.ts5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFormCon
            // 
            this.pnFormCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFormCon.BackColor = System.Drawing.Color.Lavender;
            this.pnFormCon.BackgroundImage = global::DeAn_QT_KS.Properties.Resources.Radisson_Blu_Camranh;
            this.pnFormCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnFormCon.Location = new System.Drawing.Point(330, 1);
            this.pnFormCon.Name = "pnFormCon";
            this.pnFormCon.Size = new System.Drawing.Size(1176, 827);
            this.pnFormCon.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DeAn_QT_KS.Properties.Resources.Vertical_Line;
            this.pictureBox2.Location = new System.Drawing.Point(306, -97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 1064);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // tsPhong
            // 
            this.tsPhong.BackColor = System.Drawing.Color.Thistle;
            this.tsPhong.Name = "tsPhong";
            this.tsPhong.Size = new System.Drawing.Size(324, 36);
            this.tsPhong.Text = "Thông tin phòng";
            this.tsPhong.Click += new System.EventHandler(this.tsPhong_Click);
            // 
            // tsKhachHang
            // 
            this.tsKhachHang.BackColor = System.Drawing.Color.Thistle;
            this.tsKhachHang.Name = "tsKhachHang";
            this.tsKhachHang.Size = new System.Drawing.Size(324, 36);
            this.tsKhachHang.Text = "Thông tin khách hàng";
            this.tsKhachHang.Click += new System.EventHandler(this.tsKhachHang_Click);
            // 
            // tsThongTin
            // 
            this.tsThongTin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tsThongTin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsKhachHang,
            this.tsPhong,
            this.tsDichVu});
            this.tsThongTin.Image = global::DeAn_QT_KS.Properties.Resources.Untitled_design__7_;
            this.tsThongTin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThongTin.Name = "tsThongTin";
            this.tsThongTin.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsThongTin.Size = new System.Drawing.Size(284, 60);
            this.tsThongTin.Text = "Thông tin                       ";
            this.tsThongTin.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsThongTin.DropDownClosed += new System.EventHandler(this.tsThongTin_DropDownClosed);
            this.tsThongTin.DropDownOpened += new System.EventHandler(this.tsThongTin_DropDownOpened);
            // 
            // tsDichVu
            // 
            this.tsDichVu.BackColor = System.Drawing.Color.Thistle;
            this.tsDichVu.Name = "tsDichVu";
            this.tsDichVu.Size = new System.Drawing.Size(324, 36);
            this.tsDichVu.Text = "Thông tin dịch vụ";
            this.tsDichVu.Click += new System.EventHandler(this.tsDichVu_Click);
            // 
            // ts1
            // 
            this.ts1.AutoSize = false;
            this.ts1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ts1.Dock = System.Windows.Forms.DockStyle.None;
            this.ts1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ts1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThongTin});
            this.ts1.Location = new System.Drawing.Point(11, 95);
            this.ts1.Name = "ts1";
            this.ts1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ts1.Size = new System.Drawing.Size(292, 63);
            this.ts1.TabIndex = 9;
            this.ts1.Text = "toolStrip1";
            // 
            // ts2
            // 
            this.ts2.AutoSize = false;
            this.ts2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ts2.Dock = System.Windows.Forms.DockStyle.None;
            this.ts2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ts2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDatPhong});
            this.ts2.Location = new System.Drawing.Point(11, 168);
            this.ts2.Name = "ts2";
            this.ts2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ts2.Size = new System.Drawing.Size(292, 63);
            this.ts2.TabIndex = 10;
            this.ts2.Text = "toolStrip2";
            // 
            // tsDatPhong
            // 
            this.tsDatPhong.Image = global::DeAn_QT_KS.Properties.Resources.Untitled_design__1_;
            this.tsDatPhong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDatPhong.Name = "tsDatPhong";
            this.tsDatPhong.Size = new System.Drawing.Size(285, 35);
            this.tsDatPhong.Text = "Đặt phòng                       ";
            this.tsDatPhong.Click += new System.EventHandler(this.tsDatPhong_Click_1);
            // 
            // ts3
            // 
            this.ts3.AllowDrop = true;
            this.ts3.AutoSize = false;
            this.ts3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ts3.Dock = System.Windows.Forms.DockStyle.None;
            this.ts3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ts3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsQuanTriVien});
            this.ts3.Location = new System.Drawing.Point(11, 243);
            this.ts3.Name = "ts3";
            this.ts3.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ts3.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ts3.Size = new System.Drawing.Size(292, 63);
            this.ts3.TabIndex = 11;
            this.ts3.Text = "toolStrip3";
            // 
            // tsQuanTriVien
            // 
            this.tsQuanTriVien.Image = global::DeAn_QT_KS.Properties.Resources.Untitled_design;
            this.tsQuanTriVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsQuanTriVien.Name = "tsQuanTriVien";
            this.tsQuanTriVien.Size = new System.Drawing.Size(289, 35);
            this.tsQuanTriVien.Text = "Quản trị viên                    ";
            this.tsQuanTriVien.Click += new System.EventHandler(this.tsQuanTriVien_Click);
            // 
            // btHoTro
            // 
            this.btHoTro.Image = global::DeAn_QT_KS.Properties.Resources.Untitled_design__2_;
            this.btHoTro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btHoTro.Name = "btHoTro";
            this.btHoTro.Size = new System.Drawing.Size(289, 35);
            this.btHoTro.Text = "Hỗ trợ                               ";
            this.btHoTro.Click += new System.EventHandler(this.btHoTro_Click);
            // 
            // picHome
            // 
            this.picHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHome.Image = global::DeAn_QT_KS.Properties.Resources.Home;
            this.picHome.Location = new System.Drawing.Point(138, 13);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(48, 49);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 13;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // ts4
            // 
            this.ts4.AutoSize = false;
            this.ts4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ts4.Dock = System.Windows.Forms.DockStyle.None;
            this.ts4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ts4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btHoTro});
            this.ts4.Location = new System.Drawing.Point(11, 316);
            this.ts4.Name = "ts4";
            this.ts4.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ts4.Size = new System.Drawing.Size(292, 63);
            this.ts4.TabIndex = 12;
            this.ts4.Text = "toolStrip4";
            // 
            // pn_Left
            // 
            this.pn_Left.AutoSize = true;
            this.pn_Left.BackColor = System.Drawing.Color.Lavender;
            this.pn_Left.Controls.Add(this.pictureBox2);
            this.pn_Left.Controls.Add(this.ts5);
            this.pn_Left.Controls.Add(this.picHome);
            this.pn_Left.Controls.Add(this.monthCalendar1);
            this.pn_Left.Controls.Add(this.ts4);
            this.pn_Left.Controls.Add(this.ts3);
            this.pn_Left.Controls.Add(this.ts2);
            this.pn_Left.Controls.Add(this.ts1);
            this.pn_Left.Location = new System.Drawing.Point(1, 1);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(343, 1311);
            this.pn_Left.TabIndex = 3;
            // 
            // ts5
            // 
            this.ts5.AutoSize = false;
            this.ts5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ts5.Dock = System.Windows.Forms.DockStyle.None;
            this.ts5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ts5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDangXuat});
            this.ts5.Location = new System.Drawing.Point(11, 393);
            this.ts5.Name = "ts5";
            this.ts5.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ts5.Size = new System.Drawing.Size(292, 63);
            this.ts5.TabIndex = 28;
            this.ts5.Text = "toolStrip4";
            // 
            // tsDangXuat
            // 
            this.tsDangXuat.Image = global::DeAn_QT_KS.Properties.Resources.Untitled_design__13_;
            this.tsDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDangXuat.Name = "tsDangXuat";
            this.tsDangXuat.Size = new System.Drawing.Size(281, 35);
            this.tsDangXuat.Text = "Đăng xuất                       ";
            this.tsDangXuat.Click += new System.EventHandler(this.tsDangXuat_Click_1);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.monthCalendar1.Location = new System.Drawing.Point(45, 591);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Thistle;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 817);
            this.Controls.Add(this.pnFormCon);
            this.Controls.Add(this.pn_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.ts2.ResumeLayout(false);
            this.ts2.PerformLayout();
            this.ts3.ResumeLayout(false);
            this.ts3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ts4.ResumeLayout(false);
            this.ts4.PerformLayout();
            this.pn_Left.ResumeLayout(false);
            this.ts5.ResumeLayout(false);
            this.ts5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnFormCon;
        private ToolStripMenuItem tsPhong;
        private ToolStripMenuItem tsKhachHang;
        private ToolStripDropDownButton tsThongTin;
        private ToolStripMenuItem tsDichVu;
        private ToolStrip ts1;
        private ToolStrip ts2;
        private ToolStrip ts3;
        private ToolStripButton btHoTro;
        private PictureBox picHome;
        private ToolStrip ts4;
        private Panel pn_Left;
        private PictureBox pictureBox2;
        private MonthCalendar monthCalendar1;
        private ToolStripButton tsDatPhong;
        private ToolStrip ts5;
        private ToolStripButton tsDangXuat;
        private ToolStripButton tsQuanTriVien;
    }
}