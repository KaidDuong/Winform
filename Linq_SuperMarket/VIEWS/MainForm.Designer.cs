namespace VIEWS
{
    partial class MainForm
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
            this.cbb_Options = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cbb_Sort = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ListSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdn_HetHang = new System.Windows.Forms.RadioButton();
            this.rdn_ConHang = new System.Windows.Forms.RadioButton();
            this.cbb_NhaSx = new System.Windows.Forms.ComboBox();
            this.cbb_MatHang = new System.Windows.Forms.ComboBox();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_Options
            // 
            this.cbb_Options.FormattingEnabled = true;
            this.cbb_Options.Location = new System.Drawing.Point(280, 465);
            this.cbb_Options.Name = "cbb_Options";
            this.cbb_Options.Size = new System.Drawing.Size(127, 21);
            this.cbb_Options.TabIndex = 55;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Search);
            this.groupBox3.Location = new System.Drawing.Point(571, 447);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 40);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhap Ma San Pham Muon Tim";
            // 
            // txt_Search
            // 
            this.txt_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_Search.Location = new System.Drawing.Point(3, 17);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(224, 20);
            this.txt_Search.TabIndex = 38;
            // 
            // cbb_Sort
            // 
            this.cbb_Sort.FormattingEnabled = true;
            this.cbb_Sort.Location = new System.Drawing.Point(109, 466);
            this.cbb_Sort.Name = "cbb_Sort";
            this.cbb_Sort.Size = new System.Drawing.Size(150, 21);
            this.cbb_Sort.TabIndex = 51;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(196, 408);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 45;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(411, 464);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(157, 23);
            this.btn_Search.TabIndex = 46;
            this.btn_Search.Text = "Search Theo Ma Sp";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(571, 408);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 47;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(28, 464);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.btn_Sort.TabIndex = 48;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(375, 408);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 49;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(28, 408);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(75, 23);
            this.btn_Show.TabIndex = 50;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(713, 408);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(88, 23);
            this.btn_Exit.TabIndex = 53;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ListSanPham);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 181);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sản Phẩm";
            // 
            // dgv_ListSanPham
            // 
            this.dgv_ListSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ListSanPham.GridColor = System.Drawing.Color.Aqua;
            this.dgv_ListSanPham.Location = new System.Drawing.Point(3, 16);
            this.dgv_ListSanPham.Name = "dgv_ListSanPham";
            this.dgv_ListSanPham.Size = new System.Drawing.Size(702, 162);
            this.dgv_ListSanPham.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdn_HetHang);
            this.groupBox1.Controls.Add(this.rdn_ConHang);
            this.groupBox1.Controls.Add(this.cbb_NhaSx);
            this.groupBox1.Controls.Add(this.cbb_MatHang);
            this.groupBox1.Controls.Add(this.dtp_NgayNhap);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_Ma);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 212);
            this.groupBox1.TabIndex = 44;
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
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.Location = new System.Drawing.Point(108, 161);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(200, 20);
            this.dtp_NgayNhap.TabIndex = 6;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tình Trạng";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 490);
            this.Controls.Add(this.cbb_Options);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbb_Sort);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_Options;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cbb_Sort;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_ListSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdn_HetHang;
        private System.Windows.Forms.RadioButton rdn_ConHang;
        private System.Windows.Forms.ComboBox cbb_NhaSx;
        private System.Windows.Forms.ComboBox cbb_MatHang;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}