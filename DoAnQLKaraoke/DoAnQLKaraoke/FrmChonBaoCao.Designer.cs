﻿namespace DoAnQLKaraoke
{
    partial class FrmChonBaoCao
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
            this.cboNhaXB = new System.Windows.Forms.ComboBox();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.rdbHoaDon = new System.Windows.Forms.RadioButton();
            this.rdbTheoLoai = new System.Windows.Forms.RadioButton();
            this.rdbTatCaPhong = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(94, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Thống kê - Báo cáo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboNhaXB
            // 
            this.cboNhaXB.FormattingEnabled = true;
            this.cboNhaXB.Location = new System.Drawing.Point(258, 138);
            this.cboNhaXB.Name = "cboNhaXB";
            this.cboNhaXB.Size = new System.Drawing.Size(121, 21);
            this.cboNhaXB.TabIndex = 22;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXemBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemBaoCao.Location = new System.Drawing.Point(102, 243);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(150, 39);
            this.btnXemBaoCao.TabIndex = 21;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // rdbHoaDon
            // 
            this.rdbHoaDon.AutoSize = true;
            this.rdbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHoaDon.Location = new System.Drawing.Point(102, 184);
            this.rdbHoaDon.Name = "rdbHoaDon";
            this.rdbHoaDon.Size = new System.Drawing.Size(95, 24);
            this.rdbHoaDon.TabIndex = 18;
            this.rdbHoaDon.TabStop = true;
            this.rdbHoaDon.Text = "Hóa đơn";
            this.rdbHoaDon.UseVisualStyleBackColor = true;
            // 
            // rdbTheoLoai
            // 
            this.rdbTheoLoai.AutoSize = true;
            this.rdbTheoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTheoLoai.Location = new System.Drawing.Point(100, 138);
            this.rdbTheoLoai.Name = "rdbTheoLoai";
            this.rdbTheoLoai.Size = new System.Drawing.Size(152, 24);
            this.rdbTheoLoai.TabIndex = 19;
            this.rdbTheoLoai.TabStop = true;
            this.rdbTheoLoai.Text = "Phòng theo loại";
            this.rdbTheoLoai.UseVisualStyleBackColor = true;
            // 
            // rdbTatCaPhong
            // 
            this.rdbTatCaPhong.AutoSize = true;
            this.rdbTatCaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTatCaPhong.Location = new System.Drawing.Point(100, 94);
            this.rdbTatCaPhong.Name = "rdbTatCaPhong";
            this.rdbTatCaPhong.Size = new System.Drawing.Size(132, 24);
            this.rdbTatCaPhong.TabIndex = 20;
            this.rdbTatCaPhong.TabStop = true;
            this.rdbTatCaPhong.Text = "Tất cả phòng";
            this.rdbTatCaPhong.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::DoAnQLKaraoke.Properties.Resources.HDBan1;
            this.pictureBox1.Image = global::DoAnQLKaraoke.Properties.Resources.HDBan;
            this.pictureBox1.InitialImage = global::DoAnQLKaraoke.Properties.Resources.HDBan;
            this.pictureBox1.Location = new System.Drawing.Point(24, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // FrmChonBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 384);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNhaXB);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.rdbHoaDon);
            this.Controls.Add(this.rdbTheoLoai);
            this.Controls.Add(this.rdbTatCaPhong);
            this.Name = "FrmChonBaoCao";
            this.Text = "FrmChonBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNhaXB;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.RadioButton rdbHoaDon;
        private System.Windows.Forms.RadioButton rdbTheoLoai;
        private System.Windows.Forms.RadioButton rdbTatCaPhong;
    }
}