using System;
using System.ComponentModel.DataAnnotations;

namespace BTL_Tu.Models
{
    public class HoSo
    {
        [Key]
        public int MaSoHoSo{get;set;}
        
        public DateTime NgayTao{get;set;}
        public int MaSoHocSinh{get;set;}
        public string MoTa{get;set;}
        
        public virtual HocSinh HocSinh { get; set; }
    }
}