using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
   public class DocGia
    {
        [Key]
        public string Madg { set; get; }
        public string HoTen { set; get; }
        public bool GioiTinh { set; get; }
        public DateTime NgaySinh { set; get; }
        public string DiaChi { set; get; }
        public string CoQuan { set; get; }
        public virtual MuonTra MuonTra { get; set; }
    }
}
