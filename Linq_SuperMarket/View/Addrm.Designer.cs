namespace GUI
{
    partial class Addrm
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdn_HetHang = new System.Windows.Forms.RadioButton();
            this.rdn_ConHang = new System.Windows.Forms.RadioButton();
            this.cbb_NhaSx = new System.Windows.Forms.ComboBox();
            this.cbb_MatHang = new System.Windows.Forms.ComboBox();
            this.dtm_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.lbl_TinhTrang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(459, 264);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(222, 264);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 10;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdn_HetHang);
            this.groupBox1.Controls.Add(this.rdn_ConHang);
            this.groupBox1.Controls.Add(this.cbb_NhaSx);
            this.groupBox1.Controls.Add(this.cbb_MatHang);
            this.groupBox1.Controls.Add(this.dtm_NgayNhap);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_Ma);
            this.groupBox1.Controls.Add(this.lbl_TinhTrang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 212);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // rdn_HetHang
            // 
            this.rdn_HetHang.AutoSize = true;
            this.rdn_HetHang.Location = new System.Drawing.Point(576, 159);
            this.rdn_HetHang.Name = "rdn_HetHang";
            this.rdn_HetHang.Size = new System.Drawing.Size(71, 17);
            this.rdn_HetHang.TabIndex = 8;
            this.rdn_HetHang.TabStop = true;
            this.rdn_HetHang.Text = "Hết Hàng";
            this.rdn_HetHang.UseVisualStyleBackColor = true;
            // 
            // rdn_ConHang
            // 
            this.rdn_ConHang.AutoSize = true;
            this.rdn_ConHang.Location = new System.Drawing.Point(497, 159);
            this.rdn_ConHang.Name = "rdn_ConHang";
            this.rdn_ConHang.Size = new System.Drawing.Size(73, 17);
            this.rdn_ConHang.TabIndex = 8;
            this.rdn_ConHang.TabStop = true;
            this.rdn_ConHang.Text = "Còn Hàng";
            this.rdn_ConHang.UseVisualStyleBackColor = true;
            // 
            // cbb_NhaSx
            // 
            this.cbb_NhaSx.FormattingEnabled = true;
            this.cbb_NhaSx.Location = new System.Drawing.Point(497, 94);
            this.cbb_NhaSx.Name = "cbb_NhaSx";
            this.cbb_NhaSx.Size = new System.Drawing.Size(121, 21);
            this.cbb_NhaSx.TabIndex = 7;
            // 
            // cbb_MatHang
            // 
            this.cbb_MatHang.FormattingEnabled = true;
            this.cbb_MatHang.Location = new System.Drawing.Point(497, 31);
            this.cbb_MatHang.Name = "cbb_MatHang";
            this.cbb_MatHang.Size = new System.Drawing.Size(121, 21);
            this.cbb_MatHang.TabIndex = 7;
            // 
            // dtm_NgayNhap
            // 
            this.dtm_NgayNhap.Location = new System.Drawing.Point(108, 161);
            this.dtm_NgayNhap.Name = "dtm_NgayNhap";
            this.dtm_NgayNhap.Size = new System.Drawing.Size(200, 20);
            this.dtm_NgayNhap.TabIndex = 6;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(108, 94);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(200, 20);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(108, 28);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(200, 20);
            this.txt_Ma.TabIndex = 4;
            // 
            // lbl_TinhTrang
            // 
            this.lbl_TinhTrang.AutoSize = true;
            this.lbl_TinhTrang.Location = new System.Drawing.Point(418, 161);
            this.lbl_TinhTrang.Name = "lbl_TinhTrang";
            this.lbl_TinhTrang.Size = new System.Drawing.Size(59, 13);
            this.lbl_TinhTrang.TabIndex = 1;
            this.lbl_TinhTrang.Text = "Tình Trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhà Sản Xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mặt  hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số";
            // 
            // Addrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 309);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.groupBox1);
            this.Name = "Addrm";
            this.Text = "Addrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdn_HetHang;
        private System.Windows.Forms.RadioButton rdn_ConHang;
        private System.Windows.Forms.ComboBox cbb_NhaSx;
        private System.Windows.Forms.ComboBox cbb_MatHang;
        private System.Windows.Forms.DateTimePicker dtm_NgayNhap;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label lbl_TinhTrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}