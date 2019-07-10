using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace VIEWS
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
            foreach(var prop in obj.GetType().GetProperties())
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
            foreach(var data in sanPhams.Select(sp => sp.Ten_Mat_Hang).Distinct().ToList())
            {
                cbb_MatHang.Items.Add(data);
            }

            //cbb_NSX
            foreach(var data in sanPhams.Select(sp => sp.Nha_San_Xuat).Distinct().ToList())
            {
                cbb_NhaSx.Items.Add(data);
            }
            
        }
    }
}
