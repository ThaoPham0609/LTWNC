namespace DoAnQLKaraoke
{
    partial class FrmQLKHACHHANG
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
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Ho = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.lbldanhsachnv = new System.Windows.Forms.Label();
            this.grbdstknv = new System.Windows.Forms.GroupBox();
            this.btn_qlLoaiPhong = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_traCuu = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.colMAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOAIKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colHOKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNAMSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTINHTRANG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbo_LoaiKH = new System.Windows.Forms.ComboBox();
            this.cbo_TinhTrang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.grbdstknv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Location = new System.Drawing.Point(418, 117);
            this.dtp_NgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(168, 20);
            this.dtp_NgaySinh.TabIndex = 6;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(664, 22);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(151, 20);
            this.txt_SDT.TabIndex = 1;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(418, 67);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(168, 20);
            this.txt_Ten.TabIndex = 1;
            // 
            // txt_Ho
            // 
            this.txt_Ho.Location = new System.Drawing.Point(418, 22);
            this.txt_Ho.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(168, 20);
            this.txt_Ho.TabIndex = 1;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(105, 25);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(168, 20);
            this.txt_MaKH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(337, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm Sinh\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(337, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "TênKH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(612, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "SDT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(337, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(24, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tình Trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(24, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại KH\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(24, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã KH";
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMAKH,
            this.colLOAIKH,
            this.colHOKH,
            this.colTENKH,
            this.colNAMSINH,
            this.colSDT,
            this.colTINHTRANG});
            this.dgv_KhachHang.Location = new System.Drawing.Point(3, 266);
            this.dgv_KhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(1060, 201);
            this.dgv_KhachHang.TabIndex = 15;
            // 
            // lbldanhsachnv
            // 
            this.lbldanhsachnv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldanhsachnv.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldanhsachnv.ForeColor = System.Drawing.Color.Salmon;
            this.lbldanhsachnv.Location = new System.Drawing.Point(73, 26);
            this.lbldanhsachnv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldanhsachnv.Name = "lbldanhsachnv";
            this.lbldanhsachnv.Size = new System.Drawing.Size(939, 55);
            this.lbldanhsachnv.TabIndex = 13;
            this.lbldanhsachnv.Text = "Quản Lý Khách Hàng";
            this.lbldanhsachnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbdstknv
            // 
            this.grbdstknv.Controls.Add(this.cbo_TinhTrang);
            this.grbdstknv.Controls.Add(this.cbo_LoaiKH);
            this.grbdstknv.Controls.Add(this.btn_qlLoaiPhong);
            this.grbdstknv.Controls.Add(this.btn_lamMoi);
            this.grbdstknv.Controls.Add(this.btn_luu);
            this.grbdstknv.Controls.Add(this.btn_traCuu);
            this.grbdstknv.Controls.Add(this.btn_capNhat);
            this.grbdstknv.Controls.Add(this.btn_them);
            this.grbdstknv.Controls.Add(this.dtp_NgaySinh);
            this.grbdstknv.Controls.Add(this.txt_SDT);
            this.grbdstknv.Controls.Add(this.txt_Ten);
            this.grbdstknv.Controls.Add(this.txt_Ho);
            this.grbdstknv.Controls.Add(this.txt_MaKH);
            this.grbdstknv.Controls.Add(this.label3);
            this.grbdstknv.Controls.Add(this.label2);
            this.grbdstknv.Controls.Add(this.label7);
            this.grbdstknv.Controls.Add(this.label1);
            this.grbdstknv.Controls.Add(this.label4);
            this.grbdstknv.Controls.Add(this.label6);
            this.grbdstknv.Controls.Add(this.label5);
            this.grbdstknv.Location = new System.Drawing.Point(3, 97);
            this.grbdstknv.Margin = new System.Windows.Forms.Padding(2);
            this.grbdstknv.Name = "grbdstknv";
            this.grbdstknv.Padding = new System.Windows.Forms.Padding(2);
            this.grbdstknv.Size = new System.Drawing.Size(1006, 155);
            this.grbdstknv.TabIndex = 14;
            this.grbdstknv.TabStop = false;
            this.grbdstknv.Text = "Thông tin";
            // 
            // btn_qlLoaiPhong
            // 
            this.btn_qlLoaiPhong.Location = new System.Drawing.Point(286, 117);
            this.btn_qlLoaiPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btn_qlLoaiPhong.Name = "btn_qlLoaiPhong";
            this.btn_qlLoaiPhong.Size = new System.Drawing.Size(21, 19);
            this.btn_qlLoaiPhong.TabIndex = 27;
            this.btn_qlLoaiPhong.Text = "+";
            this.btn_qlLoaiPhong.UseVisualStyleBackColor = true;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Image = global::DoAnQLKaraoke.Properties.Resources.refresh;
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.Location = new System.Drawing.Point(840, 109);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_lamMoi.Size = new System.Drawing.Size(80, 41);
            this.btn_lamMoi.TabIndex = 26;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.Image = global::DoAnQLKaraoke.Properties.Resources.save;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(664, 55);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(78, 42);
            this.btn_luu.TabIndex = 25;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            // 
            // btn_traCuu
            // 
            this.btn_traCuu.Image = global::DoAnQLKaraoke.Properties.Resources.search;
            this.btn_traCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_traCuu.Location = new System.Drawing.Point(718, 110);
            this.btn_traCuu.Name = "btn_traCuu";
            this.btn_traCuu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_traCuu.Size = new System.Drawing.Size(81, 39);
            this.btn_traCuu.TabIndex = 22;
            this.btn_traCuu.Text = "Tra cứu";
            this.btn_traCuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_traCuu.UseVisualStyleBackColor = true;
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_capNhat.Image = global::DoAnQLKaraoke.Properties.Resources.edit;
            this.btn_capNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capNhat.Location = new System.Drawing.Point(906, 61);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(80, 42);
            this.btn_capNhat.TabIndex = 23;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capNhat.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Image = global::DoAnQLKaraoke.Properties.Resources.add;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(788, 61);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 42);
            this.btn_them.TabIndex = 24;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // colMAKH
            // 
            this.colMAKH.DataPropertyName = "MAKH";
            this.colMAKH.HeaderText = "MAKH";
            this.colMAKH.Name = "colMAKH";
            // 
            // colLOAIKH
            // 
            this.colLOAIKH.DataPropertyName = "LOAIKH";
            this.colLOAIKH.HeaderText = "LOAIKH";
            this.colLOAIKH.Name = "colLOAIKH";
            this.colLOAIKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLOAIKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colHOKH
            // 
            this.colHOKH.DataPropertyName = "HOKH";
            this.colHOKH.HeaderText = "HOKH";
            this.colHOKH.Name = "colHOKH";
            // 
            // colTENKH
            // 
            this.colTENKH.HeaderText = "TENKH";
            this.colTENKH.Name = "colTENKH";
            // 
            // colNAMSINH
            // 
            this.colNAMSINH.HeaderText = "NAMSINH";
            this.colNAMSINH.Name = "colNAMSINH";
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "SDT";
            this.colSDT.Name = "colSDT";
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.HeaderText = "TINHTRANG";
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTINHTRANG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cbo_LoaiKH
            // 
            this.cbo_LoaiKH.FormattingEnabled = true;
            this.cbo_LoaiKH.Location = new System.Drawing.Point(105, 66);
            this.cbo_LoaiKH.Name = "cbo_LoaiKH";
            this.cbo_LoaiKH.Size = new System.Drawing.Size(168, 21);
            this.cbo_LoaiKH.TabIndex = 28;
            // 
            // cbo_TinhTrang
            // 
            this.cbo_TinhTrang.FormattingEnabled = true;
            this.cbo_TinhTrang.Location = new System.Drawing.Point(105, 117);
            this.cbo_TinhTrang.Name = "cbo_TinhTrang";
            this.cbo_TinhTrang.Size = new System.Drawing.Size(168, 21);
            this.cbo_TinhTrang.TabIndex = 29;
            // 
            // FrmQLKHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 478);
            this.Controls.Add(this.dgv_KhachHang);
            this.Controls.Add(this.lbldanhsachnv);
            this.Controls.Add(this.grbdstknv);
            this.Name = "FrmQLKHACHHANG";
            this.Text = "FrmQLKHACHHANG";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.grbdstknv.ResumeLayout(false);
            this.grbdstknv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.Label lbldanhsachnv;
        private System.Windows.Forms.GroupBox grbdstknv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMAKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLOAIKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHOKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNAMSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTINHTRANG;
        private System.Windows.Forms.Button btn_qlLoaiPhong;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_traCuu;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cbo_TinhTrang;
        private System.Windows.Forms.ComboBox cbo_LoaiKH;
    }
}