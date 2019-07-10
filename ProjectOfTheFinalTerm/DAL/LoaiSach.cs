using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
   public class LoaiSach
    {
        [Key]
        public string MaLoai { set; get; }
        public string TenLoai { set; get; }
        //public int ViTri { set; get; }
        //public ICollection<Sach> Sachs { get; set; }
    }
    //data source=KAIDDUONG;initial catalog=DAL.ThuVienDB;integrated security=True;
}
