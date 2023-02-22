namespace DeAn_QT_KS
{
    partial class ThongTinDichVu
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
            this.dgvThongTinDichVu = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbTenDichVu = new System.Windows.Forms.ComboBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.lbDem = new System.Windows.Forms.Label();
            this.btLuuThongTinDichVu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDichVu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinDichVu
            // 
            this.dgvThongTinDichVu.AllowDrop = true;
            this.dgvThongTinDichVu.AllowUserToAddRows = false;
            this.dgvThongTinDichVu.AllowUserToDeleteRows = false;
            this.dgvThongTinDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongTinDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinDichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvThongTinDichVu.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvThongTinDichVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvThongTinDichVu.Location = new System.Drawing.Point(32, 68);
            this.dgvThongTinDichVu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvThongTinDichVu.Name = "dgvThongTinDichVu";
            this.dgvThongTinDichVu.ReadOnly = true;
            this.dgvThongTinDichVu.RowHeadersWidth = 51;
            this.dgvThongTinDichVu.RowTemplate.Height = 29;
            this.dgvThongTinDichVu.ShowEditingIcon = false;
            this.dgvThongTinDichVu.Size = new System.Drawing.Size(516, 322);
            this.dgvThongTinDichVu.TabIndex = 1;
            this.dgvThongTinDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinDichVu_CellClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenDichVu";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Tên dịch vụ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "donGia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "donVi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Đơn vị";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbbTenDichVu);
            this.groupBox3.Controls.Add(this.txtDonVi);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtDonGia);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(572, 68);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Size = new System.Drawing.Size(412, 218);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin dịch vụ";
            // 
            // cbbTenDichVu
            // 
            this.cbbTenDichVu.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbbTenDichVu.FormattingEnabled = true;
            this.cbbTenDichVu.Items.AddRange(new object[] {
            "Buffet sáng",
            "Buffet tối",
            "Giặt ủi",
            "Nước suối",
            "Nước ngọt",
            "Spa",
            "Phòng gym",
            "Hồ bơi",
            "Golf",
            "Bắn cung"});
            this.cbbTenDichVu.Location = new System.Drawing.Point(119, 38);
            this.cbbTenDichVu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbbTenDichVu.Name = "cbbTenDichVu";
            this.cbbTenDichVu.Size = new System.Drawing.Size(232, 36);
            this.cbbTenDichVu.TabIndex = 1;
            this.cbbTenDichVu.TextChanged += new System.EventHandler(this.cbbTenDichVu_TextChanged);
            // 
            // txtDonVi
            // 
            this.txtDonVi.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtDonVi.Enabled = false;
            this.txtDonVi.Location = new System.Drawing.Point(119, 163);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(232, 34);
            this.txtDonVi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn vị:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(119, 105);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(232, 34);
            this.txtDonGia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên dịch vụ:";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Plum;
            this.btThoat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btThoat.Location = new System.Drawing.Point(824, 308);
            this.btThoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(160, 49);
            this.btThoat.TabIndex = 31;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // lbDem
            // 
            this.lbDem.AutoSize = true;
            this.lbDem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbDem.Location = new System.Drawing.Point(32, 30);
            this.lbDem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDem.Name = "lbDem";
            this.lbDem.Size = new System.Drawing.Size(64, 28);
            this.lbDem.TabIndex = 30;
            this.lbDem.Text = "label1";
            // 
            // btLuuThongTinDichVu
            // 
            this.btLuuThongTinDichVu.BackColor = System.Drawing.Color.Plum;
            this.btLuuThongTinDichVu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLuuThongTinDichVu.Location = new System.Drawing.Point(572, 308);
            this.btLuuThongTinDichVu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btLuuThongTinDichVu.Name = "btLuuThongTinDichVu";
            this.btLuuThongTinDichVu.Size = new System.Drawing.Size(160, 49);
            this.btLuuThongTinDichVu.TabIndex = 32;
            this.btLuuThongTinDichVu.Text = "Lưu File";
            this.btLuuThongTinDichVu.UseVisualStyleBackColor = false;
            this.btLuuThongTinDichVu.Click += new System.EventHandler(this.btLuuThongTinDichVu_Click);
            // 
            // ThongTinDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1013, 581);
            this.Controls.Add(this.btLuuThongTinDichVu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.lbDem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvThongTinDichVu);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ThongTinDichVu";
            this.Text = "ThongTinDichVu";
            this.Load += new System.EventHandler(this.dgvThongTinDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDichVu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvThongTinDichVu;
        private GroupBox groupBox3;
        private TextBox txtDonVi;
        private Label label3;
        private TextBox txtDonGia;
        private Label label2;
        private Label label1;
        private Label lbDem;
        private Button btThoat;
        private ComboBox cbbTenDichVu;
        private Button btLuuThongTinDichVu;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}