using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUIs
{
    public partial class MainForm : Form
    {
        public Bll_SanPham bll_SanPham { set; get; }

        public MainForm()
        {
            InitializeComponent();
            this.bll_SanPham = new Bll_SanPham();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            dgv_ListSanPham.DataSource = this.bll_SanPham.getListSp();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //load cbb TMH & NSX
            load_Cbb();
            //load cbb_options
            cbb_Options.Items.Add("Accending");
            cbb_Options.Items.Add("Deccending");
            //load cbb_Sort
            SanPham obj = new SanPham();
            foreach (var prop in obj.GetType().GetProperties())
            {
                cbb_Sort.Items.Add(prop.Name);
            }
        }
        private void load_Cbb()
        {
            //lay data
            List<SanPham> sanPhams = this.bll_SanPham.getListSp();
            //load cac field len cac cbb tuong ung

            //cbb_MH
            foreach (var data in sanPhams.Select(sp => sp.Ten_Mat_Hang).Distinct().ToList())
            {
                cbb_MatHang.Items.Add(data);
            }

            //cbb_NSX
            foreach (var data in sanPhams.Select(sp => sp.Nha_San_Xuat).Distinct().ToList())
            {
                cbb_NhaSx.Items.Add(data);
            }

        }
        private void dgv_ListSanPham_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // load du lieu items duoc chon len cac truong UI
            //Lay maSp de lay data
            string maSp = dgv_ListSanPham.SelectedRows[0].Cells[0].Value.ToString();
            //lay du lieu 
            SanPham obj = this.bll_SanPham.getListSp(maSp)[0];
            //load len cac truong
            txt_Ma.Text = obj.Ma_San_Pham;
            txt_Name.Text = obj.Ten_San_Pham;
            dtp_NgayNhap.Value = obj.Ngay_Nhap_Hang.Value;
            cbb_MatHang.SelectedItem = obj.Ten_Mat_Hang;
            cbb_NhaSx.SelectedItem = obj.Nha_San_Xuat;
            if (obj.Tinh_Trang_Hang.Value)
            {
                rdn_ConHang.Checked = true;
            }
            else
            {
                rdn_HetHang.Checked = true;
            }
        }
         private void btn_Update_Click(object sender, EventArgs e)
        {
            //lay du lieu tren man hinh de thuc hien update
            SanPham obj = new SanPham
            {
                Ma_San_Pham = txt_Ma.Text,
                Ten_San_Pham = txt_Name.Text,
                Ngay_Nhap_Hang = dtp_NgayNhap.Value,
                Ten_Mat_Hang = cbb_MatHang.SelectedItem.ToString(),
                Nha_San_Xuat = cbb_NhaSx.SelectedItem.ToString(),
                Tinh_Trang_Hang = (rdn_ConHang.Checked ? true : false)
            };
            // thuc hien update 
            this.bll_SanPham.updateSp(obj);
            this.btn_Show.PerformClick();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //lay danh sach cac doi tuong can xoa
            List<string> maSps = new List<string>();
            for(int i = 0; i < dgv_ListSanPham.SelectedRows.Count; i++)
            {
                maSps.Add(dgv_ListSanPham.SelectedRows[i].Cells[0].Value.ToString());    
            }
            // thuc hien xoa data
            this.bll_SanPham.deletes(maSps);
            this.btn_Show.PerformClick();
        }
    }
}
