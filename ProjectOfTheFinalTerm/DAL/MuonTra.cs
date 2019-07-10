using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class MuonTra
    {
        [Key]
        [Column(Order = 1)]
        public string MaNv { set; get; }
        [Key]
        [Column(Order = 2)]
        public string MaDg { set; get; }
        [ForeignKey("MaSach")]
        public virtual Sach Sach { set; get; }
        public virtual DocGia DocGia { set; get; }
        public virtual NhanVien NhanVien { set; get; }
        public DateTime NgayMuon { set; get; }

        public DateTime NgayTra { set; get; }
        public DateTime NgayHenTra { set; get; }


    }
}
