using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BTL_Tu.Models
{
    public class PhuHuynh
    {
        [Key]
        public int MaSoPhuHuynh {get;set;}
        
        public string Ten {get;set;}
        public string SoDienThoai {get;set;}
        public string QuanHe {get;set;}
        public string DiaChi {get;set;}
        
        public virtual ICollection<HocSinh> HocSinhs { get; set; }
    }
}