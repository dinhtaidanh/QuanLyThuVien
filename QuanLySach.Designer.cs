﻿namespace ManHinhChinh
{
    partial class QuanLySach
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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwDanhSach_Sach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemSach = new System.Windows.Forms.TextBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnTimKiemSach = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.Width = 70;
            // 
            // lvwDanhSach_Sach
            // 
            this.lvwDanhSach_Sach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvwDanhSach_Sach.Location = new System.Drawing.Point(33, 94);
            this.lvwDanhSach_Sach.Name = "lvwDanhSach_Sach";
            this.lvwDanhSach_Sach.Size = new System.Drawing.Size(891, 405);
            this.lvwDanhSach_Sach.TabIndex = 14;
            this.lvwDanhSach_Sach.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSach_Sach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sách";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sách";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Loại Sách";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã NXB";
            this.columnHeader5.Width = 70;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1154, 328);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 83);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(26, 50);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 68);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1047, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 170);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy Chọn";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(219, 50);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 68);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(118, 50);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 68);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Danh Sách Các Loại Sách:";
            // 
            // txtTimKiemSach
            // 
            this.txtTimKiemSach.Location = new System.Drawing.Point(303, 35);
            this.txtTimKiemSach.Multiline = true;
            this.txtTimKiemSach.Name = "txtTimKiemSach";
            this.txtTimKiemSach.Size = new System.Drawing.Size(199, 33);
            this.txtTimKiemSach.TabIndex = 15;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Còn Lại";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã KH Mượn";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giá Thuê";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Vị Trí";
            this.columnHeader9.Width = 70;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(945, 94);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(77, 68);
            this.btnChiTiet.TabIndex = 16;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.Location = new System.Drawing.Point(539, 35);
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.Size = new System.Drawing.Size(77, 34);
            this.btnTimKiemSach.TabIndex = 16;
            this.btnTimKiemSach.Text = "Tìm Kiếm";
            this.btnTimKiemSach.UseVisualStyleBackColor = true;
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 546);
            this.Controls.Add(this.btnTimKiemSach);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.txtTimKiemSach);
            this.Controls.Add(this.lvwDanhSach_Sach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QuanLySach";
            this.Text = "QuanLySach";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvwDanhSach_Sach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtTimKiemSach;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnTimKiemSach;
    }
}