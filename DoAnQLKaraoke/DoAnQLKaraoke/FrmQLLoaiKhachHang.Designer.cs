namespace DoAnQLKaraoke
{
    partial class FrmQLLoaiKhachHang
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
            this.dgvdstknv = new System.Windows.Forms.DataGridView();
            this.colMALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTENLOAIKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coTINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldanhsachnv = new System.Windows.Forms.Label();
            this.grbdstknv = new System.Windows.Forms.GroupBox();
            this.btnquayve = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdstknv)).BeginInit();
            this.grbdstknv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdstknv
            // 
            this.dgvdstknv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdstknv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdstknv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdstknv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMALOAI,
            this.colTENLOAIKH,
            this.coTINHTRANG});
            this.dgvdstknv.Location = new System.Drawing.Point(3, 242);
            this.dgvdstknv.Margin = new System.Windows.Forms.Padding(2);
            this.dgvdstknv.Name = "dgvdstknv";
            this.dgvdstknv.RowTemplate.Height = 24;
            this.dgvdstknv.Size = new System.Drawing.Size(1006, 172);
            this.dgvdstknv.TabIndex = 12;
            // 
            // colMALOAI
            // 
            this.colMALOAI.DataPropertyName = "MALOAI";
            this.colMALOAI.HeaderText = "Mã Loại";
            this.colMALOAI.Name = "colMALOAI";
            // 
            // colTENLOAIKH
            // 
            this.colTENLOAIKH.DataPropertyName = "TENLOAIKH";
            this.colTENLOAIKH.HeaderText = "Tên Loại";
            this.colTENLOAIKH.Name = "colTENLOAIKH";
            // 
            // coTINHTRANG
            // 
            this.coTINHTRANG.DataPropertyName = "TINHTRANG";
            this.coTINHTRANG.HeaderText = "Tình Trạng";
            this.coTINHTRANG.Name = "coTINHTRANG";
            // 
            // lbldanhsachnv
            // 
            this.lbldanhsachnv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldanhsachnv.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldanhsachnv.ForeColor = System.Drawing.Color.Salmon;
            this.lbldanhsachnv.Location = new System.Drawing.Point(46, 26);
            this.lbldanhsachnv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldanhsachnv.Name = "lbldanhsachnv";
            this.lbldanhsachnv.Size = new System.Drawing.Size(939, 55);
            this.lbldanhsachnv.TabIndex = 10;
            this.lbldanhsachnv.Text = "Quản Lý Loại Khách Hàng";
            this.lbldanhsachnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbdstknv
            // 
            this.grbdstknv.Controls.Add(this.btnquayve);
            this.grbdstknv.Controls.Add(this.button3);
            this.grbdstknv.Controls.Add(this.button2);
            this.grbdstknv.Controls.Add(this.button1);
            this.grbdstknv.Controls.Add(this.textBox6);
            this.grbdstknv.Controls.Add(this.textBox5);
            this.grbdstknv.Controls.Add(this.textBox4);
            this.grbdstknv.Controls.Add(this.label7);
            this.grbdstknv.Controls.Add(this.label6);
            this.grbdstknv.Controls.Add(this.label5);
            this.grbdstknv.Location = new System.Drawing.Point(3, 97);
            this.grbdstknv.Margin = new System.Windows.Forms.Padding(2);
            this.grbdstknv.Name = "grbdstknv";
            this.grbdstknv.Padding = new System.Windows.Forms.Padding(2);
            this.grbdstknv.Size = new System.Drawing.Size(1006, 141);
            this.grbdstknv.TabIndex = 11;
            this.grbdstknv.TabStop = false;
            this.grbdstknv.Text = "Thông tin";
            // 
            // btnquayve
            // 
            this.btnquayve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnquayve.Location = new System.Drawing.Point(910, 18);
            this.btnquayve.Margin = new System.Windows.Forms.Padding(2);
            this.btnquayve.Name = "btnquayve";
            this.btnquayve.Size = new System.Drawing.Size(91, 30);
            this.btnquayve.TabIndex = 5;
            this.btnquayve.Text = "Quay Về";
            this.btnquayve.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 105);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Tra cứu";
            this.button3.UseVisualStyleBackColor = true;
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
            this.textBox6.Location = new System.Drawing.Point(438, 30);
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
            this.label7.Text = "Tình Trạng";
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
            this.label6.Text = "Tên Loại";
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
            this.label5.Text = "Mã Loại";
            // 
            // FrmQLLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 440);
            this.Controls.Add(this.dgvdstknv);
            this.Controls.Add(this.lbldanhsachnv);
            this.Controls.Add(this.grbdstknv);
            this.Name = "FrmQLLoaiKhachHang";
            this.Text = "FrmQLLoaiKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdstknv)).EndInit();
            this.grbdstknv.ResumeLayout(false);
            this.grbdstknv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdstknv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTENLOAIKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn coTINHTRANG;
        private System.Windows.Forms.Label lbldanhsachnv;
        private System.Windows.Forms.GroupBox grbdstknv;
        private System.Windows.Forms.Button btnquayve;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}