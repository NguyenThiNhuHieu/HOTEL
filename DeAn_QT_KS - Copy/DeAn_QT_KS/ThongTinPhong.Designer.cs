namespace DeAn_QT_KS
{
    partial class ThongTinPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThongTinPhong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGiaPhog = new System.Windows.Forms.TextBox();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDem = new System.Windows.Forms.Label();
            this.btLuuThongTinPhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPhong)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinPhong
            // 
            this.dgvThongTinPhong.AllowUserToAddRows = false;
            this.dgvThongTinPhong.AllowUserToDeleteRows = false;
            this.dgvThongTinPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongTinPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvThongTinPhong.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvThongTinPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinPhong.ColumnHeadersHeight = 29;
            this.dgvThongTinPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThongTinPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvThongTinPhong.Location = new System.Drawing.Point(13, 73);
            this.dgvThongTinPhong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvThongTinPhong.Name = "dgvThongTinPhong";
            this.dgvThongTinPhong.ReadOnly = true;
            this.dgvThongTinPhong.RowHeadersWidth = 51;
            this.dgvThongTinPhong.RowTemplate.Height = 40;
            this.dgvThongTinPhong.Size = new System.Drawing.Size(780, 250);
            this.dgvThongTinPhong.TabIndex = 0;
            this.dgvThongTinPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinPhong_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "phong";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Phòng";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "loaiPhong";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Loại phòng";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "giaPhong";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Giá";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.BackColor = System.Drawing.Color.Plum;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btThoat.Location = new System.Drawing.Point(1070, 346);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(138, 52);
            this.btThoat.TabIndex = 32;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtGiaPhog);
            this.groupBox3.Controls.Add(this.cbbPhong);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtGiaPhong);
            this.groupBox3.Controls.Add(this.txtLoaiPhong);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(819, 73);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(412, 258);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin:";
            // 
            // txtGiaPhog
            // 
            this.txtGiaPhog.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtGiaPhog.Enabled = false;
            this.txtGiaPhog.Location = new System.Drawing.Point(199, 169);
            this.txtGiaPhog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGiaPhog.Name = "txtGiaPhog";
            this.txtGiaPhog.Size = new System.Drawing.Size(174, 30);
            this.txtGiaPhog.TabIndex = 26;
            // 
            // cbbPhong
            // 
            this.cbbPhong.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Items.AddRange(new object[] {
            "V01",
            "V02",
            "V03",
            "D01",
            "D02",
            "D03",
            "S01",
            "S02",
            "S03"});
            this.cbbPhong.Location = new System.Drawing.Point(199, 42);
            this.cbbPhong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(174, 33);
            this.cbbPhong.TabIndex = 1;
            this.cbbPhong.TextChanged += new System.EventHandler(this.cbbMaPhong_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(569, 43);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phòng:";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.AutoSize = true;
            this.txtGiaPhong.Location = new System.Drawing.Point(21, 174);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(108, 25);
            this.txtGiaPhong.TabIndex = 4;
            this.txtGiaPhong.Text = "Giá phòng:";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtLoaiPhong.Enabled = false;
            this.txtLoaiPhong.Location = new System.Drawing.Point(199, 104);
            this.txtLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(174, 30);
            this.txtLoaiPhong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại phòng:";
            // 
            // lbDem
            // 
            this.lbDem.AutoSize = true;
            this.lbDem.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbDem.Location = new System.Drawing.Point(37, 25);
            this.lbDem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDem.Name = "lbDem";
            this.lbDem.Size = new System.Drawing.Size(78, 32);
            this.lbDem.TabIndex = 33;
            this.lbDem.Text = "label1";
            // 
            // btLuuThongTinPhong
            // 
            this.btLuuThongTinPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLuuThongTinPhong.BackColor = System.Drawing.Color.Plum;
            this.btLuuThongTinPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLuuThongTinPhong.Location = new System.Drawing.Point(842, 346);
            this.btLuuThongTinPhong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btLuuThongTinPhong.Name = "btLuuThongTinPhong";
            this.btLuuThongTinPhong.Size = new System.Drawing.Size(138, 52);
            this.btLuuThongTinPhong.TabIndex = 34;
            this.btLuuThongTinPhong.Text = "Lưu File";
            this.btLuuThongTinPhong.UseVisualStyleBackColor = false;
            this.btLuuThongTinPhong.Click += new System.EventHandler(this.btLuuThongTinPhong_Click);
            // 
            // ThongTinPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1350, 850);
            this.Controls.Add(this.btLuuThongTinPhong);
            this.Controls.Add(this.lbDem);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvThongTinPhong);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ThongTinPhong";
            this.Text = "ThongTinPhong";
            this.Load += new System.EventHandler(this.ThongTinPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPhong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvThongTinPhong;
        private Button btThoat;
        private GroupBox groupBox3;
        private ComboBox cbbPhong;
        private Label label4;
        private Label txtGiaPhong;
        private TextBox txtLoaiPhong;
        private Label label2;
        private TextBox txtGiaPhog;
        private Label lbDem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btLuuThongTinPhong;
    }
}