using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;


namespace BTL_Tu.Models
{
    public class HocSinh
    {
        [Key]
        public int MaSoHocSinh { get; set; } 
        
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public int MaSoPhuHuynh { get; set; }
        
        public virtual PhuHuynh PhuHuynh { get; set; }
    }
}