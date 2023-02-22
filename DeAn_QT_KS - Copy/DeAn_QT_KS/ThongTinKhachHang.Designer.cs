namespace DeAn_QT_KS
{
    partial class ThongTinKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThongTinKH = new System.Windows.Forms.DataGridView();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phaiThuKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDem = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.btLuuThongTinKhachHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKH)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinKH
            // 
            this.dgvThongTinKH.AllowUserToAddRows = false;
            this.dgvThongTinKH.AllowUserToDeleteRows = false;
            this.dgvThongTinKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvThongTinKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinKH.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvThongTinKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenKhachHang,
            this.CMND,
            this.soDienThoai,
            this.phong,
            this.Column1,
            this.Column2,
            this.phaiThuKhachHang,
            this.Column3});
            this.dgvThongTinKH.Location = new System.Drawing.Point(68, 61);
            this.dgvThongTinKH.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dgvThongTinKH.Name = "dgvThongTinKH";
            this.dgvThongTinKH.ReadOnly = true;
            this.dgvThongTinKH.RowHeadersWidth = 51;
            this.dgvThongTinKH.RowTemplate.Height = 29;
            this.dgvThongTinKH.Size = new System.Drawing.Size(975, 169);
            this.dgvThongTinKH.TabIndex = 11;
            this.dgvThongTinKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinKH_CellClick);
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.DataPropertyName = "tenKhachHang";
            this.tenKhachHang.HeaderText = "Tên khách hàng";
            this.tenKhachHang.MinimumWidth = 6;
            this.tenKhachHang.Name = "tenKhachHang";
            this.tenKhachHang.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "cMND";
            this.CMND.HeaderText = "Số CMND/CCCD";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // soDienThoai
            // 
            this.soDienThoai.DataPropertyName = "soDienThoai";
            this.soDienThoai.HeaderText = "Số điện thoại";
            this.soDienThoai.MinimumWidth = 6;
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.ReadOnly = true;
            // 
            // phong
            // 
            this.phong.DataPropertyName = "phong";
            this.phong.HeaderText = "Phòng";
            this.phong.MinimumWidth = 6;
            this.phong.Name = "phong";
            this.phong.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ngayDen";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Ngày đến";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ngayDi";
            this.Column2.HeaderText = "Ngày đi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // phaiThuKhachHang
            // 
            this.phaiThuKhachHang.DataPropertyName = "thanhToan";
            this.phaiThuKhachHang.HeaderText = "Thành tiền";
            this.phaiThuKhachHang.MinimumWidth = 6;
            this.phaiThuKhachHang.Name = "phaiThuKhachHang";
            this.phaiThuKhachHang.ReadOnly = true;
            this.phaiThuKhachHang.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "soNgayO";
            this.Column3.HeaderText = "Số ngày ở";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // lbDem
            // 
            this.lbDem.AutoSize = true;
            this.lbDem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbDem.Location = new System.Drawing.Point(29, 25);
            this.lbDem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDem.Name = "lbDem";
            this.lbDem.Size = new System.Drawing.Size(64, 28);
            this.lbDem.TabIndex = 11;
            this.lbDem.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dtpNgayDi);
            this.groupBox3.Controls.Add(this.dtpNgayDen);
            this.groupBox3.Controls.Add(this.cbPhong);
            this.groupBox3.Controls.Add(this.txtSoDienThoai);
            this.groupBox3.Controls.Add(this.txtCMND);
            this.groupBox3.Controls.Add(this.txtTenKhachHang);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(29, 305);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox3.Size = new System.Drawing.Size(570, 300);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin:";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayDi.Enabled = false;
            this.dtpNgayDi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(153, 246);
            this.dtpNgayDi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(258, 31);
            this.dtpNgayDi.TabIndex = 6;
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayDen.Enabled = false;
            this.dtpNgayDen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(153, 204);
            this.dtpNgayDen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(258, 31);
            this.dtpNgayDen.TabIndex = 5;
            // 
            // cbPhong
            // 
            this.cbPhong.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Items.AddRange(new object[] {
            "V01",
            "V02",
            "V03",
            "D01",
            "D02",
            "D03",
            "S01",
            "S02",
            "S03"});
            this.cbPhong.Location = new System.Drawing.Point(153, 28);
            this.cbPhong.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(258, 40);
            this.cbPhong.TabIndex = 1;
            this.cbPhong.TextChanged += new System.EventHandler(this.cbPhong_TextChanged);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoDienThoai.Location = new System.Drawing.Point(153, 162);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSoDienThoai.MaxLength = 11;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(258, 31);
            this.txtSoDienThoai.TabIndex = 4;
            this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtCMND.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCMND.Location = new System.Drawing.Point(153, 119);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCMND.MaxLength = 12;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(258, 31);
            this.txtCMND.TabIndex = 3;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenKhachHang.Location = new System.Drawing.Point(153, 77);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtTenKhachHang.MaxLength = 25;
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(258, 31);
            this.txtTenKhachHang.TabIndex = 2;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            this.txtTenKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKhachHang_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ngày đi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ngày đến:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "CMND/CCCD:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khách hàng:";
            // 
            // btThoat
            // 
            this.btThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btThoat.BackColor = System.Drawing.Color.Plum;
            this.btThoat.Location = new System.Drawing.Point(753, 687);
            this.btThoat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(129, 52);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSua.BackColor = System.Drawing.Color.Plum;
            this.btSua.Location = new System.Drawing.Point(270, 687);
            this.btSua.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(129, 52);
            this.btSua.TabIndex = 7;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btXoa.BackColor = System.Drawing.Color.Plum;
            this.btXoa.Location = new System.Drawing.Point(431, 687);
            this.btXoa.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(129, 52);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // lbThongBao
            // 
            this.lbThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbThongBao.ForeColor = System.Drawing.Color.Maroon;
            this.lbThongBao.Location = new System.Drawing.Point(632, 582);
            this.lbThongBao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(0, 23);
            this.lbThongBao.TabIndex = 2;
            // 
            // btLuuThongTinKhachHang
            // 
            this.btLuuThongTinKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btLuuThongTinKhachHang.BackColor = System.Drawing.Color.Plum;
            this.btLuuThongTinKhachHang.Location = new System.Drawing.Point(592, 687);
            this.btLuuThongTinKhachHang.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btLuuThongTinKhachHang.Name = "btLuuThongTinKhachHang";
            this.btLuuThongTinKhachHang.Size = new System.Drawing.Size(129, 52);
            this.btLuuThongTinKhachHang.TabIndex = 12;
            this.btLuuThongTinKhachHang.Text = "Lưu File";
            this.btLuuThongTinKhachHang.UseVisualStyleBackColor = false;
            this.btLuuThongTinKhachHang.Click += new System.EventHandler(this.btLuuThongTinKhachHang_Click);
            // 
            // ThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1090, 751);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.btLuuThongTinKhachHang);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbDem);
            this.Controls.Add(this.dgvThongTinKH);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "ThongTinKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinKhachHang";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ThongTinKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKH)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvThongTinKH;
        private Label lbDem;
        private GroupBox groupBox3;
        private ComboBox cbPhong;
        private Label label4;
        private TextBox txtSoDienThoai;
        private Label label3;
        private TextBox txtCMND;
        private Label label2;
        private TextBox txtTenKhachHang;
        private Label label1;
        private DateTimePicker dtpNgayDen;
        private Label label5;
        private Button btThoat;
        private DateTimePicker dtpNgayDi;
        private Label label6;
        private Button btSua;
        private DataGridViewTextBoxColumn tenKhachHang;
        private DataGridViewTextBoxColumn CMND;
        private DataGridViewTextBoxColumn soDienThoai;
        private DataGridViewTextBoxColumn phong;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn phaiThuKhachHang;
        private DataGridViewTextBoxColumn Column3;
        private Button btXoa;
        private Label lbThongBao;
        private Button btLuuThongTinKhachHang;
    }
}