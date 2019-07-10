﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace GUI
{
    public partial class Form1 : Form
    {
        public ThuVienDB db; 
        public Form1()
        {
            InitializeComponent();
            db = new ThuVienDB();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            dgv_ListMuonTra.DataSource = db.LoaiSachs.Select(s => s);
            
        }

    }
}
