using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class NhanVien
    {
        [Key]
        public string MaNv { set; get; }
        public string HoTen { set; get; }
        public bool GioiTinh { set; get; }
        public virtual MuonTra MuonTra { get; set; }
    }
}
