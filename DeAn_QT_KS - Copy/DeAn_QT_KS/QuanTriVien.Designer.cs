
namespace DeAn_QT_KS
{
    partial class QuanTriVien
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
            this.btSua = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbMaAdmin = new System.Windows.Forms.ComboBox();
            this.cbbCaLamAdmin = new System.Windows.Forms.ComboBox();
            this.dtpNgayLamAdmin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picHinhAdmin = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoDienThoaiAdmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCMNDAdmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCaLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAdmin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Plum;
            this.btSua.Location = new System.Drawing.Point(189, 582);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(101, 58);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbMaAdmin);
            this.groupBox3.Controls.Add(this.cbbCaLamAdmin);
            this.groupBox3.Controls.Add(this.dtpNgayLamAdmin);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.picHinhAdmin);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSoDienThoaiAdmin);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtCMNDAdmin);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtTenAdmin);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(47, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(528, 389);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chỉnh sửa thông tin";
            // 
            // cbbMaAdmin
            // 
            this.cbbMaAdmin.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbbMaAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaAdmin.FormattingEnabled = true;
            this.cbbMaAdmin.Items.AddRange(new object[] {
            "AD1",
            "AD2",
            "AD3",
            "AD4",
            "AD5"});
            this.cbbMaAdmin.Location = new System.Drawing.Point(304, 86);
            this.cbbMaAdmin.Name = "cbbMaAdmin";
            this.cbbMaAdmin.Size = new System.Drawing.Size(202, 37);
            this.cbbMaAdmin.TabIndex = 1;
            this.cbbMaAdmin.TextChanged += new System.EventHandler(this.cbbMaAdmin_TextChanged);
            // 
            // cbbCaLamAdmin
            // 
            this.cbbCaLamAdmin.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbbCaLamAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCaLamAdmin.FormattingEnabled = true;
            this.cbbCaLamAdmin.Items.AddRange(new object[] {
            "Sáng",
            "Chiều",
            "Tối"});
            this.cbbCaLamAdmin.Location = new System.Drawing.Point(197, 331);
            this.cbbCaLamAdmin.Name = "cbbCaLamAdmin";
            this.cbbCaLamAdmin.Size = new System.Drawing.Size(310, 37);
            this.cbbCaLamAdmin.TabIndex = 6;
            // 
            // dtpNgayLamAdmin
            // 
            this.dtpNgayLamAdmin.CalendarMonthBackground = System.Drawing.Color.NavajoWhite;
            this.dtpNgayLamAdmin.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLamAdmin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLamAdmin.Location = new System.Drawing.Point(198, 288);
            this.dtpNgayLamAdmin.Name = "dtpNgayLamAdmin";
            this.dtpNgayLamAdmin.Size = new System.Drawing.Size(309, 34);
            this.dtpNgayLamAdmin.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Mã nhân viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ca làm:";
            // 
            // picHinhAdmin
            // 
            this.picHinhAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.picHinhAdmin.Location = new System.Drawing.Point(19, 48);
            this.picHinhAdmin.Name = "picHinhAdmin";
            this.picHinhAdmin.Size = new System.Drawing.Size(99, 110);
            this.picHinhAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhAdmin.TabIndex = 26;
            this.picHinhAdmin.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày làm:";
            // 
            // txtSoDienThoaiAdmin
            // 
            this.txtSoDienThoaiAdmin.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtSoDienThoaiAdmin.Location = new System.Drawing.Point(198, 244);
            this.txtSoDienThoaiAdmin.MaxLength = 11;
            this.txtSoDienThoaiAdmin.Name = "txtSoDienThoaiAdmin";
            this.txtSoDienThoaiAdmin.Size = new System.Drawing.Size(308, 34);
            this.txtSoDienThoaiAdmin.TabIndex = 4;
            this.txtSoDienThoaiAdmin.TextChanged += new System.EventHandler(this.txtCMNDAdmin_TextChanged);
            this.txtSoDienThoaiAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMNDAdmin_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại:";
            // 
            // txtCMNDAdmin
            // 
            this.txtCMNDAdmin.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtCMNDAdmin.Location = new System.Drawing.Point(198, 200);
            this.txtCMNDAdmin.MaxLength = 12;
            this.txtCMNDAdmin.Name = "txtCMNDAdmin";
            this.txtCMNDAdmin.Size = new System.Drawing.Size(308, 34);
            this.txtCMNDAdmin.TabIndex = 3;
            this.txtCMNDAdmin.TextChanged += new System.EventHandler(this.txtCMNDAdmin_TextChanged);
            this.txtCMNDAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMNDAdmin_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "CMND/CCCD:";
            // 
            // txtTenAdmin
            // 
            this.txtTenAdmin.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtTenAdmin.Location = new System.Drawing.Point(197, 156);
            this.txtTenAdmin.MaxLength = 30;
            this.txtTenAdmin.Name = "txtTenAdmin";
            this.txtTenAdmin.Size = new System.Drawing.Size(309, 34);
            this.txtTenAdmin.TabIndex = 2;
            this.txtTenAdmin.TextChanged += new System.EventHandler(this.txtCMNDAdmin_TextChanged);
            this.txtTenAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenAdmin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAdmin);
            this.groupBox1.Location = new System.Drawing.Point(44, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 169);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowDrop = true;
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.cCMND,
            this.cSDT,
            this.cNgayLam,
            this.cCaLam});
            this.dgvAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdmin.Location = new System.Drawing.Point(3, 30);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(958, 136);
            this.dgvAdmin.TabIndex = 0;
            this.dgvAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maAdmin";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenAdmin";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cCMND
            // 
            this.cCMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCMND.DataPropertyName = "cmndAdmin";
            this.cCMND.HeaderText = "CNMD/CCCD";
            this.cCMND.MinimumWidth = 6;
            this.cCMND.Name = "cCMND";
            this.cCMND.ReadOnly = true;
            this.cCMND.Width = 189;
            // 
            // cSDT
            // 
            this.cSDT.DataPropertyName = "soDienThoaiAdmin";
            this.cSDT.HeaderText = "Số điện thoại";
            this.cSDT.MinimumWidth = 6;
            this.cSDT.Name = "cSDT";
            this.cSDT.ReadOnly = true;
            // 
            // cNgayLam
            // 
            this.cNgayLam.DataPropertyName = "ngayLamAdmin";
            this.cNgayLam.HeaderText = "Ngày làm";
            this.cNgayLam.MinimumWidth = 6;
            this.cNgayLam.Name = "cNgayLam";
            this.cNgayLam.ReadOnly = true;
            // 
            // cCaLam
            // 
            this.cCaLam.DataPropertyName = "caLamAdmin";
            this.cCaLam.HeaderText = "Ca làm";
            this.cCaLam.MinimumWidth = 6;
            this.cCaLam.Name = "cCaLam";
            this.cCaLam.ReadOnly = true;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Plum;
            this.btThem.Location = new System.Drawing.Point(47, 582);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(101, 58);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Plum;
            this.btXoa.Location = new System.Drawing.Point(331, 582);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(101, 58);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.BackColor = System.Drawing.Color.Lavender;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbThongBao.ForeColor = System.Drawing.Color.Maroon;
            this.lbThongBao.Location = new System.Drawing.Point(595, 478);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(0, 29);
            this.lbThongBao.TabIndex = 1;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Plum;
            this.btThoat.Location = new System.Drawing.Point(474, 582);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(101, 58);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // QuanTriVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1061, 519);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "QuanTriVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanTriVien";
            this.Load += new System.EventHandler(this.QuanTriVien_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAdmin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoDienThoaiAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCMNDAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btXoa;
        private DateTimePicker dtpNgayLamAdmin;
        private ComboBox cbbCaLamAdmin;
        private ComboBox cbbMaAdmin;
        private Label lbThongBao;
        private Button btThoat;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn cCMND;
        private DataGridViewTextBoxColumn cSDT;
        private DataGridViewTextBoxColumn cNgayLam;
        private DataGridViewTextBoxColumn cCaLam;
        private PictureBox picHinhAdmin;
    }
}