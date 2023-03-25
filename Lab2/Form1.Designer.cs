using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.XuatThongTin = new System.Windows.Forms.Panel();
            this.TinhTien = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SoDienCu = new System.Windows.Forms.TextBox();
            this.SoDienMoi = new System.Windows.Forms.TextBox();
            this.SoDienTieuThu = new System.Windows.Forms.TextBox();
            this.TienTra = new System.Windows.Forms.TextBox();
            this.SoDienDinhMuc = new System.Windows.Forms.TextBox();
            this.SoDienQua = new System.Windows.Forms.TextBox();
            this.Click_In = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(224, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng Tính Tiền Điện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chỉ số cũ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chỉ số mới:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Kw tiêu thụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(475, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số kw trong định mức:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(475, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số kw vượt định mức:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(475, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 99);
            this.panel1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 60);
            this.label9.TabIndex = 15;
            this.label9.Text = "Định mức là 50kw\r\nTrong định mức là 500đ/1Kw\r\nVượt định mức là 1000đ/1Kw";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(61, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng tiền phải trả:";
            // 
            // XuatThongTin
            // 
            this.XuatThongTin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.XuatThongTin.Location = new System.Drawing.Point(475, 289);
            this.XuatThongTin.Name = "XuatThongTin";
            this.XuatThongTin.Size = new System.Drawing.Size(313, 127);
            this.XuatThongTin.TabIndex = 15;
            this.XuatThongTin.Paint += new System.Windows.Forms.PaintEventHandler(this.XuatThongTin_Paint);
            // 
            // TinhTien
            // 
            this.TinhTien.Location = new System.Drawing.Point(61, 355);
            this.TinhTien.Name = "TinhTien";
            this.TinhTien.Size = new System.Drawing.Size(94, 29);
            this.TinhTien.TabIndex = 0;
            this.TinhTien.Text = "Tính";
            this.TinhTien.UseVisualStyleBackColor = true;
            this.TinhTien.Click += new System.EventHandler(this.TinhTien_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(155, 409);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(94, 29);
            this.Thoat.TabIndex = 2;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vũ Việt Anh",
            "Trần Lê Gia Hiển",
            "Nguyễn Khắc Phúc",
            "Nguyễn Việt Hưng"});
            this.comboBox1.Location = new System.Drawing.Point(189, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SoDienCu
            // 
            this.SoDienCu.Location = new System.Drawing.Point(155, 119);
            this.SoDienCu.Name = "SoDienCu";
            this.SoDienCu.Size = new System.Drawing.Size(136, 27);
            this.SoDienCu.TabIndex = 9;
            this.SoDienCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoDienCu_KeyPress);
            // 
            // SoDienMoi
            // 
            this.SoDienMoi.Location = new System.Drawing.Point(155, 170);
            this.SoDienMoi.Name = "SoDienMoi";
            this.SoDienMoi.Size = new System.Drawing.Size(136, 27);
            this.SoDienMoi.TabIndex = 10;
            this.SoDienMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoDienMoi_KeyPress);
            // 
            // SoDienTieuThu
            // 
            this.SoDienTieuThu.Location = new System.Drawing.Point(155, 215);
            this.SoDienTieuThu.Name = "SoDienTieuThu";
            this.SoDienTieuThu.Size = new System.Drawing.Size(136, 27);
            this.SoDienTieuThu.TabIndex = 11;
            this.SoDienTieuThu.TextChanged += new System.EventHandler(this.SoDienTieuThu_TextChanged);
            // 
            // TienTra
            // 
            this.TienTra.Location = new System.Drawing.Point(61, 289);
            this.TienTra.Name = "TienTra";
            this.TienTra.Size = new System.Drawing.Size(230, 27);
            this.TienTra.TabIndex = 12;
            this.TienTra.TextChanged += new System.EventHandler(this.TienTra_TextChanged);
            // 
            // SoDienDinhMuc
            // 
            this.SoDienDinhMuc.Location = new System.Drawing.Point(655, 77);
            this.SoDienDinhMuc.Name = "SoDienDinhMuc";
            this.SoDienDinhMuc.Size = new System.Drawing.Size(125, 27);
            this.SoDienDinhMuc.TabIndex = 13;
            this.SoDienDinhMuc.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // SoDienQua
            // 
            this.SoDienQua.Location = new System.Drawing.Point(655, 131);
            this.SoDienQua.Name = "SoDienQua";
            this.SoDienQua.Size = new System.Drawing.Size(125, 27);
            this.SoDienQua.TabIndex = 14;
            this.SoDienQua.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Click_In
            // 
            this.Click_In.Location = new System.Drawing.Point(263, 355);
            this.Click_In.Name = "Click_In";
            this.Click_In.Size = new System.Drawing.Size(94, 29);
            this.Click_In.TabIndex = 16;
            this.Click_In.Text = "In";
            this.Click_In.UseVisualStyleBackColor = true;
            this.Click_In.Click += new System.EventHandler(this.Click_In_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Click_In);
            this.Controls.Add(this.SoDienQua);
            this.Controls.Add(this.SoDienDinhMuc);
            this.Controls.Add(this.TienTra);
            this.Controls.Add(this.SoDienTieuThu);
            this.Controls.Add(this.SoDienMoi);
            this.Controls.Add(this.SoDienCu);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TinhTien);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.XuatThongTin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Label label8;
        private Panel XuatThongTin;
        private Button TinhTien;
        private Button Thoat;
        private ComboBox comboBox1;
        private TextBox SoDienCu;
        private TextBox SoDienMoi;
        private TextBox SoDienTieuThu;
        private TextBox TienTra;
        private TextBox SoDienDinhMuc;
        private TextBox SoDienQua;
        private Label label9;
        private Button Click_In;
    }
}