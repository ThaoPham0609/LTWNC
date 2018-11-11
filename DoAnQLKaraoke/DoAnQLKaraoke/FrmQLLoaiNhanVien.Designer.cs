namespace DoAnQLKaraoke
{
    partial class FrmQLLoaiNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbdstknv = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvdstknv = new System.Windows.Forms.DataGridView();
            this.colTINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbdstknv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdstknv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(170, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Loại Nhân Viên ";
            // 
            // grbdstknv
            // 
            this.grbdstknv.Controls.Add(this.button2);
            this.grbdstknv.Controls.Add(this.button1);
            this.grbdstknv.Controls.Add(this.textBox6);
            this.grbdstknv.Controls.Add(this.textBox5);
            this.grbdstknv.Controls.Add(this.textBox4);
            this.grbdstknv.Controls.Add(this.label7);
            this.grbdstknv.Controls.Add(this.label6);
            this.grbdstknv.Controls.Add(this.label5);
            this.grbdstknv.Location = new System.Drawing.Point(2, 140);
            this.grbdstknv.Margin = new System.Windows.Forms.Padding(2);
            this.grbdstknv.Name = "grbdstknv";
            this.grbdstknv.Padding = new System.Windows.Forms.Padding(2);
            this.grbdstknv.Size = new System.Drawing.Size(851, 141);
            this.grbdstknv.TabIndex = 6;
            this.grbdstknv.TabStop = false;
            this.grbdstknv.Text = "Thông tin";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 61);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(452, 28);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(168, 20);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(176, 73);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 20);
            this.textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 30);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(370, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tình Trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(102, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(99, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Loại";
            // 
            // dgvdstknv
            // 
            this.dgvdstknv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdstknv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdstknv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdstknv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTINHTRANG,
            this.colMaLoai,
            this.colTenLoai});
            this.dgvdstknv.Location = new System.Drawing.Point(2, 285);
            this.dgvdstknv.Margin = new System.Windows.Forms.Padding(2);
            this.dgvdstknv.Name = "dgvdstknv";
            this.dgvdstknv.RowTemplate.Height = 24;
            this.dgvdstknv.Size = new System.Drawing.Size(851, 172);
            this.dgvdstknv.TabIndex = 7;
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.DataPropertyName = "TINHTRANG";
            this.colTINHTRANG.HeaderText = "Tình Trạng";
            this.colTINHTRANG.Name = "colTINHTRANG";
            // 
            // colMaLoai
            // 
            this.colMaLoai.DataPropertyName = "MALOAI";
            this.colMaLoai.HeaderText = "Mã Loại NV";
            this.colMaLoai.Name = "colMaLoai";
            // 
            // colTenLoai
            // 
            this.colTenLoai.DataPropertyName = "TENLOAI";
            this.colTenLoai.HeaderText = "Tên Loại NV";
            this.colTenLoai.Name = "colTenLoai";
            // 
            // FrmQLLoaiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 453);
            this.Controls.Add(this.dgvdstknv);
            this.Controls.Add(this.grbdstknv);
            this.Controls.Add(this.label1);
            this.Name = "FrmQLLoaiNhanVien";
            this.Text = "FrmQLLoaiNhanVien";
            this.grbdstknv.ResumeLayout(false);
            this.grbdstknv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdstknv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbdstknv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvdstknv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTINHTRANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoai;
    }
}