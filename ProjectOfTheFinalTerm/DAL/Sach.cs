using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class Sach
    {
        [Key]
        [Column(Order = 1)]
        public string MaSach { set; get; }
        public string TenSach { set; get; }
        public int SoTrang { set; get; }
        public string TacGia { set; get; }
       
        public string NhaSanXuat { set; get; }
        public int SoLuong { set; get; }
        //set khoa ngoai
        //public virtual LoaiSach LoaiSach { set; get; }
        
        public virtual MuonTra MuonTra { get; set; }
    }
}
