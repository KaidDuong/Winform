using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class Bll_SanPham
    {
        SuperMarketDataContext db = new SuperMarketDataContext();
        public List<SanPham> getListSp(string maSp = "")
        {
            if (maSp == "")
            {
                return db.SanPhams.Select(sp => sp).ToList<SanPham>();
            }

            return db.SanPhams.Select(st => st).Where(st => st.Ma_San_Pham == maSp).ToList<SanPham>();
        }

        public void updateSp(SanPham obj)
        {
            //checked xem san pham da co trong database hay chua
            try
            {//neu co roi thi thuc hien update
                var sP = this.db.SanPhams.Single(sp => sp.Ma_San_Pham == obj.Ma_San_Pham);
                sP.Ten_San_Pham = obj.Ten_San_Pham;
                sP.Ngay_Nhap_Hang = obj.Ngay_Nhap_Hang;
                sP.Ten_Mat_Hang = obj.Ten_Mat_Hang;
                sP.Nha_San_Xuat = obj.Nha_San_Xuat;
                sP.Tinh_Trang_Hang = obj.Tinh_Trang_Hang;
                db.SubmitChanges();
               
            }
            catch
            { //neu chua co thi thuc hien add 
                addSp(obj);
                
            }
            
           
        }
        public void addSp(SanPham obj)
        {
            try
            {
                db.SanPhams.InsertOnSubmit(obj);
            }
            finally
            {
                db.SubmitChanges();
            }
        }

        public void deletes(List<string> maSps)
        {
            try
            {
                var sanphams = this.db.SanPhams.Select(sp => sp).Where(sp => maSps.Contains(sp.Ma_San_Pham)).ToList();
                this.db.SanPhams.DeleteAllOnSubmit(sanphams);
                this.db.SubmitChanges();
            }

            catch
            {

            }
               
        }
    }
}
